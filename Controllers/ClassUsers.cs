using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Controllers
{
    class ClassUsers
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();       
        public string UserOccupation(string loggedUsername)
        {            
            string occupation;
            con = new SqlConnection(cn.connection);
            string sql = " select occupation from users where username = @1 ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", loggedUsername);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                occupation = dt.Rows[0]["occupation"].ToString();
            }
            else
            {
                occupation = null;
            }

            return occupation;
        }

        public int UserID(string loggedUsername)
        {
            int userid;
            con = new SqlConnection(cn.connection);
            string sql = " select userID from users where username = @1 ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1",loggedUsername);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                userid =Convert.ToInt32( dt.Rows[0]["userID"].ToString());
            }
            else
            {
                userid = 0;
            }

            return userid;
        }

        public DataTable UserData(string loggedUsername)
        {           
            con = new SqlConnection(cn.connection);
            string sql = " select * from users where username = @1 ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1",  loggedUsername);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
