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
        DataTranslator.RImportDataFrame(rEngine, rDataFrame);

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
      preamble += "list.of.packages <- c(\"ggplot2\", \"Cairo\")\n";
      preamble += "new.packages <- list.of.packages[!(list.of.packages %in% installed.packages()[,\"Package\"])]\n";
      preamble += "if(length(new.packages)) install.packages(new.packages)\n";

      // Use ggplot
      preamble += "library(ggplot2)\n";
      // Use Cairo
      preamble += "library(Cairo)\n";

      return preamble;
    }

    private string RLoader()
    {
      return "impData <- read.csv(file=\"" + dataFrameSource + "\",head=TRUE,sep=\",\")";
    }

    private string RGraphCommand()
    {
      string graphCommand = "p <- ggplot(impData)\n";
      foreach (var item in dataFeatures.CheckedItems)
      {
        if (confidenceInterval.Checked)
        {
          graphCommand += "p <- p + geom_smooth(aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + " level=0.99, alpha=0.25, linetype=0)\n";
          graphCommand += "p <- p + geom_smooth(aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + " level=0.95, alpha=0.25, linetype=0)\n";
          graphCommand += "p <- p + geom_smooth(aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + " level=0.68, alpha=0.25, linetype=0)\n";
        }

        if (graphDesign.Text.Equals("Scatter", StringComparison.InvariantCultureIgnoreCase))
        {
          graphCommand += "p <- p + geom_point(size=" + elementSizeTrack.Value / 4.0 + ", aes(y=" + item + ", x=" + GetSequence() + "))\n";
        }
        else if (graphDesign.Text.Equals("Line", StringComparison.InvariantCultureIgnoreCase))
        {
          graphCommand += "p <- p + geom_line(size=" + elementSizeTrack.Value / 10.0 + ", aes(y=" + item + ", x=" + GetSequence() + "))\n";
        }
        else
        {
          graphCommand += "p <- p + geom_point(shape=1, aes(y=" + item + ", x=" + GetSequence() + "))\n";
        }

        if (trendLine.Checked)
        {
          graphCommand += "p <- p + geom_smooth(aes(y=" + item + ", x=" + GetSequence() + ")," + GetModel() + ", alpha=0, size=1.2)\n";
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
      return "ggsave(filename=\"plot.png\", plot=p, type = \"cairo-png\", width=" + (graphTarget.Width / (float)dpiTicker.Value) + ", height=" + (graphTarget.Height / (float)dpiTicker.Value) + ", units=\"in\", dpi=" + dpiTicker.Value + ")";
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
        rEngine.Evaluate("xLen <- seq(1, " + rDataFrame.First().Value.Count() + ")");
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

    private void dataFrameHeader2_SelectedIndexChanged(object sender, EventArgs e)
    {
      xLabel.Text = dataFrameHeader2.SelectedItem.ToString();
    }

    private void graphDesign_SelectedIndexChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void confidenceInterval_CheckedChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void trendLine_CheckedChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void modelSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void elementSizeTrack_Scroll(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void regressionCheck_CheckedChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void xLabel_TextChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void yLabel_TextChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void titleText_TextChanged(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void ResizeRedrawRender(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      shouldRender = true;
    }

    private void dataFeatures_SelectedIndexChanged(object sender, EventArgs e)
    {
      RenderData();
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
        string file = saveImageDialog.FileName;

        using (StreamWriter rWriter = new StreamWriter(file))
        {
          rWriter.WriteLine(RPreamble());
          rWriter.WriteLine(RLoader());
          rWriter.WriteLine();
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
