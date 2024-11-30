using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffreEmploiApp5
{
    internal class ContactData
    {
        public int id { set; get; }

        public string Name { set; get; }

        public string Email { set; get; }

        public string Telephone { set; get; }

        public string Subject { set; get; }

        public string Message { set; get; }

        public List<ContactData> AllUsersData()
        {
            List<ContactData> listData = new List<ContactData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=OffreEmplois5;Integrated Security=True"))
            {
                connect.Open();

                string selectData = "SELECT * FROM contact";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ContactData uData = new ContactData(); 
                        uData.id = (int)reader["id"]; 
                        uData.Name = reader["Name"].ToString(); 
                        uData.Email = reader["Email"].ToString();
                        uData.Telephone = reader["Telephone"].ToString();
                        uData.Subject = reader["Subject"].ToString();
                        uData.Message = reader["Message"].ToString();

                        listData.Add(uData);

                    }
                }
            }

            return listData;



        }
    
}
}
