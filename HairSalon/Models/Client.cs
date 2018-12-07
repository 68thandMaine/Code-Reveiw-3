using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;    private int _id;
        private int _employeeId;

    public Client(string clientName, int employeeId, int id=0)
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
      return 0;
    }

    // public static List<Client> GetAll()
    // {
    //
    // }
  }
}
