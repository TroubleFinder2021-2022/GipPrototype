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
            DbSolution.DisplayAndSearchSolution("SELECT title, category_id FROM subcategory", dataGridViewSubCat);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution("SELECT title, category_id FROM subcategory WHERE title LIKE '%" + txtSearch.Text + "%'", dataGridViewSubCat);
        }

        private void dataGridViewSubCat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.FormattingApplied = true;
                string strTemp = dataGridViewSubCat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (strTemp)
                {
                    case "0":
                        e.Value = "Hardware";
                        break;
                    case "1":
                        e.Value = "Software";
                        break;
                    default:
                        e.Value = "N/A";
                        break;
                }
            }
        }

        private void btnNewSubCat_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }
    }
}
