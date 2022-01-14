using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormAdminPanelLogin : Form
    {
        public FormAdminPanelLogin()
        {
            InitializeComponent();

            /*
            AdminAccounts Account1 = new AdminAccounts();
            Account1.strUsername = "ilias";
            Account1.strPassword = "snor123";

            AdminAccounts Account2 = new AdminAccounts();
            Account2.strUsername = "loïc";
            Account2.strPassword = "snor123";
            */

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
            dbConnection.DbConnection();

            FormAdminPanelMain FormAdminMain = new FormAdminPanelMain();
            FormAdminMain.Show();
            this.Close();
        }
    }
}
