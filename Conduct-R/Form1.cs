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

namespace Conduct_R
{
  public partial class Form1 : Form
  {
    Dictionary<string, List<string>> rDataFrame = null;
    REngine rEngine = null;

    public Form1()
    {
      InitializeComponent();

      // Setup the R-Engine to use R
      rEngine = REngine.GetInstance();
      rEngine.Initialize();

      // Install all of our required packages.
      rEngine.Evaluate("list.of.packages <- c(\"ggplot2\", \"Cairo\")");
      rEngine.Evaluate("new.packages <- list.of.packages[!(list.of.packages %in% installed.packages()[,\"Package\"])]");
      rEngine.Evaluate("if(length(new.packages)) install.packages(new.packages)");

      // Use ggplot
      rEngine.Evaluate("library(ggplot2)");
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void openDataframeDialog_FileOk(object sender, CancelEventArgs e)
    {

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
        dataFrameHeader1.Items.AddRange(rDataFrame.Keys.ToArray());
        dataFrameHeader1.SelectedIndex = 0;
        dataFrameHeader1.Enabled = true;
        plotButton.Enabled = true;

        DataTranslator.RImportDataFrame(rEngine, rDataFrame);
      }
      else
      {
        dataFrameHeader1.Enabled = false;
        plotButton.Enabled = false;
      }
    }

    private void RenderData()
    {
      Graphics g = this.CreateGraphics();
      try
      {
        rEngine.Evaluate("xLen <- seq(1, length(impData))");

        string graphCommand = "p <- ggplot(impData, aes(y=" + dataFrameHeader1.SelectedItem + ", x=xLen)) + geom_point(shape=1)";
        rEngine.Evaluate(graphCommand);
        rEngine.Evaluate("ggsave(filename=\"plot.png\", plot=p, width=" + (graphTarget.Width / g.DpiX) + ", height=" + (graphTarget.Height / g.DpiX) + ", units=\"in\", dpi=" + g.DpiX + ")");
      }
      finally
      {
        g.Dispose();
      }
    }

    private void plotButton_Click(object sender, EventArgs e)
    {
      RenderData();

      if (File.Exists("plot.png"))
      {
        graphTarget.ImageLocation = "plot.png";
      }
    }
  }
}
