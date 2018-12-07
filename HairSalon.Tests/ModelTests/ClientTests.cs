using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.TestTools
{
  [TestClass]
  public class ClientTest
  // : IDisposable
  {
    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;userid=root;password=root;port=8889;database=chris_rudnicky_test;";
    }
    // public void Dispose()
    // {
    //   Stylist.ClearAll();
    //   Client.ClearAll();
    // }
    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient= new Client("chris", 1, 1);
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }
  }
}
