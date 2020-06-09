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
    class ClassPrices
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        Price p;

        ClassProducts pros = new ClassProducts();
        Connection cn = new Connection();
        public bool AddProductToPrices(Price p)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into SellingPrices values(@1, @2, @3, @4, @5, @6)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", p.ProID);
            cmd.Parameters.AddWithValue("@2", p.Barcode);
            cmd.Parameters.AddWithValue("@3", p.PriceNew);
            cmd.Parameters.AddWithValue("@4", p.PriceDate);
            cmd.Parameters.AddWithValue("@5", p.AddedBy);
            cmd.Parameters.AddWithValue("@6", p.PriceStatus);
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
        public bool AddPriceByBarcode(string barcode, int userid)
        {
            bool res;
            dt = new DataTable();
            dt = pros.SearchByBarcode(barcode);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                int proid = Convert.ToInt32(row["ProID"].ToString());
                p = new Price();
                p.ProID = proid;
                p.Barcode = barcode;
                p.PriceNew = 0.00m;
                p.PriceDate = DateTime.Now.Date;
                p.AddedBy = userid;
                p.PriceStatus = "InActive";

                res = AddProductToPrices(p);
            }
            else
            {
                res = false;
            }

            return res;
        }

        public bool UpdateProductPrice(string barcode, int proid, decimal price , string status, int userid)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "update SellingPrices set PriceNew = @1 , PriceDate = @date ,AddedBy = @user, PriceStatus = @2 where Barcode =@3 and ProID = @4 ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", price);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@user",userid);
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
        public DataTable SearchPriceByCategory(string categoryName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],sp.PriceNew, sp.PriceStatus , sp.PriceDate  " +
                " FROM Products p , SellingPrices sp WHERE p.ProID = sp.ProID and p.Barcode = sp.Barcode" +
                " and p.ProCategory like '%" + categoryName + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public DataTable SearchPriceByBrand(string brandName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],sp.PriceNew, sp.PriceStatus , sp.PriceDate  " +
                " FROM Products p , SellingPrices sp WHERE p.ProID = sp.ProID and p.Barcode = sp.Barcode" +
                " and p.ProBrand like '%" + brandName + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public DataTable SearchPriceByBrandandCategory(string brandName, string categoryName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],sp.PriceNew, sp.PriceStatus , sp.PriceDate  " +
                " FROM Products p , SellingPrices sp WHERE p.ProID = sp.ProID and p.Barcode = sp.Barcode" +
                " and p.ProBrand like '%" + brandName + "%' and p.ProCategory like '%" + categoryName + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public DataTable SearchPriceByIDProNameandCategory(string value)
        {
            con = new SqlConnection(cn.connection);
            string sql = "SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],sp.PriceNew, sp.PriceStatus , sp.PriceDate  " +
                " FROM Products p , SellingPrices sp WHERE p.ProID = sp.ProID and p.Barcode = sp.Barcode" +
                " and p.ProName like '%" + value + "%' or p.ProCategory like '%" + value + "%'" +
                " or p.ProID like '%" + value + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            con.Open();

            return dt;
        }

        public decimal GetProductPrice(int proid)
        {
            decimal price;
            con = new SqlConnection(cn.connection);
            string sql = "SELECT PriceNew FROM SellingPrices WHERE ProID = @1";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", proid);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                price = Convert.ToDecimal(row["PriceNew"].ToString());
            }
            else
            {
                price = 0.00m;
            }
            con.Open();

            return price;
        }

    }
}
