using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormAdminPanelNewSolution : Form
    {
        public FormAdminPanelNewSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPanelMain FormAdminPanelMain = new FormAdminPanelMain();
            FormAdminPanelMain.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin FormAdminLogin = new FormAdminPanelLogin();
            FormAdminLogin.Show();
            this.Close();
        }
    }
}
