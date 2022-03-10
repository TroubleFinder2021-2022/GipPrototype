using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormCategory: Form
    {
        private readonly FormCategoryManagement _parent;

        public FormCategory(FormCategoryManagement parent)
        {
            InitializeComponent();
            _parent = parent;

            DbSolution.LoadCategories("SELECT * FROM category;", "title", cmbCategory);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Clear()
        {
            txtSubCategory.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSubCategory.Text.Trim().Length < 3)
            {
                MessageBox.Show("Solution is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category selection is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                if (MessageBox.Show($"Are you sure you want to add '{txtSubCategory.Text}' as a new subcategory?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strCategoryID = cmbCategory.SelectedItem.ToString();
                    int intCategoryID = 0;

                    if (strCategoryID == "Hardware")
                    {
                        intCategoryID = 0;
                    }
                    else if (strCategoryID == "Software")
                    {
                        intCategoryID = 1;
                    }

                    Subcategory subcategory = new Subcategory(txtSubCategory.Text.Trim(), intCategoryID);
                    DbSolution.AddSubcategory(subcategory);
                    Clear();
                }
                else
                {
                    return;
                }
                _parent.Display();
            }
        }
    }
}
