using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGipTesting
{
    class DbSolution
    {
        public static MySqlConnection GetConnection()
        {
            string strSql = "server=84.198.150.18;user id=troublefinder_usr;password=7a3Gf3VY;persistsecurityinfo=True;database=troublefinder";
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
    }
}
