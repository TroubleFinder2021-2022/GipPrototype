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
    public partial class FormAdminPanelLogin : Form
    {
        connection con = new connection();
        //string username, password;

        public FormAdminPanelLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormIndex Index = new FormIndex();
            Index.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {

                    con.Open();
                    string query = "select username,password from tbladminaccounts WHERE username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        /*
                        while (row.Read())
                        {
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                        }
                        MessageBox.Show("Data found your name is " + username);
                        */
                        FormAdminPanelMain FormAdminMain = new FormAdminPanelMain();
                        FormAdminMain.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}
