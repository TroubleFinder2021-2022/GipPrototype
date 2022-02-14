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
        public FormSolutionManagement()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbSolution.DisplayAndSearchSolution("SELECT * FROM solutions", dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormSolution form = new FormSolution(this);
            form.ShowDialog();
        }

        private void FormSolutionManagement_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
