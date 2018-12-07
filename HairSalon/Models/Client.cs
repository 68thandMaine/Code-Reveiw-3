using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;
    private int _stylistId;
    private int _id;

    public Client (string clientName, int employeeId, int id=0)
    {
      _name = clientName;
      _stylistId = employeeId;
      _id = id;
    }

    public string GetName()
    {
    return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetId()
    {
      return _id;
    }

    public override bool Equals(System.Object otherClient)
    {
      if(!(otherClient is Client))
      {
        return false;
      }
      else
      {
        Client newClient =(Client) otherClient;
        bool idEquality =(this.GetId() == newClient.GetId());
        bool nameEquality = (this.GetName() == newClient.GetName());
        // bool stylistEquality = (this.GetStylistId == newClient.GetStylistId());
        return (idEquality && nameEquality);
      }
    }


    public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText=@"SELECT * FROM clients;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int clientId = rdr.GetInt32(0);
        string clientName = rdr.GetString(1);
        int clientStylistId = rdr.GetInt32(2);
        Client newClient = new Client(clientName, clientStylistId, clientId);
        allClients.Add(newClient);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allClients;
    }
    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText=@"INSERT INTO clients (clientName, stylistId, id) VALUES (@ClientName, @stylistId, @id);";
      MySqlParameter name = new MySqlParameter();
      name.ParameterName = "@clientName";
      name.Value = this._name;
      cmd.Parameters.Add(name);
      MySqlParameter id = new MySqlParameter();
      id.ParameterName = "@id";
      id.Value = this._id;
      cmd.Parameters.Add(id);
      MySqlParameter stylistId = new MySqlParameter();
      stylistId.ParameterName = "@stylistId";
      stylistId.Value = this._stylistId;
      cmd.Parameters.Add(stylistId);
      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId;
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
    }


  }
}
