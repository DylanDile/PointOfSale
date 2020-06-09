using PointOfSale.Controllers;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class ClassInserts
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();
        UserModel userModel = new UserModel();
        ClassUsers cUsers = new ClassUsers();
        public bool AddUser(string ecnum, string name, string surname, string username,string occupation, string password)
        {
            bool res;
            string encPass = enc.Encrypt(password, username);
            con = new SqlConnection(cn.connection);
            con.Open();
            string sql = "insert into users values(@ecnum, @1, @2, @3, @4, @5, @6)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ecnum", ecnum);
            cmd.Parameters.AddWithValue("@1", name);
            cmd.Parameters.AddWithValue("@2", surname);
            cmd.Parameters.AddWithValue("@3", username);
            cmd.Parameters.AddWithValue("@4", occupation);
            cmd.Parameters.AddWithValue("@5", encPass);
            cmd.Parameters.AddWithValue("@6", "inactive");
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

        public bool AddSellingPrice(int proID, decimal price)
        {
            bool res;
            DateTime prDate = DateTime.Now.Date;
            int userID = 1;// cUsers.UserID();
            con = new SqlConnection(cn.connection);
            con.Open();
            string sql = "insert into SellingPrices values( @1, @2, @3, @4, @5)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", proID);
            cmd.Parameters.AddWithValue("@2", price);
            cmd.Parameters.AddWithValue("@3", prDate);
            cmd.Parameters.AddWithValue("@4", userID );
            cmd.Parameters.AddWithValue("@5", "Active");
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
