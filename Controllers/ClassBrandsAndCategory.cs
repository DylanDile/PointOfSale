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
    class ClassBrandsAndCategory
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();
        Parameters param = new Parameters();
        ClassProducts pros = new ClassProducts();
        Stock s;

        public bool AddBrand(string brandName, string desc, int userid)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Brands values(@1,@2,@3,@4)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", brandName);
            cmd.Parameters.AddWithValue("@2", userid);         
            cmd.Parameters.AddWithValue("@3", desc);
            cmd.Parameters.AddWithValue("@4", "Active");
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
        public bool AddCategory(string categoryName, string desc, int userid)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Categories values(@1,@2,@3,@4)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", categoryName);
            cmd.Parameters.AddWithValue("@2", desc);           
            cmd.Parameters.AddWithValue("@3", userid);
            cmd.Parameters.AddWithValue("@4", "Active");
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
