using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Controllers
{
    class ClassLoadData
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();

        public DataTable LoadCombo(string sql)
        {            
            con = new SqlConnection(cn.connection);
            cmd = new SqlCommand(sql, con);            
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable LoadGridView(string sql)
        {
            con = new SqlConnection(cn.connection);
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LoadDataTable(string sql)
        {
            con = new SqlConnection(cn.connection);
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }
    }
}
