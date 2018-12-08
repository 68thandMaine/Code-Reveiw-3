using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {
    public void Dispose()
    {
      // Stylist.ClearAll();
      // Client.ClearAll();
    }
    public StylistTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;userid=root;password=root;port=8889;database=chris_rudnicky_test;";
    }

    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new Stylist ("hannah");
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Stylist newStylist = new Stylist ("Hannah");
      string result ="Hannah";
      Assert.AreEqual(newStylist.GetName(),result );
    }
  }
}
