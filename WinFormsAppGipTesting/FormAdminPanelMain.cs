using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WinFormsAppGipTesting
{
    public partial class FormAdminPanelMain : Form
    {
        private string strCon = "server=84.198.150.18;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";

        public FormAdminPanelMain()
        {   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin FormAdminLogin = new FormAdminPanelLogin();
            FormAdminLogin.Show();
            this.Close();
        }

        private void FormAdminPanelMain_Load(object sender, EventArgs e)
        {
            //DISPLAYS ADMIN ACCOUNTS
            
            string strQueryCommand = "SELECT * FROM AdminAccounts";
            
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand(strQueryCommand, con);

            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAdminAccounts.DataSource = dt;
            con.Close();


            
            //DISPLAYS ALL SOLUTIONS
            string strQueryCommand2 = "SELECT * FROM solutions";

            MySqlConnection con2 = new MySqlConnection(strCon);
            MySqlCommand cmd2 = new MySqlCommand(strQueryCommand2, con2);

            con2.Open();
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridViewSolutions.DataSource = dt2;
            con2.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminPanelNewSolution FormAdminPanelNewSolution = new FormAdminPanelNewSolution();
            FormAdminPanelNewSolution.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin FormAdminLogin = new FormAdminPanelLogin();
            FormAdminLogin.Show();
            this.Close();
        }

        private void dataGridViewAdminAccounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
