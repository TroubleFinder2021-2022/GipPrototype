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
    public partial class FormAdminPanelNewSolution : Form
    {
        private string strCon = "server=84.198.150.18;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";
        MySqlDataReader dr;

        public FormAdminPanelNewSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPanelMain FormAdminPanelMain = new FormAdminPanelMain();
            FormAdminPanelMain.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin FormAdminLogin = new FormAdminPanelLogin();
            FormAdminLogin.Show();
            this.Close();
        }

        private void FormAdminPanelNewSolution_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM category;";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["name"]);
                comboBox3.Items.Add(dr["name"]);
            }
            con.Close();


            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM subcategory;";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["name"]);
                comboBox4.Items.Add(dr["name"]);
            }
            con.Close();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM solutions";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int intValue = Convert.ToInt32(dr["solutions_id"]);
                intValue++;
                textBox3.Text = Convert.ToString(intValue);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ADD NEW SOLUTION
            string strQueryCommand = $"INSERT INTO solutions (problem, solution, category, subcategory) VALUES('{textBox1.Text}', '{textBox2.Text}', '{comboBox1.SelectedItem}', '{comboBox2.SelectedItem}');";

            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand(strQueryCommand, con);
            MySqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show($"New problem {textBox1.Text} has been added to the database.");
            while (dr.Read())
            {
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // EDIT EXISTING SOLUTION
            string strQueryCommand = $"UPDATE solutions  SET problem = '{textBox6.Text}', solution = '{textBox5.Text}', category = '{comboBox3.SelectedItem}', subcategory = '{comboBox4.SelectedItem}' WHERE solutions_id = '{textBox4.Text}';";

            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand(strQueryCommand, con);
            MySqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show($"Problem {textBox6.Text} has been updated in the database.");
            while (dr.Read())
            {
            }
            con.Close();
        }
    }
}
