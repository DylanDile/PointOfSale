using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class ClassSearch
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();

        public bool searchUser(string username)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "select name from users where username = @username ";            
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@username", username);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public DataTable SearchValue(string sql)
        {
            con = new SqlConnection(cn.connection);           
            cmd = new SqlCommand(sql, con);            
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
