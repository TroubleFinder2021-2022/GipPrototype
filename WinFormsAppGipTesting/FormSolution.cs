using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormSolution : Form
    {
        private readonly FormSolutionManagement _parent;

        public FormSolution(FormSolutionManagement parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            txtProblem.Text = string.Empty;
            txtSolution.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
            cmbSubcategory.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProblem.Text.Trim().Length < 5)
            {
                MessageBox.Show("Problem title is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSolution.Text.Trim().Length < 5)
            {
                MessageBox.Show("Solution is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category selection is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbSubcategory.SelectedIndex == -1)
            {
                MessageBox.Show("Subcategory selection is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btnSave.Text == "Save")
            {
                Solution sol = new Solution(txtProblem.Text.Trim(), txtSolution.Text.Trim(), cmbCategory.SelectedItem.ToString(), cmbSubcategory.SelectedItem.ToString());
                DbSolution.AddSolution(sol);
                Clear();
            }
            _parent.Display();
        }
    }
}
