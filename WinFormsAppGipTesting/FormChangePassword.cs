using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormChangePassword : Form
    {
        private readonly FormAdminPanelMain _parent;
        public string strUsername;

        public FormChangePassword(FormAdminPanelMain parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Clear();
        }

        public void UpdateInfo()
        {
            txtUsername.Text = strUsername;
        }

        public void Clear()
        {
            txtUsername.Text = string.Empty;
            txtOldPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Trim().Length < 3)
            {
                MessageBox.Show("Old password is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNewPassword.Text.Trim().Length < 3)
            {
                MessageBox.Show("New password is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNewPassword.Text == txtOldPassword.Text)
            {
                MessageBox.Show("New password cannot be the same as the old password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                DbSolution.AdminChangePassword(txtUsername.Text, txtOldPassword.Text, txtNewPassword.Text, this);
                Clear();
                Close();
            }
        }
    }
}
