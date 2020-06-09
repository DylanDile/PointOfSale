using PointOfSale.Controllers;
using PointOfSale.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PointOfSale
{
    class ClassProducts
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dTable;
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();
        UserModel userModel = new UserModel();
        ClassUsers cUsers = new ClassUsers();

        public DataTable dataTable { get; set; } = new DataTable();
        private int counter { get; set; }
        public void AddColumns()
        {
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Total Price");

            counter = 0;
        }
        public void AddRows(string prdName, int qty, decimal price, decimal total)
        {
            counter += 1;
            decimal totalPrice = Math.Round((qty * price), 2);
            int newQty = qty;
            decimal newTotalPrice = totalPrice;
            //txt_totalPrice.Text = totalPrice.ToString();            
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    string avaProName = row["Product Name"].ToString();
                    int avaQty = Convert.ToInt16(row["Quantity"].ToString());
                    if (prdName == avaProName)
                    {
                        dataTable.Rows.Remove(row);
                        newQty += avaQty;
                        newTotalPrice = Math.Round((newQty * price), 2);
                    }
                }
            }

            dataTable.Rows.Add(counter, prdName, newQty, price, newTotalPrice);
        }

        public DataTable dt()
        {
            return this.dataTable;
        }

        public bool AddProducts(Product p)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Products values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14,@15)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", p.Barcode);
            cmd.Parameters.AddWithValue("@2", p.ProName);
            cmd.Parameters.AddWithValue("@3", p.ProCategory);
            cmd.Parameters.AddWithValue("@4", p.ProBrand);
            cmd.Parameters.AddWithValue("@5", p.ProTag);
            cmd.Parameters.AddWithValue("@6", p.FrontCameraPXL);
            cmd.Parameters.AddWithValue("@7", p.BackCameraPXL);
            cmd.Parameters.AddWithValue("@8", p.ScreenSize);
            cmd.Parameters.AddWithValue("@9", p.ProOS);
            cmd.Parameters.AddWithValue("@10", p.ProRam);
            cmd.Parameters.AddWithValue("@11", p.ProROM);
            cmd.Parameters.AddWithValue("@12", p.SerialNumber);
            cmd.Parameters.AddWithValue("@13", p.OtherInfor);
            cmd.Parameters.AddWithValue("@14", "Active");
            cmd.Parameters.AddWithValue("@15", p.DateAdded);
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

        public DataTable SearchProduct(int proid)
        {
            con = new SqlConnection(cn.connection);
            string sql = "select top 1 * from Products where ProID = @1 ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", proid);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

        public bool UpdateProduct(Product p)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "update  Products set ProName = @2, ProCategory = @3,ProBrand= @4, ProTag = @5,FrontCamera= @6, " +
                " BackCamera =  @7, ScreenSize = @8, ProOS = @9, RAM = 10, ROM=  @11, SerialNumber = @12,OtherInfo= @13," +
                " ProStatus= @14 Where Barcode= @1 and ProID = @15";
            cmd = new SqlCommand(sql, con);
            con.Open();           
            cmd.Parameters.AddWithValue("@2", p.ProName);
            cmd.Parameters.AddWithValue("@3", p.ProCategory);
            cmd.Parameters.AddWithValue("@4", p.ProBrand);
            cmd.Parameters.AddWithValue("@5", p.ProTag);
            cmd.Parameters.AddWithValue("@6", p.FrontCameraPXL);
            cmd.Parameters.AddWithValue("@7", p.BackCameraPXL);
            cmd.Parameters.AddWithValue("@8", p.ScreenSize);
            cmd.Parameters.AddWithValue("@9", p.ProOS);
            cmd.Parameters.AddWithValue("@10", p.ProRam);
            cmd.Parameters.AddWithValue("@11", p.ProROM);
            cmd.Parameters.AddWithValue("@12", p.SerialNumber);
            cmd.Parameters.AddWithValue("@13", p.OtherInfor);
            cmd.Parameters.AddWithValue("@14", p.ProStatus);
            cmd.Parameters.AddWithValue("@1",  p.Barcode);
            cmd.Parameters.AddWithValue("@15", p.ProID);
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

        public DataTable SearchByCategory(string categoryName )
        {
            con = new SqlConnection(cn.connection);
            string sql = "select [ProID] ,[Barcode] ,[ProName] ,[ProCategory],[ProBrand],[ProTag] from Products where ProCategory like '%" + categoryName + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

        public DataTable SearchByBrand(string brandName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "select [ProID] ,[Barcode] ,[ProName] ,[ProCategory],[ProBrand],[ProTag] from Products where ProBrand like '%" + brandName + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

        public DataTable SearchByBrandandCategory(string brandName, string categoryName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "select [ProID] ,[Barcode] ,[ProName] ,[ProCategory],[ProBrand],[ProTag] from Products " +
                " where ProBrand like '%" + brandName + "%' and ProCategory like '%" + categoryName + "%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

        public DataTable SearchByIDProNameandCategory(string value)
        {
            con = new SqlConnection(cn.connection);
            string sql = "select [ProID] ,[Barcode] ,[ProName] ,[ProCategory],[ProBrand],[ProTag] from Products " +
                " where ProName like '%" + value + "%' or ProCategory like '%" + value + "%' or ProID like '%" + value +"%' ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

        public DataTable SearchByBarcode(string barcode)
        {
            con = new SqlConnection(cn.connection);
            string sql = "select top 1 * from Products where Barcode = @1 ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", barcode);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

        public DataTable SearchByProName(string proName)
        {
            con = new SqlConnection(cn.connection);
            string sql = "select top 1 * from Products where ProName = @1 ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", proName);
            adapter = new SqlDataAdapter(cmd);
            dTable = new DataTable();
            adapter.Fill(dTable);
            con.Open();

            return dTable;
        }

       

    }
}
