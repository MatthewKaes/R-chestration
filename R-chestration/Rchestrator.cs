using RChestration.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RChestration.Telemetry
{
  public class Rchestrator<T> where T : class, new()
  {
    Dictionary<string, List<string>> rDataFrame;

    public int Size
    {
      get
      {
        return rDataFrame.First().Value.Count;
      }
    }

    public int Columns
    {
      get
      {
        return rDataFrame.Keys.Count;
      }
    }

    public List<string> Headers
    {
      get
      {
        return rDataFrame.Keys.ToList();
      }
    }

    private void ValidateDataFrame()
    {
      if (rDataFrame.Keys.Count == 0)
      {
        throw new InvalidDataException("The loaded data frame is empty and contains no headers.");
      }

      PropertyInfo[] properties = typeof(T).GetProperties();
      if (rDataFrame.Keys.Count != properties.Count())
      {
        throw new FormatException(string.Format(
                                  "The loaded data frame header is not the same size as the telemetry type properties." +
                                  "\nData Frame Size: {0}\nTelemetry Properties: {1}", 
                                  rDataFrame.Keys.Count, 
                                  properties.Count()));
      }

      HashSet<string> propertyNames = new HashSet<string>(properties.Select<PropertyInfo, string>(p => p.Name));
      foreach (string column in rDataFrame.Keys)
      {
        if (!propertyNames.Contains(column))
        {
          throw new FormatException(string.Format(
                                    "The loaded data frame header contains a mismatch with the telemetry type.\nBad Parameter: {0}",
                                    column));
        }
      }

      HashSet<int> lengths = new HashSet<int>(rDataFrame.Values.Select<List<string>, int>(l => l.Count));
      if (lengths.Count > 1)
      {
        throw new FormatException("The loaded data frame contains one or more rows with missing items.");
      }
    }

    public Rchestrator() 
    {
      rDataFrame = new Dictionary<string, List<string>>();
      PropertyInfo[] properties = typeof(T).GetProperties();
      foreach (PropertyInfo property in properties)
      {
        rDataFrame.Add(property.Name, new List<string>());
      }
    }

    public Rchestrator(string csvTarget)
    {
      rDataFrame = DataFrameProcessor.LoadDataFrame(csvTarget);
      ValidateDataFrame();
    }

    public Rchestrator(Dictionary<string, List<string>> dataFrame)
    {
      rDataFrame = dataFrame;
      ValidateDataFrame();
    }

    public void Log(T telemetryObject)
    {
      if (telemetryObject == null)
      {
        return;
      }

      PropertyInfo[] properties = typeof(T).GetProperties();
      foreach (PropertyInfo property in properties)
      {
        object item = property.GetValue(telemetryObject);
        if (item == null)
        {
          rDataFrame[property.Name].Add(string.Empty);
        }
        else
        {
          rDataFrame[property.Name].Add(item.ToString());
        }
      }
    }

    public void Update(T telemetryObject, int index)
    {
      if (telemetryObject == null)
      {
        return;
      }

      PropertyInfo[] properties = typeof(T).GetProperties();
      foreach (PropertyInfo property in properties)
      {
        object item = property.GetValue(telemetryObject);
        if (item == null)
        {
          rDataFrame[property.Name][index] = string.Empty;
        }
        else
        {
          rDataFrame[property.Name][index] = item.ToString();
        }
      }
    }

    public T DataPoint(int index)
    {
      if (index > Size || index < 0)
      {
        throw new ArgumentOutOfRangeException("index");
      }

      T point = new T();
      PropertyInfo[] properties = typeof(T).GetProperties();
      foreach (PropertyInfo property in properties)
      {
        if (string.IsNullOrWhiteSpace(rDataFrame[property.Name][index]) && 
            property.PropertyType != typeof(string))
        {
          property.SetValue(point, null);
        }
        else
        {
          property.SetValue(point, Convert.ChangeType(rDataFrame[property.Name][index], property.PropertyType));
        }
      }

      return point;
    }

    public List<T> PopulateData()
    {
      List<T> data = new List<T>();
      for(int i = 0; i < Size; i++)
      {
        data.Add(DataPoint(i));
      }

      return data;
    }

    public void Export(string target)
    {
      ValidateDataFrame();
      DataFrameProcessor.SaveDataFrame(rDataFrame, target);
    }
  }
}
