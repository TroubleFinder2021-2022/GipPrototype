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
    public partial class FormHardwareIndex : Form
    {
        private string strCon = "server=mysql.sintcordula.be;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";
        MySqlDataReader dr;

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
            string strQueryCommand = "SELECT problem FROM troublefinder.solutions WHERE category = 'Hardware';";
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
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            string strProblem = drv["problem"].ToString();

            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM solutions WHERE problem = '{strProblem}';";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                textBox1.Text = (dr["solution"]).ToString();
            }
            con.Close();
        }
    }
}
