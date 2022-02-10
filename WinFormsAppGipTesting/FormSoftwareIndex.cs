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
    public partial class FormSoftwareIndex : Form
    {
        private string strCon = "server=84.198.150.18;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";
        MySqlDataReader dr;

        public FormSoftwareIndex()
        {
            InitializeComponent();
        }

        private void FormSoftwareIndex_Load_1(object sender, EventArgs e)
        {
            string strQueryCommand = "SELECT problem FROM troublefinder.solutions WHERE category = 'Software';";
            MySqlConnection con = new MySqlConnection(strCon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = con;
            cmd.CommandText = strQueryCommand;
            da.SelectCommand = cmd;
            da.Fill(dt);

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "problem";
            con.Close();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            //string strProblem = listBox1.SelectedItem.ToString();
            textBox1.Text = "Coming soon";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormIndex Index = new FormIndex();
            Index.Show();
            this.Close();
        }
    }
}
