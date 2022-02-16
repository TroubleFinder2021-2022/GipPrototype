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
        public FormAdminPanelLogin()
        {
            InitializeComponent();
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = txtUsername.Text;
            string strPassword = txtPassword.Text;
            DbSolution.AdminLogin($"SELECT * FROM AdminAccounts WHERE AdminUsername='{strUsername}' AND AdminPassword='{strPassword}'", strUsername, strPassword, this);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FormIndex Index = new FormIndex();
            Index.Show();
            this.Close();
        }
    }
}
