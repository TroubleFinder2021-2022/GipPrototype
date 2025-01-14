﻿using System;
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

            timerClock.Enabled = true;
            timerClock.Interval = 1000;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            formHardwareIndex.Clear();
            formHardwareIndex.HardwareInfo();
            formHardwareIndex.ShowDialog();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            formHardwareIndex.Clear();
            formHardwareIndex.SoftwareInfo();
            formHardwareIndex.ShowDialog();
        }

        private void btnAdminPanel_Click_1(object sender, EventArgs e)
        {
            FormAdminPanelLogin AdminLogin = new FormAdminPanelLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit TroubleFinder™ ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnSecret_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No secrets are currently available.", ";)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSecret_MouseHover(object sender, EventArgs e)
        {
            btnSecret.BackColor = Color.White;
            btnSecret.Text = "Secret Button";
        }

        
    }
}



