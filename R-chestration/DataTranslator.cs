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
      SortedDictionary<string, List<string>> sortedFrame = new SortedDictionary<string, List<string>>(rDataFrame);

      IEnumerable[] dataBlock = new IEnumerable[rDataFrame.Keys.Count()];
      for(int index = 0; index < rDataFrame.Keys.Count(); index++)
      {
        dataBlock[index] = sortedFrame.Select(e => e.Value[index]).ToArray();
      }

      DataFrame df = targetEngine.CreateDataFrame(dataBlock, headerSet.ToArray());
      targetEngine.SetSymbol("impData", df);
    }
  }
}