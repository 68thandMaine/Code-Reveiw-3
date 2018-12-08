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
      Stylist.ClearAll();
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
    // [TestMethod]
    // public void SetName_SetsName_String()
    // {
    //   string name ="chris";
    //   Client newClient = new Client (name, 1, 2);
    //
    //   string updatedName = "shaina";
    //   newClient.SetName(updatedName);
    //   string result = newClient.GetName();
    //
    //   Assert.AreEqual(updatedName, result);
    // }
    [TestMethod]
    public void GetId_ReturnsId_int()
    {
      Stylist newStylist = new Stylist("hannah");
      int result = 0;
      Assert.AreEqual(newStylist.GetId(), result);
    }
    [TestMethod]
    public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Stylist()
    {
      Stylist stylist1 = new Stylist ("Jenny");
      Stylist stylist2 = new Stylist("Jenny");
      Assert.AreEqual(stylist1, stylist2);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_StylistList()
    {
      List<Stylist> newList = new List<Stylist> { };
      List<Stylist> result = Stylist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Saves_SavesToDatabase_StylistList()
    {
      Stylist newStylist = new Stylist("chris");
      newStylist.Save();
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist>{newStylist};
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void Save_AssignsIdToObject_Id()
    {
      Stylist newStylist = new Stylist("Hannah");
      newStylist.Save();
      Stylist savedStylist = Stylist.GetAll()[0];
      int result = savedStylist.GetId();
      int testId = newStylist.GetId();
      Assert.AreEqual(testId, result);
    }
    [TestMethod]
    public void GetAll_ReturnsStylist_StylistList()
    {
      Stylist newStylist1 = new Stylist ("Hannah");
      newStylist1.Save();
      Stylist newStylist2 = new Stylist ("Shaina");
      newStylist2.Save();
      List<Stylist> newList = new List<Stylist> {newStylist1, newStylist2};
      List<Stylist> result = Stylist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
