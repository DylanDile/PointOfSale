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
    class ClassCustomers
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow row;
        DataSet ds;
        Connection cn = new Connection();

        public bool NewCustomer(Customer c)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Customers values(@1, @2, @3, @4)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", c.CustName);
            cmd.Parameters.AddWithValue("@2", c.CustAddress);
            cmd.Parameters.AddWithValue("@3", c.CustPhone);
            cmd.Parameters.AddWithValue("@4",c.CustEmail);
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

        public DataRow SearcCustomerByName(string custName)
        {           
            con = new SqlConnection(cn.connection);
            string sql = "select * from  Customers where CustName = @1";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", custName);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
            }
            else
            {
                row = null;
            }

            return row;
        }

        public DataRow LastInvoic()
        {
            con = new SqlConnection(cn.connection);
            string sql = "select top 1 InvNum from Invoices order by InvID desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
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

        public bool AddInvoice(string invNum, int custID, string custName, string products,
            decimal subTotal, decimal Vat, decimal discount, decimal GrossTotal, string invStatus, DateTime invDate, int userid)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into Invoices values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", invNum);
            cmd.Parameters.AddWithValue("@2",  custID);
            cmd.Parameters.AddWithValue("@3", custName);
            cmd.Parameters.AddWithValue("@4", products);
            cmd.Parameters.AddWithValue("@5", subTotal);
            cmd.Parameters.AddWithValue("@6", Vat);
            cmd.Parameters.AddWithValue("@7", discount);
            cmd.Parameters.AddWithValue("@8", GrossTotal);
            cmd.Parameters.AddWithValue("@9", invStatus);
            cmd.Parameters.AddWithValue("@10", invDate);
            cmd.Parameters.AddWithValue("@11", userid);
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
