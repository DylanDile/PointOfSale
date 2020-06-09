using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Company
{
    class ClassCompany
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();


        public bool addBranchInfo(string branchName, string address, string brCode)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into CompanyBranch values(@1, @2, @3, @4)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", branchName);
            cmd.Parameters.AddWithValue("@2", address);
            cmd.Parameters.AddWithValue("@3", brCode);
            cmd.Parameters.AddWithValue("@4", "inactive");
            if (cmd.ExecuteNonQuery() == 1)
            {
                res = true;
            }

            else
            {
                res = false;
            }
            con.Close();
            return res;
        }

        public bool addCompanyInfo(string companyNarme, string email, string phone, string address, byte[] logo)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "INSERT INTO [CompanyConfig]" +
                        " ([ccName],[ccEmail],[ccPhone],[ccAddress] ,[ccLogo])" +
                        " VALUES(@1, @2, @3, @4 ,@5)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", companyNarme);
            cmd.Parameters.AddWithValue("@2", email);
            cmd.Parameters.AddWithValue("@3", phone);
            cmd.Parameters.AddWithValue("@4", address);
            cmd.Parameters.AddWithValue("@5", logo);
            if (cmd.ExecuteNonQuery() == 1)
            {
                res = true;
            }

            else
            {
                res = false;
            }
            con.Close();
            return res;
        }
        public DataRow getCompanyInfo()
        {
            DataRow row;
            con = new SqlConnection(cn.connection);
            string sql = "select * from CompanyConfig";
            con.Open();
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
            }
            else
            {
                row = null;
            }
            con.Close();
            return row;
        }

        public DataTable getBranchInfo()
        {
            con = new SqlConnection(cn.connection);
            string sql = "select * from CompanyBranch where brStatus = 'working' ";
            con.Open();
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable DataForGrid(string sql)
        {
            con = new SqlConnection(cn.connection);
            con.Open();
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
