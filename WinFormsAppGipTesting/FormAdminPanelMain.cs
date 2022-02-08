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
            //Setting connection string
            con.ConnectionString = "server=mysql.sintcordula.be;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";

            string strQuery;
            try
            {
                con.Open();
                strQuery = "SELECT * FROM AdminAccounts";
                
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;

                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                dt = new DataTable();

                da.Fill(dt);

                dataGridViewAdminAccounts.DataSource = dt;
            }
            catch (Exception ex)
            {
                //catching error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

            
        }
    }
}
