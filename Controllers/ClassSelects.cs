using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class ClassSelects
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();
        public bool login(string username, string password)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "select top 1 * from users where username = @1 and userStatus = @st ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", username);
            cmd.Parameters.AddWithValue("@st", "active");
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                string pass = row["password"].ToString();
                if (password == enc.Decrypt(pass, username))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

            }
            else
            {
                res = false;
            }

            return res;
        }

        public DataRow proSearch(string sql)
        {
            DataRow row;
            con = new SqlConnection(cn.connection);
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
            }
            else
            {
                row = null;
            }
            
            return row;
        }

        public decimal priceSearch(int productID)
        {
            decimal proID;
            con = new SqlConnection(cn.connection);
            string sql = "select * from SellingPrices where ProID = @id ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", productID);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                proID = Convert.ToDecimal(dt.Rows[0]["PriceNew"].ToString());

            }
            else
            {
                proID = 0.00m;
            }

            return proID;
        }

       
    }
}
