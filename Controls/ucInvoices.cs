using PointOfSale.Company;
using PointOfSale.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace PointOfSale.Controls
{
    public partial class ucInvoices : UserControl
    {
        ClassProducts pros = new ClassProducts();
        ClassCompany com = new ClassCompany();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        DataTable dt;
        public int UserID { get; set; }
        public ucInvoices(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            try
            {
                /*int res =  DateTime.Compare(dtpkr_StartDate.Value.Date, dtpkr_EndDate.Value.Date);
                if(res < 0)
                {
                    MessageBox.Show("Date ealir" + res.ToString());
                }
                else

                {
                    MessageBox.Show("Date later" + res.ToString());
                }*/

                SearchByDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchByDates()
        {
            string status = "";
            if (serchByCategory_cmbx.SelectedIndex == -1)
            {
                 status = "";
            }
            else
            {
                status = serchByCategory_cmbx.SelectedItem.ToString();
            }
            if(status == "")
            {
                dt = ldt.LoadGridView("SELECT " +
                "[InvID] as 'ID',[InvNum] as 'Invoice',[CustID] as 'Customer ID'," +
                "[CustName] as 'Customer Name' ,[SubTotal],[Vat] ," +
                "[Discount],[GrossTotal],[InvStatus] as 'Status'," +
                "[InvDate] ,[PreparedBy] as 'User' FROM [pos].[dbo].[Invoices]" +
                " where " +
                " InvDate between '" + dtpkr_StartDate.Value.Date + "' and '" + dtpkr_EndDate.Value.Date + "' ");

                dgvInvoices.DataSource = dt;
            }
            else
            {
                dt = ldt.LoadGridView("SELECT " +
                " [InvID] as 'ID',[InvNum] as 'Invoice',[CustID] as 'Customer ID'," +
                " [CustName] as 'Customer Name' ,[SubTotal],[Vat] ," +
                " [Discount],[GrossTotal],[InvStatus] as 'Status'," +
                " [InvDate] ,[PreparedBy] as 'User' FROM [pos].[dbo].[Invoices]" +
                " where  InvStatus = '" + status + "'  and " +
                " InvDate between '" + dtpkr_StartDate.Value.Date + "' and '" + dtpkr_EndDate.Value.Date + "' ");

                dgvInvoices.DataSource = dt;
            }
            
        }
        private void LoadGridView()
        {
            dt = ldt.LoadGridView("SELECT " +
                " [InvID] as 'ID',[InvNum] as 'Invoice',[CustID] as 'Customer ID'," +
                " [CustName] as 'Customer Name' ,[SubTotal],[Vat] ," +
                " [Discount],[GrossTotal],[InvStatus] as 'Status'," +
                " [InvDate] ,[PreparedBy] as 'User' FROM [pos].[dbo].[Invoices]");
            dgvInvoices.DataSource = dt;
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_value.Text == "")
                {
                    return;
                }
                else
                {
                    dt = ldt.LoadGridView("SELECT " +
                " [InvID] as 'ID',[InvNum] as 'Invoice',[CustID] as 'Customer ID'," +
                " [CustName] as 'Customer Name' ,[SubTotal],[Vat] ," +
                " [Discount],[GrossTotal],[InvStatus] as 'Status'," +
                " [InvDate] ,[PreparedBy] as 'User' FROM [pos].[dbo].[Invoices] " +
                " where " +
                " InvNum like '%"+ txt_value.Text+"%' or  " +
                " CustID like '%"+ txt_value.Text+"%' or " +
                " InvStatus like '%"+ txt_value.Text+"%'  " +
                "");

                    dgvInvoices.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void ucInvoices_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvInvoices.Columns[e.ColumnIndex].Name;
            if (colName == "View")
            {
                string invNum = dgvInvoices[4, e.RowIndex].Value.ToString();
                MessageBox.Show(invNum);
            }
        }
    }
}
