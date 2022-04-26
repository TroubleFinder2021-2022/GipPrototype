using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            btnStart.Visible = false;

            this.Cursor = Cursors.AppStarting;

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
            progressBar1.Step = 1;

            for (int i = 0; i < 500; i++)
            {
                progressBar1.PerformStep();
            }
            
            FormIndex formIndex = new FormIndex();
            formIndex.Show();
            this.Hide();
        }
    }
}
