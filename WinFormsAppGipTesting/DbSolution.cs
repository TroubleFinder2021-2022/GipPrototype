using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ilias was hier
namespace WinFormsAppGipTesting
{
    class DbSolution
    {
        public static MySqlConnection GetConnection()
        {
            string strSql = "server=mysql.sintcordula.be; user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";
            MySqlConnection con = new MySqlConnection(strSql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection failed! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddSolution(Solution sol)
        {
            string strSql = "INSERT INTO solutions VALUES (NULL, @SolProblem, @SolSolution, @SolCategory, @SolSubCategory)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SolProblem", MySqlDbType.VarChar).Value = sol.problem;
            cmd.Parameters.Add("@SolSolution", MySqlDbType.VarChar).Value = sol.solution;
            cmd.Parameters.Add("@SolCategory", MySqlDbType.VarChar).Value = sol.category;
            cmd.Parameters.Add("@SolSubCategory", MySqlDbType.VarChar).Value = sol.subcategory;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Solution added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Solution could not be added. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateSolution(Solution sol, string strId)
        {
            string strSql = "UPDATE solutions SET problem = @SolProblem, solution = @SolSolution, category = @SolCategory, subcategory = @SolSubCategory WHERE solutions_id = @SolID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SolID", MySqlDbType.VarChar).Value = strId;
            cmd.Parameters.Add("@SolProblem", MySqlDbType.VarChar).Value = sol.problem;
            cmd.Parameters.Add("@SolSolution", MySqlDbType.VarChar).Value = sol.solution;
            cmd.Parameters.Add("@SolCategory", MySqlDbType.VarChar).Value = sol.category;
            cmd.Parameters.Add("@SolSubCategory", MySqlDbType.VarChar).Value = sol.subcategory;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Solution could not be updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteSolution(string strId)
        {
            string strSql = "DELETE FROM solutions WHERE solutions_id = @SolID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SolID", MySqlDbType.VarChar).Value = strId;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Solution could not be deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearchSolution(string strQuery, DataGridView dgv)
        {
            string strSql = strQuery;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void LoadCategories(string strQuery, string strColumn, ComboBox cmb)
        {
            string strSql = strQuery;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr[strColumn]);
            }
            con.Close();
        }

        public static void LoadSolutions(string strQuery, TextBox txtbox)
        {
            string strSql = strQuery;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataReader dr;
            cmd.Connection = con;
            cmd.CommandText = strQuery;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtbox.Text = (dr["solution"]).ToString();
            }
            con.Close();
        }

        public static void LoadProblems(string strQuery, ListBox listbox)
        {
            string strSql = strQuery;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.Connection = con;
            cmd.CommandText = strQuery;
            da.SelectCommand = cmd;
            da.Fill(dt);

            listbox.DataSource = dt;
            listbox.DisplayMember = "problem";
            con.Close();
        }

        public static void AdminLogin(string strQuery, string strUsername, string strPassword, FormAdminPanelLogin form)
        {
            string strSql = strQuery;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataReader dr;
            cmd.Connection = con;
            cmd.CommandText = strQuery;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show($"Login success, welcome {strUsername}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FormAdminPanelMain FormAdminMain = new FormAdminPanelMain();
                FormAdminMain.Show();
                form.Close();
            }
            else
            {
                MessageBox.Show($"Invalid Login please check username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();
        }

        public static void AdminChangePassword(string strUsername, string strOldPassword, string strNewPassword, FormChangePassword form)
        {
            string strSql = $"SELECT * FROM AdminAccounts WHERE AdminPassword = '{strOldPassword}' AND AdminUsername = '{strUsername}';";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(strSql, con);
            MySqlDataReader dr;
            cmd.Connection = con;
            cmd.CommandText = strSql;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string strSql2 = $"UPDATE AdminAccounts SET AdminPassword = '{strNewPassword}' WHERE AdminUsername = '{strUsername}';";
                MySqlConnection con2 = GetConnection();
                MySqlCommand cmd2 = new MySqlCommand(strSql2, con2);
                cmd2.Connection = con2;
                cmd2.CommandText = strSql2;
                cmd2.ExecuteReader();

                MessageBox.Show($"Password for {strUsername} has successfully been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con2.Close();
            }
            else
            {
                MessageBox.Show($"Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            form.Clear();
            con.Close();
        }
    }
}
