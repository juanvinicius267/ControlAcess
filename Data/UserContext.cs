using Br.Sa.Scania.KD.ControlAccess.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Br.Sa.Scania.KD.ControlAccess.Data
{
    public class UserContext 
    {
        public string ConnectionString { get; set; }

        public UserContext(string _connectionString)
        {
            this.ConnectionString = _connectionString;
        }
        private MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public List<User> GetAllAlbums()
        {
            List<User> list = new List<User>();

            using (MySqlConnection conn = GetMySqlConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from User where UserId < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),                           
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Name = reader["Name"].ToString(),
                            TypeOfAccess = reader["TypeOfAccess"].ToString(),
                            EncryptedKey = reader["EncryptedKey"].ToString()
                        });
                    }
                }
            }
            return list;
        }






    }
}
