using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RChestration.Telemetry;
using System.IO;

namespace UnitTests
{
  class ClientData
  {
    public int clients { get; set; }
    public int income { get; set; }
    public double capital { get; set; }
    bool sensitive { get; set; }
  }

  [TestClass]
  public class Rchestrator
  {
    [TestMethod]
    public void BaseTest()
    {
      Rchestrator<ClientData> rch = new Rchestrator<ClientData>();
    }
    
    [TestMethod]
    public void HeaderTest()
    {
      Rchestrator<ClientData> rch = new Rchestrator<ClientData>();
      Assert.AreEqual(rch.Size, 0);
      Assert.AreEqual(rch.Columns, 3);

      Assert.IsTrue(rch.Headers.Contains("clients"));
      Assert.IsTrue(rch.Headers.Contains("income"));
      Assert.IsTrue(rch.Headers.Contains("capital"));
      Assert.IsFalse(rch.Headers.Contains("sensitive"));
    }

    [TestMethod]
    public void LoggingTest()
    {
      Rchestrator<ClientData> rch = new Rchestrator<ClientData>();

      ClientData data = new ClientData();
      
      data.capital = 0;
      data.clients = 1;
      data.income = 10;
      rch.Log(data);
      Assert.AreEqual(rch.Size, 1);

      data.capital = 10;
      rch.Log(data);
      Assert.AreEqual(rch.Size, 2);

      ClientData dataPoint = rch.DataPoint(0);
      Assert.AreEqual(dataPoint.capital, 0);
      Assert.AreEqual(dataPoint.clients, 1);
      Assert.AreEqual(dataPoint.income, 10);

      dataPoint = rch.DataPoint(1);
      Assert.AreEqual(dataPoint.capital, 10);
      Assert.AreEqual(dataPoint.clients, 1);
      Assert.AreEqual(dataPoint.income, 10);
    }

    [TestMethod]
    public void LoadingTest()
    {
      Rchestrator<ClientData> rch = new Rchestrator<ClientData>("TestData\\ClientData1.csv");
      Assert.AreEqual(rch.Size, 3);

      ClientData dataPoint = rch.DataPoint(0);
      Assert.AreEqual(dataPoint.capital, 100.0);
      Assert.AreEqual(dataPoint.clients, 1);
      Assert.AreEqual(dataPoint.income, 150);

      dataPoint = rch.DataPoint(1);
      Assert.AreEqual(dataPoint.capital, 110.0);
      Assert.AreEqual(dataPoint.clients, 2);
      Assert.AreEqual(dataPoint.income, 300);

      dataPoint = rch.DataPoint(2);
      Assert.AreEqual(dataPoint.capital, 124.2);
      Assert.AreEqual(dataPoint.clients, 3);
      Assert.AreEqual(dataPoint.income, 420);
    }

    [TestMethod]
    public void SaveTest()
    {
      Rchestrator<ClientData> rch = new Rchestrator<ClientData>("TestData\\ClientData1.csv");
      Assert.AreEqual(rch.Size, 3);

      string path = Path.GetTempFileName();
      rch.Export(path);

      String[] linesA = File.ReadAllLines("TestData\\ClientData1.csv");
      String[] linesB = File.ReadAllLines(path);

      Assert.AreEqual(linesA.Length, linesB.Length);
      for(int i = 0; i < linesA.Length; i++)
      {
        Assert.AreEqual(linesA[i], linesB[i]);
      }
    }
  }
}
