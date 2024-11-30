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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace OffreEmploiApp5
{
    public partial class RegisterForm : Form
    {
        // Déclaration de la connexion
        SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=OffreEmplois5;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Bouton de fermeture de l'application
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Redirige vers le formulaire de connexion
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        // Fonction d'inscription de l'utilisateur
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Vérification si les champs sont vides
            if (RegisterName.Text == "" || RegisterEmail.Text == "" || RegisterPassword.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Vérification de la connexion à la base de données
                if (checkConnection())
                {
                    // Utilisation de la connexion dans un bloc using
                    using (SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=OffreEmplois5;Integrated Security=True"))
                    {
                        connect.Open();

                        // Vérification si le nom d'utilisateur est déjà pris
                        string checkUsername = "SELECT * FROM users WHERE Name = @Name";
                        using (SqlCommand checkCommand = new SqlCommand(checkUsername, connect))
                        {
                            checkCommand.Parameters.AddWithValue("@Name", RegisterName.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkCommand);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(RegisterName.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (!IsValidEmail(RegisterEmail.Text))
                            {
                                MessageBox.Show("Invalid email address. Please enter a valid email.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (RegisterPassword.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Insertion des données dans la base de données
                                string insertData = "INSERT INTO users (Name, Email, Password, Role, date) VALUES (@Name, @Email, @Password, @Role, @Date)";
                                using (SqlCommand insertCommand = new SqlCommand(insertData, connect))
                                {
                                    insertCommand.Parameters.AddWithValue("@Name", RegisterName.Text.Trim());
                                    insertCommand.Parameters.AddWithValue("@Email", RegisterEmail.Text.Trim());
                                    insertCommand.Parameters.AddWithValue("@Password", RegisterPassword.Text.Trim());
                                    insertCommand.Parameters.AddWithValue("@Role", comboxRole.SelectedItem?.ToString());
                                    insertCommand.Parameters.AddWithValue("@Date", DateTime.Today);

                                    insertCommand.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Ouvrir le formulaire de connexion
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fonction pour valider l'email
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Vérification de l'état de la connexion à la base de données
        private bool checkConnection()
        {
            // Vérifie l'état de la connexion et retourne true si elle est fermée
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        // Fonction pour afficher/masquer le mot de passe
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        // Fermeture propre de la connexion
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
