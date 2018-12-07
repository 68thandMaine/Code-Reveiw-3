using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest  : IDisposable
  {
    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;userid=root;password=root;port=8889;database=chris_rudnicky_test;";
    }
    public void Dispose()
    {
      // Stylist.ClearAll();
      Client.ClearAll();
    }
    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      string name = "chris";
      Client newClient= new Client(name, 1, 1);
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Client newClient = new Client("chris", 1, 2);
      string result = "chris";
      Assert.AreEqual(newClient.GetName(), result);
    }
    [TestMethod]
    public void SetName_SetsName_String()
    {
      string name ="chris";
      Client newClient = new Client (name, 1, 2);

      string updatedName = "shaina";
      newClient.SetName(updatedName);
      string result = newClient.GetName();

      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Client newClient= new Client("chris", 1, 1);
      int result = 1;
      Assert.AreEqual(newClient.GetId(), result);
    }
    [TestMethod]
    public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Item()
    {
      // Arrange, Act
      Client firstClient = new Client("Mow the lawn",1,1);
      Client secondClient = new Client("Mow the lawn",1,1);

      // Assert
      Assert.AreEqual(firstClient, secondClient);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_ClientList()
    {
      List<Client> newList = new List<Client> { };
      List<Client> result = Client.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Saves_SavesToDatabase_ClientList()
    {
      Client newClient = new Client("chris", 1, 1);
      newClient.Save();
      List<Client> result = Client.GetAll();
      List<Client> testList = new List<Client>{newClient};
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsClients_ClientList()
    {
      Client newClient1 = new Client ("chris", 1, 2);
      newClient1.Save();
      Client newClient2 = new Client ("shaina", 2, 3);
      newClient2.Save();
      List<Client> newList = new List<Client> {newClient1, newClient2};

      List<Client> result = Client.GetAll();

      CollectionAssert.AreEqual(newList, result);

    }
  }
}
