using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormSolutionManagement : Form
    {
        FormSolution form;

        public FormSolutionManagement()
        {
            InitializeComponent();
            form = new FormSolution(this);
        }

        public void Display()
        {
            DbSolution.DisplayAndSearchSolution($"SELECT * FROM solutions", dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormSolutionManagement_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution("SELECT * FROM solutions WHERE problem LIKE '%" + txtSearch.Text +"%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.strId = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.strProblem = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.strSolution = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.strCategory = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.strSubcategory = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Delete
                if (MessageBox.Show("Are you sure you want to remove this problem?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DbSolution.DeleteSolution(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdminPanelMain formAdminPanelMain = new FormAdminPanelMain();
            formAdminPanelMain.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
