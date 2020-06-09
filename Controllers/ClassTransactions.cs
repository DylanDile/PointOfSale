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
    class ClassTransactions
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dTable;
        DataSet ds;
        Connection cn = new Connection();

        public bool NewTransaction(Transaction t)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Transactions values(@1, @2, @3, @4, @5)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1",t.UserID);
            cmd.Parameters.AddWithValue("@2", t.Description);
            cmd.Parameters.AddWithValue("@3", t.TransQuery);
            cmd.Parameters.AddWithValue("@4", t.Retry);
            cmd.Parameters.AddWithValue("@5", t.TransStatus);
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

    }
}
