using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RChestration.Utilities
{
  class DataFrameProcessor
  {
    static public Dictionary<string, List<string>> LoadDataFrame(string csvTarget)
    {
      Dictionary<string, List<string>> dataFrame = new Dictionary<string, List<string>>();
      using (StreamReader file = new StreamReader(csvTarget))
      {
        string header = file.ReadLine();
        if (!string.IsNullOrEmpty(header))
        {
          List<string> dataFrameHeaders = new List<string>(header.Split(','));
          List<List<string>> dataFrameRows = new List<List<string>>();

          string line = file.ReadLine();
          while (line != null)
          {
            dataFrameRows.Add(new List<string>(line.Split(',')));
            line = file.ReadLine();
          }

          for (int index = 0; index < dataFrameHeaders.Count; index++)
          {
            dataFrame.Add(dataFrameHeaders[index], dataFrameRows.Select<List<string>, string>(row => row[index]).ToList());
          }
        }
      }
      return dataFrame;
    }

    static public void SaveDataFrame(Dictionary<string, List<string>> dataFrame, string csvTarget)
    {
      using (StreamWriter file = new StreamWriter(csvTarget))
      {
        SortedSet<string> headerSet = new SortedSet<string>(dataFrame.Keys);
        SortedDictionary<string, List<string>> sortedFrame = new SortedDictionary<string, List<string>>(dataFrame);
        file.WriteLine(string.Join(",", headerSet.AsEnumerable()));

        for (int index = 0; index < sortedFrame.First().Value.Count(); index++)
        {
          file.WriteLine(string.Join(",", sortedFrame.Select(e => e.Value[index])));
        }
      }
    }
  }
}
