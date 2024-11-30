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

namespace OffreEmploiApp5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            
        }




        private void btnXit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you wante to colse?", "confirmation message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 LoginForm = new Form1();
                LoginForm.Show();

                this.Hide();
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you wante to colse?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 LoginForm = new Form1();
                LoginForm.Show();

                this.Hide();
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
