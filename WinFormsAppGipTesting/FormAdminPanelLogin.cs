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
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public FormAdminPanelLogin()
        {
            InitializeComponent();
            con = new MySqlConnection("server=84.198.150.18;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIndex Index = new FormIndex();
            Index.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //AdminAccounts.Login();
            string strUsername = txtUsername.Text;
            string strPassword = txtPassword.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM AdminAccounts WHERE AdminUsername='{strUsername}' AND AdminPassword='{strPassword}'";
            dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                MessageBox.Show($"Login sucess, welcome {strUsername}.");

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
