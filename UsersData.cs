using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace OffreEmploiApp5
{
    internal class UsersData
    {
        public int id { set; get; }

        public string Name { set; get; }

        public string Email { set; get; }

        public string Password { set; get; }

        public string Role { set; get; }

        public string date { set; get; }
        
        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=OffreEmplois5;Integrated Security=True"))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData uData = new UsersData();
                        uData.id = (int)reader["id"];
                        uData.Name = reader["Name"].ToString();
                        uData.Email = reader["Email"].ToString();
                        uData.Password = reader["Password"].ToString();
                        uData.Role = reader["Role"].ToString();
                        uData.date = reader["date"].ToString();

                        listData.Add(uData);

                    }
                }
            }

            return listData;
                


    }
    }
}
