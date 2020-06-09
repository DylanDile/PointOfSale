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
    class ClassRates:ClassParameters
    {
        public bool AddRate(Rate r)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "insert into ExchangeRates values(@1, @2, @3, @4, @5, @6)";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", r.USDtoZWL);
            cmd.Parameters.AddWithValue("@2", r.USDtoRAND);
            cmd.Parameters.AddWithValue("@3", r.USDtoKWACHA);
            cmd.Parameters.AddWithValue("@4", r.USDtoPULA);
            cmd.Parameters.AddWithValue("@5", r.RateDate);
            cmd.Parameters.AddWithValue("@6", r.RateStatus);
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

        public DataTable CheckTodayRate(DateTime dateTime)
        {           
            con = new SqlConnection(cn.connection);
            con.Open();
            string sql = "select * from ExchangeRates where RateDate = @date and RateStatus = @current ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@date", dateTime);
            cmd.Parameters.AddWithValue("@current", "Current");
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;            
        }

        public bool UpdateRate(Rate r)
        {
            bool res;
            con = new SqlConnection(cn.connection);
            string sql = "update ExchangeRates set" +
                " USDtoZWL = @1, " +
                " USDtoRAND = @2, " +
                " USDtoKWACHA = @3," +
                " USDtoPULA = @4  " +
                " where RateDate = @5 and RateStatus = @6";
            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@1", r.USDtoZWL);
            cmd.Parameters.AddWithValue("@2", r.USDtoRAND);
            cmd.Parameters.AddWithValue("@3", r.USDtoKWACHA);
            cmd.Parameters.AddWithValue("@4", r.USDtoPULA);
            cmd.Parameters.AddWithValue("@5", r.RateDate);
            cmd.Parameters.AddWithValue("@6", r.RateStatus);
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
