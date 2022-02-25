using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAppGipTesting
{
    public partial class FormProblem : Form
    {
        private readonly FormIndex _parent;
        private string strCategory;

        public FormProblem(FormIndex parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void HardwareInfo()
        {
            lblCategoryHeader.Text = "Hardware";
            lblCategoryTitle.Text = "Hardware Problems:";
            strCategory = "Hardware";
        }

        public void SoftwareInfo()
        {
            lblCategoryHeader.Text = "Software";
            lblCategoryTitle.Text = "Software Problems:";
            strCategory = "Software";
        }

        public void Clear()
        {
            lblCategoryHeader.Text = string.Empty;
            lblCategoryHeader.Text = string.Empty;
            txtSolution.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtSearch.Text = string.Empty;
            cmbSubCategory.Text = string.Empty;
            cmbSubCategory.Items.Clear();
            strCategory = "";
        }

        public void Display()
        {
            //UPDATE subcategory SET category_id = 1 WHERE subcategory_id = 9;
            txtCategory.Text = strCategory;
            DbSolution.DisplayAndSearchSolution($"SELECT problem FROM solutions WHERE category = '{strCategory}';", dataGridView);
            if (txtCategory.Text == "Hardware")
            {
                DbSolution.LoadCategories($"SELECT * FROM subcategory WHERE category_id = {0};", "name", cmbSubCategory);
            }
            else if (txtCategory.Text == "Software")
            {
                DbSolution.LoadCategories($"SELECT * FROM subcategory WHERE category_id = {1};", "name", cmbSubCategory);
            }

        }

        private void FormProblem_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution($"SELECT problem FROM solutions WHERE category = '{strCategory}' AND problem LIKE '%" + txtSearch.Text + "%'", dataGridView);
            cmbSubCategory.Text = string.Empty;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strProblem = dataGridView.CurrentCell.Value.ToString();
            DbSolution.LoadSolutions($"SELECT * FROM solutions WHERE problem = '{strProblem}';", txtSolution);
        }

        private void cmbSubCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            DbSolution.DisplayAndSearchSolution($"SELECT problem FROM solutions WHERE category = '{strCategory}' AND subcategory = '{cmbSubCategory.SelectedItem}' AND problem LIKE '%" + txtSearch.Text + "%'", dataGridView);
            txtSearch.Text = string.Empty;
        }
    }
}
