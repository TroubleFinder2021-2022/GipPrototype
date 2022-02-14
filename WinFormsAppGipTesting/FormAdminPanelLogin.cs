using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAppGipTesting
{
    public partial class FormAdminPanelLogin : Form
    {
        private string strCon = "server=mysql.sintcordula.be;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";

        public FormAdminPanelLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIndex Index = new FormIndex();
            Index.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = txtUsername.Text;
            string strPassword = txtPassword.Text;
            string strQueryCommand = $"SELECT * FROM AdminAccounts WHERE AdminUsername='{strUsername}' AND AdminPassword='{strPassword}'";

            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(strQueryCommand, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show($"Login success, welcome {strUsername}.");

                FormAdminPanelMain FormAdminMain = new FormAdminPanelMain();
                FormAdminMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Invalid Login please check username and password");
            }
            con.Close();
        }
    }
}
