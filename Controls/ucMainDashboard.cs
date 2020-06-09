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

namespace PointOfSale.Controls
{
    public partial class ucMainDashboard : UserControl
    {
        ClassLoadData ldt = new ClassLoadData();
        public int UserID { get; set; }
        public ucMainDashboard(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void ucMainDashboard_Load(object sender, EventArgs e)
        {
            LoadChartInvoice();
            LoadChartRates();
            LoadGridView();
        }
        private void LoadChartInvoice()
        {
            chart1.Titles.Add("Invoice Stats");
            chart1.Series["s1"].Points.AddXY("due", "60");
            chart1.Series["s1"].Points.AddXY("paid", "40");
        }
        private void LoadChartRates()
        {
            chart2.Titles.Add("ExchangeRates Stats");
            chart2.Series["s1"].Points.AddXY("20-05-2020", "40");
            chart2.Series["s1"].Points.AddXY("21-05-2020", "10");
            chart2.Series["s1"].Points.AddXY("22-05-2020", "60");

            chart2.Series["s2"].Points.AddXY("20-05-2020", "40");
            chart2.Series["s2"].Points.AddXY("21-05-2020", "70");
            chart2.Series["s2"].Points.AddXY("22-05-2020", "20");
        }

        private void LoadGridView()
        {
            DataTable dt = ldt.LoadGridView("select Barcode , PriceNew , PriceDate from SellingPrices  where PriceStatus = 'Active' ");
            dgvPrices.DataSource = dt.DefaultView;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
