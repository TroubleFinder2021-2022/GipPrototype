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

        private void FormHardwareIndex_Load(object sender, EventArgs e)
        {
            DbSolution.LoadProblems($"SELECT problem FROM troublefinder.solutions WHERE category = '{strCategory}';", lstProblems);
        }

        private void btnGetSolution_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)lstProblems.SelectedItem;
            string strProblem = drv["problem"].ToString();

            DbSolution.LoadSolutions($"SELECT * FROM solutions WHERE problem = '{strProblem}';", txtSolution);
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
            strCategory = "";
        }
    }
}
