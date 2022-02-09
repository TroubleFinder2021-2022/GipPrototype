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
        public FormAdminPanelMain()
        {   
            InitializeComponent();
            con.ConnectionString = "server=84.198.150.18;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";
        }

        //initialising sql classes
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPanelLogin FormAdminLogin = new FormAdminPanelLogin();
            FormAdminLogin.Show();
            this.Close();
        }

        private void FormAdminPanelMain_Load(object sender, EventArgs e)
        {
            //DISPLAYS ADMIN ACCOUNTS
            string strQuery = "SELECT * FROM AdminAccounts"; ;

            con.Open();
            cmd = new MySqlCommand();
            //hold the data to be executed.
            cmd.Connection = con;
            cmd.CommandText = strQuery;
            //initialize new Sql data adapter
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            //initialize new datatable
            dt = new DataTable();
            //refreshes the rows in specified range in the datasource. 
            da.Fill(dt);

            dataGridViewAdminAccounts.DataSource = dt;

            da.Dispose();
            con.Close();

            //DISPLAYS ALL SOLUTIONS
            string strQuery2 = "SELECT * FROM solutions;"; ;

            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = strQuery2;
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);

            dataGridViewSolutions.DataSource = dt;

            da.Dispose();
            con.Close();
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
    }
}
