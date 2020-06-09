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
    class ClassStock
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
        
        public bool AddStock(Stock s)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Stock values(@1,@2,@3,@4)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1",s.ProID);
            cmd.Parameters.AddWithValue("@2", s.Barcode);
            cmd.Parameters.AddWithValue("@3", s.Quantity);
            cmd.Parameters.AddWithValue("@4", "InActive");
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

        public bool UpdateStock(int quanity,string status,  int proid , string barcode)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "update Stock set Quantity = Quantity + @1, StockStatus = @2 where Barcode = @3 and ProID  = @4";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1",quanity);
            cmd.Parameters.AddWithValue("@2", status);
            cmd.Parameters.AddWithValue("@3", barcode);
            cmd.Parameters.AddWithValue("@4", proid);
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

        public bool AddByBarcode(string barcode)
        {
            bool res;
            dt = new DataTable();
            dt = pros.SearchByBarcode(barcode);
            if(dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                int proid = Convert.ToInt32(row["ProID"].ToString());
                s = new Stock();
                s.ProID = proid;
                s.Barcode = barcode;
                s.Quantity = 0;
                s.StockStatus = "Out of Stock";
               res =  AddStock(s);
            }
            else
            {
                res = false;
            }

            return res;
        }

        public DataTable SearchByCategory(string categoryName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],s.[Quantity], s.[StockStatus] " +
                " FROM Products p , Stock s WHERE p.ProCategory like '%" + categoryName + "%' p.ProID = s.ProID and p.Barcode = p.Barcode ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public DataTable SearchByBrand(string brandName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],s.[Quantity], s.[StockStatus] " +
                " FROM Products p , Stock s WHERE p.ProBrand like '%" + brandName + "%' p.ProID = s.ProID and p.Barcode = p.Barcode ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public DataTable SearchByBrandandCategory(string brandName, string categoryName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],s.[Quantity], s.[StockStatus] " +
                " FROM Products p , Stock s WHERE p.ProBrand like '%" + brandName + "%' and p.ProCategory like '%" + categoryName + "%'" +
                " p.ProID = s.ProID and p.Barcode = p.Barcode ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public DataTable SearchByIDProNameandCategory(string value)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],s.[Quantity], s.[StockStatus] " +
                " FROM Products p , Stock s WHERE p.ProName like '%" + value + "%' or p.ProCategory like '%" + value + "%'" +
                " or p.ProID like '%" + value + "%' p.ProID = s.ProID and p.Barcode = p.Barcode ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }
    }


}
