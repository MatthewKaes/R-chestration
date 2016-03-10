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

    public Form1()
    {
      InitializeComponent();

      graphDesign.SelectedIndex = 0;
      modelSelect.SelectedIndex = 0;

      // Setup the R-Engine to use R
      rEngine = REngine.GetInstance();
      rEngine.Initialize();

      // Install all of our required packages.
      rEngine.Evaluate("list.of.packages <- c(\"ggplot2\", \"Cairo\")");
      rEngine.Evaluate("new.packages <- list.of.packages[!(list.of.packages %in% installed.packages()[,\"Package\"])]");
      rEngine.Evaluate("if(length(new.packages)) install.packages(new.packages)");

      // Use ggplot
      rEngine.Evaluate("library(ggplot2)");
      rEngine.Evaluate("library(Cairo");
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = openDataframeDialog.ShowDialog(); 
      if (result == DialogResult.OK)
      {
        string file = openDataframeDialog.FileName;
        rDataFrame = DataFrameProcessor.LoadDataFrame(file);

        if (rDataFrame.Keys.Count() == 0)
        {
          rDataFrame = null;
        }

        processDataFrame();
      }
    }

    private void processDataFrame()
    {
      if (rDataFrame != null)
      {
        DataTranslator.RImportDataFrame(rEngine, rDataFrame);

        dataFrameHeader1.Items.AddRange(rDataFrame.Keys.ToArray());
        dataFrameHeader1.SelectedIndex = 0;
        dataFrameHeader1.Enabled = true;
        SortedSet<string> sortedKeys = new SortedSet<string>(rDataFrame.Keys);
        dataFrameHeader2.Items.Add("Time Sequence");
        dataFrameHeader2.Items.AddRange(sortedKeys.ToArray());
        dataFrameHeader2.SelectedIndex = 0;
        dataFrameHeader2.Enabled = true;
        elementSizeTrack.Enabled = true;

        allowRender = true;
      }
      else
      {
        allowRender = false;
        dataFrameHeader1.Enabled = false;
        dataFrameHeader2.Enabled = false;
      }
    }

    private void RenderData()
    {
      allowRender = false;
      Graphics g = this.CreateGraphics();
      try
      {
        rEngine.Evaluate("xLen <- seq(1, " + rDataFrame.First().Value.Count() + ")");

        string graphCommand = "p <- ggplot(impData, aes(y=" + dataFrameHeader1.SelectedItem + ", x=" + GetSequence() + "))";
        if (confidenceInterval.Checked)
        {
          graphCommand += " + geom_smooth(aes(y=" + dataFrameHeader1.SelectedItem + ", x=" + GetSequence() + ")," + GetModel() + " level=0.99, alpha=0.25, linetype=0)";
          graphCommand += " + geom_smooth(aes(y=" + dataFrameHeader1.SelectedItem + ", x=" + GetSequence() + ")," + GetModel() + " level=0.95, alpha=0.25, linetype=0)";
          graphCommand += " + geom_smooth(aes(y=" + dataFrameHeader1.SelectedItem + ", x=" + GetSequence() + ")," + GetModel() + " level=0.68, alpha=0.25, linetype=0)";
        }

        if (graphDesign.Text.Equals("Scatter", StringComparison.InvariantCultureIgnoreCase))
        {
          graphCommand += " + geom_point(shape=1, size=" + elementSizeTrack.Value / 4.0 + ")";
        }
        else if (graphDesign.Text.Equals("Line", StringComparison.InvariantCultureIgnoreCase))
        {
          graphCommand += " + geom_line(size=" + elementSizeTrack.Value / 10.0 + ")";
        }
        else
        {
          graphCommand += " + geom_point(shape=1)";
        }

        if (trendLine.Checked)
        {
          graphCommand += " + geom_smooth(aes(y=" + dataFrameHeader1.SelectedItem + ", x=" + GetSequence() + ")," + GetModel() + ", alpha=0, size=1.2)";
        }

        // Add Aesthetics
        graphCommand += " + labs(x=\"" + xLabel.Text + "\",y=\"" + yLabel.Text + "\")";
        if (!string.IsNullOrEmpty(titleText.Text))
        {
          graphCommand += " + ggtitle(\"" + titleText.Text + "\")";
        }

        rEngine.Evaluate(graphCommand);

        try
        {
          rEngine.Evaluate("ggsave(filename=\"plot.png\", plot=p, type = \"cairo-png\", width=" + (graphTarget.Width / g.DpiX) + ", height=" + (graphTarget.Height / g.DpiX) + ", units=\"in\", dpi=" + g.DpiX + ")");
        }
        catch{ }
      }
      finally
      {
        g.Dispose();
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

    private void dataFrameHeader1_SelectedIndexChanged(object sender, EventArgs e)
    {
      yLabel.Text = dataFrameHeader1.SelectedItem.ToString();
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

    private void timer1_Tick(object sender, EventArgs e)
    {
      lock(drawLock)
      {
        if (!allowRender)
        {
          return;
        }

        if (shouldRender && rDataFrame != null)
        {
          shouldRender = false;
          RenderData();
        }
      }
    }
  }
}
