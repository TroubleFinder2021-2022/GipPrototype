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
        FormProblem formHardwareIndex;
        public FormIndex()
        {
            InitializeComponent();
            formHardwareIndex = new FormProblem(this);


        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            formHardwareIndex.Clear();
            formHardwareIndex.HardwareInfo();
            formHardwareIndex.ShowDialog();
            /*
            FormHardwareIndex HardwareIndex = new FormHardwareIndex();
            HardwareIndex.Show();
            this.Hide();
            */
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            formHardwareIndex.Clear();
            formHardwareIndex.SoftwareInfo();
            formHardwareIndex.ShowDialog();
            /*
            FormSoftwareIndex SoftwareIndex = new FormSoftwareIndex();
            SoftwareIndex.Show();
            this.Hide();
            */
        }

        private void btnAdminPanel_Click_1(object sender, EventArgs e)
        {
            FormAdminPanelLogin AdminLogin = new FormAdminPanelLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void btnSecret_Click(object sender, EventArgs e)
        {

        }

    }
}


