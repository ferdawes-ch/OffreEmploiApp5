using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OffreEmploiApp5
{
    public partial class AdminContact : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=OffreEmplois5;Integrated Security=True");

        public AdminContact()
        {
            InitializeComponent();
            displayAllUserData();
        }

        public void displayAllUserData()
        {
            ContactData cData = new ContactData();

            List<ContactData> listData = cData.AllUsersData();

            dataGridView2.DataSource = listData; // Directly display the list in the DataGridView
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // Check that the clicked row is valid
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Simple test: Print the data to the console for verification
                Console.WriteLine("ID: " + row.Cells["id"].Value.ToString());
                Console.WriteLine("Name: " + row.Cells["Name"].Value.ToString());
                Console.WriteLine("Email: " + row.Cells["Email"].Value.ToString());
                Console.WriteLine("Telephone: " + row.Cells["Telephone"].Value.ToString());
                Console.WriteLine("Subject: " + row.Cells["Subject"].Value.ToString());
                Console.WriteLine("Message: " + row.Cells["Message"].Value.ToString());
            }
        }

        private void AdminDeleteContactbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0) // Check if a row is selected
            {
                int selectedId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id"].Value);

                if (MessageBox.Show($"Are you sure you want to delete the user with ID: {selectedId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            string deleteData = "DELETE FROM contact WHERE id = @id";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteData, connect))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", selectedId);
                                deleteCmd.ExecuteNonQuery();
                                MessageBox.Show("User successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            displayAllUserData(); // Reload the data
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (connect.State == System.Data.ConnectionState.Open)
                            {
                                connect.Close(); // Ensure the connection is closed
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkConnection()
        {
            try
            {
                if (connect.State == System.Data.ConnectionState.Closed)
                {
                    connect.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void AdminAfficheContactbtn_Click(object sender, EventArgs e)
        {
           

        }
    }
}
