using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;
    private int _employeeId;
    private int _id;

    public Client (string clientName, int employeeId, int id=0)
    {
      _name = clientName;
      _employeeId = employeeId;
      _id = id;
    }

    public string GetName()
    {
    return _name;
    }
    public int GetId()
    {
      return _id;
    }

    public static List<Client> GetAll()
    {

    }
  }
}
