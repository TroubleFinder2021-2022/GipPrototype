using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WinFormsAppGipTesting
{
    public partial class FormAdminPanelMain : Form
    {
        public FormAdminPanelMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin FormAdminLogin = new FormAdminPanelLogin();
            FormAdminLogin.Show();
            this.Close();
        }

        private void FormAdminPanelMain_Load(object sender, EventArgs e)
        {
            dataGridViewAdminAccounts.DataSource = GetAdminAccounts();
        }

        private DataTable GetAdminAccounts()
        {
            DataTable dtAdminAcounts = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbladminaccounts", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtAdminAcounts.Load(reader);
                }
            }

            return dtAdminAcounts;
        }
    }
}
