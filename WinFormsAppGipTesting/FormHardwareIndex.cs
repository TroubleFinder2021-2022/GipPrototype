using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    public partial class FormHardwareIndex : Form
    {
        public FormHardwareIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIndex Index = new FormIndex();
            Index.Show();
            this.Close();
        }

        private void FormHardwareIndex_Load(object sender, EventArgs e)
        {
            //listbox1 gets filled with data from db
        }
    }
}
