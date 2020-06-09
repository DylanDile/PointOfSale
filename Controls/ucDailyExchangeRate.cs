using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Controllers;
using PointOfSale.Models;

namespace PointOfSale.Controls
{
    public partial class ucDailyExchangeRate : UserControl
    {
        DataTable dt;
        ClassProducts pros = new ClassProducts();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        ClassStock st = new ClassStock();
        Parameters param = new Parameters();
        ClassRates rt = new ClassRates();
        public int UserID { get; set; }
        public ucDailyExchangeRate(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void ucDailyExchangeRate_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            try
            {
                dt = ldt.LoadGridView("select " +
                    "RateID as 'ID', " +
                    "USDtoZWL as 'USD to ZWL' , " +
                    "USDtoRand as 'USD to RAND', " +
                    "USDtoPULA as 'USD to PULA', " +
                    "USDtoKWACHA as 'USD to KWACHA', " +
                    "RateDate as 'Date' ," +
                    "RateStatus as 'Status' " +
                    " from ExchangeRates");
                dgvExhangeRates.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void txt_USDtoZWLRate_Validating(object sender, CancelEventArgs e)
        {
            decimal myNum = 0;
            String usdtozwl = txt_USDtoZWLRate.Text;

            if (Decimal.TryParse(usdtozwl, out myNum))
            {
                decimal value = Convert.ToDecimal(usdtozwl);
                if (value >= 0.00m)
                {
                    return;
                }
                else

                {
                    MessageBox.Show("USD to ZWL  Rate should be greater than 0.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("USD to ZWL  Rate is not a valid decimal number.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txt_USDtoRandRate_Validating(object sender, CancelEventArgs e)
        {
            decimal myNum = 0;
            String usdtorand = txt_USDtoRandRate.Text;

            if (Decimal.TryParse(usdtorand, out myNum))
            {
                decimal value = Convert.ToDecimal(usdtorand);
                if (value >= 0.00m)
                {
                    return;
                }
                else

                {
                    MessageBox.Show("USD to RAND  Rate should be greater than 0.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("USD to RAND  Rate is not a valid decimal number.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txt_USDtoKWACHA_Validating(object sender, CancelEventArgs e)
        {
            decimal myNum = 0;
            String usdtokwacha = txt_USDtoKWACHA.Text;

            if (Decimal.TryParse(usdtokwacha, out myNum))
            {
                decimal value = Convert.ToDecimal(usdtokwacha);
                if (value >= 0.00m)
                {
                    return;
                }
                else

                {
                    MessageBox.Show("USD to KWACHA  Rate should be greater than 0.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("USD to KWACHA  Rate is not a valid decimal number.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txt_USDtoPULA_Validating(object sender, CancelEventArgs e)
        {
            decimal myNum = 0;
            String usdtopula = txt_USDtoPULA.Text;

            if (Decimal.TryParse(usdtopula, out myNum))
            {
                decimal value = Convert.ToDecimal(usdtopula);
                if (value >= 0.00m )
                {
                    return;
                }
                else

                {
                    MessageBox.Show("USD to PULA  Rate should be greater than 0.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

            }
            else
            {
                MessageBox.Show("USD to PULA  Rate is not a valid decimal number.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure to add today's rates ", "Question Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime today = DateTime.Now.Date;
                    DataTable dt = rt.CheckTodayRate(today);
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Today's Rate have been recorded.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (MessageBox.Show("Do you want to update them.? ", "Question Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateRate();
                        }
                      
                    }
                    else
                    {
                        AddDailyRate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error :" + ex.Message, "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddDailyRate()
        {
            Rate r = new Rate();
            r.USDtoZWL =Convert.ToDecimal( txt_USDtoZWLRate.Text);
            r.USDtoRAND = Convert.ToDecimal(txt_USDtoRandRate.Text);
            r.USDtoKWACHA = Convert.ToDecimal(txt_USDtoKWACHA.Text);
            r.USDtoPULA = Convert.ToDecimal(txt_USDtoPULA.Text);
            r.RateDate = DateTime.Now.Date;
            r.RateStatus = "Current";

            bool res = rt.AddRate(r);
            if(res)
            {
                MessageBox.Show("You have successfully added today's rates.!", "Success Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView(); 
                ClearAllText(this);
            }
            else
            {
                MessageBox.Show("Failed to add today's rates.!", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ClearAllText(this);
            }
        }
        private void UpdateRate()
        {
            Rate r = new Rate();
            r.USDtoZWL =Convert.ToDecimal( txt_USDtoZWLRate.Text);
            r.USDtoRAND = Convert.ToDecimal(txt_USDtoRandRate.Text);
            r.USDtoKWACHA = Convert.ToDecimal(txt_USDtoKWACHA.Text);
            r.USDtoPULA = Convert.ToDecimal(txt_USDtoPULA.Text);
            r.RateDate = DateTime.Now.Date;
            r.RateStatus = "Current";

            bool res = rt.UpdateRate(r);
            if(res)
            {
                MessageBox.Show("You have successfully updated today's rates.!", "Success Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView(); 
                ClearAllText(this);
            }
            else
            {
                MessageBox.Show("Failed to update today's rates.!", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ClearAllText(this);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update them.? ", "Question Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime today = DateTime.Now.Date;
                    DataTable dt = rt.CheckTodayRate(today);
                    if (dt.Rows.Count == 1)
                    {
                        UpdateRate();
                    }
                    else
                    {
                        MessageBox.Show("There are no exchange rates for today.!", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error :" + ex.Message, "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
