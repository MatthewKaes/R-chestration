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

namespace Conduct_R
{
  public partial class Form1 : Form
  {
    Dictionary<string, List<string>> rDataFrame = null;

    public Form1()
    {
      InitializeComponent();
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
      }
      else
      {
        dataFrameHeader1.Enabled = false;
        plotButton.Enabled = false;
      }
    }
  }
}
