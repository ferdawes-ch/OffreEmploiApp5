using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace OffreEmploiApp5
{
    public partial class AdminAddUserss : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=OffreEmplois5;Integrated Security=True");

        public AdminAddUserss()
        {
            InitializeComponent();

            displayAllUserData();
        }

        public void displayAllUserData()
        {
            UsersData uData = new UsersData();

            List<UsersData> listData = uData.AllUsersData();

            dataGridView1.DataSource = listData;
        }


        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (AdminAddNametxt.Text == "" || AdminAddEmailtxt.Text == "" || AdminAddPasstxt.Text == "" || comboBoxAdminAddList.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkName = "SELECT * FROM users WHERE Name = @Name";
                        using (SqlCommand cmd = new SqlCommand(checkName, connect))
                        {
                            cmd.Parameters.AddWithValue("@Name", AdminAddNametxt.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {

                                MessageBox.Show(AdminAddNametxt.Text.Trim() + "is already taken!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else
                            {
                                string insertData = "INSERT INTO users (Name, Email, Password, Role, date)" + "VALUES(@Name,@Email,@Password,@Role,@date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@Name", AdminAddNametxt.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Email", AdminAddEmailtxt.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Password", AdminAddPasstxt.Text.Trim());
                                    insertD.Parameters.AddWithValue("@Role", comboBoxAdminAddList.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllUserData();
                                    MessageBox.Show("Added successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connextion failed : " + ex, " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    finally
                    {
                        connect.Close();
                    }


                }

            }

        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AdminUpdatebtn_Click(object sender, EventArgs e)
        {
            if (AdminAddNametxt.Text == "" || AdminAddEmailtxt.Text == "" || AdminAddPasstxt.Text == "" || comboBoxAdminAddList.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 


            }
            else
            {
                if (MessageBox.Show(" Sure! you want to update User ID: " + getid + " ?? ", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            
                                    string updateData = " UPDATE users SET Name= @Name, " + "Email = @Email, Password=@Password,Role=@Role WHERE id=@id";

                                    using (SqlCommand updateD = new SqlCommand(updateData, connect))
                                    {
                                        updateD.Parameters.AddWithValue("@Name", AdminAddNametxt.Text.Trim());
                                        updateD.Parameters.AddWithValue("@Email", AdminAddEmailtxt.Text.Trim());
                                        updateD.Parameters.AddWithValue("@Password", AdminAddPasstxt.Text.Trim());
                                        updateD.Parameters.AddWithValue("@Role", comboBoxAdminAddList.SelectedItem);
                                        updateD.Parameters.AddWithValue("@id", getid);

                                        updateD.ExecuteNonQuery();
                                        clearFields();
                                displayAllUserData();




                                MessageBox.Show("update successfully", " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }

                                


                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connextion failed : " + ex, " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        finally
                        {
                            connect.Close();
                        }


                    }

                }
               

            }


        }

        private void clearFields()
        {
            AdminAddNametxt.Text = string.Empty;
            AdminAddEmailtxt.Text = string.Empty;
            AdminAddPasstxt.Text = string.Empty;
            comboBoxAdminAddList.SelectedIndex = -1;
            getid = 0;
        }

        private int getid = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                
                getid = Convert.ToInt32(row.Cells[0].Value); 

                
                string Name = row.Cells[1].Value.ToString();
                string Email = row.Cells[2].Value.ToString();
                string Password = row.Cells[3].Value.ToString();
                string Role = row.Cells[4].Value.ToString();

                AdminAddNametxt.Text = Name;
                AdminAddEmailtxt.Text = Email;
                AdminAddPasstxt.Text = Password;
                comboBoxAdminAddList.Text = Role;
            }
        }

        private void AdminDeletebtn_Click(object sender, EventArgs e)
        {
           
            if (AdminAddNametxt.Text == "" || AdminAddEmailtxt.Text == "" || AdminAddPasstxt.Text == "" || comboBoxAdminAddList.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            } 
            else
            {
                if (MessageBox.Show(" Sure! you want to Delete User ID: " + getid + " ?? ", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection()) 
                    {
                        try
                        {
                            connect.Open();


                            string deleteData = "  DELETE FROM users WHERE id = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                               
                                deleteD.Parameters.AddWithValue("@id", getid);

                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayAllUserData();




                                MessageBox.Show("deleted successfully", " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }






                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connextion failed : " + ex, " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        finally
                        {
                            connect.Close();
                        }


                    }

                }


            }
        }
    }
}
