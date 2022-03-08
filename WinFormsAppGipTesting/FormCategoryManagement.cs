using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormCategoryManagement : Form
    {
        FormCategory form;

        public FormCategoryManagement()
        {
            InitializeComponent();
            form = new FormCategory(this);
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

        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution("SELECT * FROM category", dataGridViewCat);
            DbSolution.DisplayAndSearchSolution("SELECT * FROM subcategory", dataGridViewSubCat);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution("SELECT * FROM subcategory WHERE name LIKE '%" + txtSearch.Text + "%'", dataGridViewSubCat);
        }

        private void dataGridViewSubCat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // change category id into category name
        }

        private void btnNewSubCat_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }
    }
}
