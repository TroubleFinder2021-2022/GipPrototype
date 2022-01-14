using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

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
            //dataGridViewAdminAccounts.DataSource = data
        }
    }
}
