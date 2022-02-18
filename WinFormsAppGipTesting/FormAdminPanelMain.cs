using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WinFormsAppGipTesting
{
    public partial class FormAdminPanelMain : Form
    {
        FormChangePassword form;

        public FormAdminPanelMain()
        {   
            InitializeComponent();
            form = new FormChangePassword(this);
        }

        private void FormAdminPanelMain_Load(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution("SELECT * FROM AdminAccounts", dataGridView);
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormIndex formIndex = new FormIndex();
                formIndex.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnSolutionManager_Click(object sender, EventArgs e)
        {
            FormSolutionManagement formSolutionManagement = new FormSolutionManagement();
            formSolutionManagement.Show();
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.strUsername = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
            }
        }

       
    }
}
