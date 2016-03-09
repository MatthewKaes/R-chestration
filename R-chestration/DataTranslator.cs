using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDotNet;
using System.Collections;

namespace RChestration.Utilities
{
  public class DataTranslator
  {
    public static void RImportDataFrame(REngine targetEngine, Dictionary<string, List<string>> rDataFrame)
    {
      SortedSet<string> headerSet = new SortedSet<string>(rDataFrame.Keys);
      IEnumerable[] dataBlock = new IEnumerable[rDataFrame.Keys.Count()];

      int index = 0;
      foreach (string header in headerSet)
      {
        dataBlock[index++] = rDataFrame[header].Select<string, double>(s => Convert.ToDouble(s)).ToArray();
      }

      DataFrame df = targetEngine.CreateDataFrame(dataBlock, headerSet.ToArray());
      targetEngine.SetSymbol("impData", df);
    }
  }
}