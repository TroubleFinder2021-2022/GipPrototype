using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
            
        }
        private void FormIndex_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            FormHardwareIndex HardwareIndex = new FormHardwareIndex();
            HardwareIndex.Show();
            this.Hide();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin AdminLogin = new FormAdminPanelLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            FormSoftwareIndex SoftwareIndex = new FormSoftwareIndex();
            SoftwareIndex.Show();
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            FormSolutionManagement form = new FormSolutionManagement();
            form.Show();
            this.Hide();
        }
    }
}


