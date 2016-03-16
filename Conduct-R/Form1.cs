using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RChestration.Utilities;
using RDotNet;
using System.IO;
using System.Threading;

namespace Conduct_R
{
  public partial class Form1 : Form
  {
    Dictionary<string, List<string>> rDataFrame = null;
    REngine rEngine = null;
    private Object drawLock = new Object();
    bool shouldRender = false;
    bool allowRender = false;
    string dataFrameSource = null;

    public Form1()
    {
      InitializeComponent();

      graphDesign.SelectedIndex = 0;
      modelSelect.SelectedIndex = 0;

      // Setup the R-Engine to use R
      rEngine = REngine.GetInstance();
      rEngine.Initialize();

      // Install all of our required packages.
      rEngine.Evaluate(RPreamble());
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = openDataframeDialog.ShowDialog(); 
      if (result == DialogResult.OK)
      {
        dataFrameSource = openDataframeDialog.FileName;
        rDataFrame = DataFrameProcessor.LoadDataFrame(dataFrameSource);

        rEngine.Evaluate(RLoader());

        if (rDataFrame.Keys.Count() == 0)
        {
          rDataFrame = null;
        }

        ProcessDataFrame();
      }
    }

    private void ProcessDataFrame()
    {
      if (rDataFrame != null)
      {
        dataFeatures.Items.Clear();
        dataFeatures.Items.AddRange(rDataFrame.Keys.ToArray());
        dataFeatures.Enabled = true;
        SortedSet<string> sortedKeys = new SortedSet<string>(rDataFrame.Keys);
        dataFrameHeader2.Items.Add("Time Sequence");
        dataFrameHeader2.Items.AddRange(sortedKeys.ToArray());
        dataFrameHeader2.SelectedIndex = 0;
        dataFrameHeader2.Enabled = true;
        elementSizeTrack.Enabled = true;
        saveToolStripMenuItem.Enabled = true;

        allowRender = true;
      }
      else
      {
        allowRender = false;
        dataFeatures.Enabled = false;
        dataFrameHeader2.Enabled = false;
        saveToolStripMenuItem.Enabled = false;
      }
    }

    private string RPreamble()
    {
      string preamble = "";
      // Install all of our required packages.
      preamble += "list.of.packages <- c(\"ggplot2\", \"Cairo\", \"reshape2\")\n";
      preamble += "new.packages <- list.of.packages[!(list.of.packages %in% installed.packages()[,\"Package\"])]\n";
      preamble += "if(length(new.packages)) install.packages(new.packages)\n";

      // Use ggplot
      preamble += "library(ggplot2)\n";
      // Use Cairo
      preamble += "library(Cairo)\n";
      // Use Reshape2
      preamble += "library(reshape2)\n";

      return preamble;
    }

    private string RLoader()
    {
      string loader = "impData <- read.csv(file=\"" + dataFrameSource.Replace("\\", "\\\\") + "\",head=TRUE,sep=\",\")\n";
      loader += "impData[[\"xLen\"]] <- seq(1, nrow(impData))\n";
      return loader;
    }

    private string RMeltData()
    {
      string measures = string.Format("\"{0}\"", dataFeatures.CheckedItems[0]);
      for (int i = 1; i < dataFeatures.CheckedItems.Count; i++)
      {
        measures += string.Format(", \"{0}\"", dataFeatures.CheckedItems[i]);
      }
      return "meltData <- melt(impData, id=c(\"" + GetSequence() + "\"), measure=c(" + measures + "))";
    }

    private string RGraphCommand()
    {
      string graphCommand = "p <- ggplot(meltData)\n";

      // Preprocess
      foreach (var item in dataFeatures.CheckedItems)
      {
        if (confidenceInterval.Checked)
        {
          graphCommand += "p <- p + geom_smooth(data=impData, aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + " level=0.99, alpha=0.25, linetype=0)\n";
          graphCommand += "p <- p + geom_smooth(data=impData, aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + " level=0.95, alpha=0.25, linetype=0)\n";
          graphCommand += "p <- p + geom_smooth(data=impData, aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + " level=0.68, alpha=0.25, linetype=0)\n";
        }
      }


      if (graphDesign.Text.Equals("Scatter", StringComparison.InvariantCultureIgnoreCase))
      {
        graphCommand += "p <- p + geom_point(size=" + elementSizeTrack.Value / 4.0 + ", aes(y=value, x=" + GetSequence() + GetColorize() + "))\n";
      }
      else if (graphDesign.Text.Equals("Line", StringComparison.InvariantCultureIgnoreCase))
      {
        graphCommand += "p <- p + geom_line(size=" + elementSizeTrack.Value / 10.0 + ", aes(y=value, x=" + GetSequence() + GetColorize() + "))\n";
      }
      else
      {
        graphCommand += "p <- p + geom_point(shape=1, aes(y=value, x=" + GetSequence() + GetColorize() + "))\n";
      }

      // Postprocess
      foreach (var item in dataFeatures.CheckedItems)
      {
        if (trendLine.Checked)
        {
          graphCommand += "p <- p + geom_smooth(data=impData, aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + ", alpha=0, size=1.2)\n";
        }
      }

      // Add Aesthetics
      graphCommand += "p <- p + labs(x=\"" + xLabel.Text + "\",y=\"" + yLabel.Text + "\")\n";
      if (!string.IsNullOrEmpty(titleText.Text))
      {
        graphCommand += "p <- p + ggtitle(\"" + titleText.Text + "\")\n";
      }

      return graphCommand;
    }

    private string RSaveCommand()
    {
      string saveCommand = "ggsave(filename=\"plot.png\", plot=p, type = \"cairo-png\", width=" + (graphTarget.Width / (float)dpiTicker.Value) + ", height=" + (graphTarget.Height / (float)dpiTicker.Value) + ", units=\"in\", dpi=" + dpiTicker.Value + ")";
      return saveCommand;
    }

    private void RenderData()
    {
      if (dataFeatures.CheckedItems.Count == 0)
      {
        dataFeatures.SetItemChecked(0, true);
      }

      allowRender = false;
      try
      {
        rEngine.Evaluate(RMeltData());
        rEngine.Evaluate(RGraphCommand());

        try
        {
          rEngine.Evaluate(RSaveCommand());
        }
        catch{ }
      }
      finally
      {
        allowRender = true;
      }

      if (File.Exists("plot.png"))
      {
        graphTarget.ImageLocation = "plot.png";
      }
    }

    private string GetModel()
    {
      if (modelSelect.Text.Equals("Local", StringComparison.InvariantCultureIgnoreCase))
      {
        return " method=loess,";
      }
      else if (modelSelect.Text.Equals("General", StringComparison.InvariantCultureIgnoreCase))
      {
        return " method=glm,";
      }
      else if (modelSelect.Text.Equals("Linear", StringComparison.InvariantCultureIgnoreCase))
      {
        return " method=lm, formula = y ~ x,";
      }
      else if (modelSelect.Text.Equals("Quadratic", StringComparison.InvariantCultureIgnoreCase))
      {
        return " method=lm, formula = y ~ poly(x, 2),";
      }
      else if (modelSelect.Text.Equals("Cubic", StringComparison.InvariantCultureIgnoreCase))
      {
        return " method=lm, formula = y ~ poly(x, 3),";
      }

      return " method=lm, formula = y ~ x,";
    }

    private string GetSequence()
    {
      if (dataFrameHeader2.SelectedItem.Equals("Time Sequence"))
      {
        return "xLen";
      }
      else
      {
        return dataFrameHeader2.SelectedItem.ToString();
      }
    }

    private string GetColorize()
    {
      if (colorizeCheck.Checked)
      {
        return ", color=variable";
      }
      else
      {
        return "";
      }
    }

    private void dataFrameHeader2_SelectedIndexChanged(object sender, EventArgs e)
    {
      xLabel.Text = dataFrameHeader2.SelectedItem.ToString();
    }

    private void FlagForRender(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (!allowRender)
      {
        return;
      }

      if (shouldRender && rDataFrame != null)
      {
        lock(drawLock)
        {
          shouldRender = false;
          RenderData();
        }
      }
    }
    
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = saveImageDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        if (File.Exists("plot.png"))
        {
          string file = saveImageDialog.FileName;
          File.Copy("plot.png", file);
        }
      }
    }

    private void rScriptToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      DialogResult result = saveScriptDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        string file = saveScriptDialog.FileName;

        using (StreamWriter rWriter = new StreamWriter(file))
        {
          rWriter.WriteLine(RPreamble());
          rWriter.WriteLine(RLoader());
          rWriter.WriteLine(RMeltData());
          rWriter.WriteLine(RGraphCommand());
          rWriter.WriteLine(RSaveCommand());
        }
      }
    }

    private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = openScriptDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        string file = saveImageDialog.FileName;
        if (File.Exists(file))
        {
          rEngine.Evaluate(string.Join(Environment.NewLine, File.ReadAllLines(file)));
        }
      }
    }
  }
}
