using PointOfSale.Admin;
using PointOfSale.Controls;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Main_Menu : Form
    {
        public int UserID { get; set; }
        public Main_Menu(int userid)
        {
            InitializeComponent();
            lbl_username.Text = userid.ToString();
            this.UserID = userid;
        }

        private void ShowForm(Form form)
        {
            form.Show();
        }
        public void AddControllsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(c);
        }


        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login ff = new frm_login();
            ff.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucAddProduct ds = new ucAddProduct(this.UserID);
            AddControllsToPanel(ds);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addCompanyInforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CompanyConfig.frm_AddCompanyInfo());
        }

        private void addBranchInforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CompanyConfig.frm_AddBranchInfo());
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            ucMainDashboard ds = new ucMainDashboard(this.UserID);
            AddControllsToPanel(ds);          
        }

        private void printQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ucPrintQuotations ds = new ucPrintQuotations();
            AddControllsToPanel(ds);
        }

        private void recordSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addSellingPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucAddSellingPrices ds = new ucAddSellingPrices();
            AddControllsToPanel(ds);
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucManageProducts ds = new ucManageProducts(this.UserID);
            AddControllsToPanel(ds);
        }

        private void addStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ucUpdateStock ds = new ucUpdateStock(this.UserID);
            AddControllsToPanel(ds);
        }

        private void updateSellingPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucUpdateSellingPrice ds = new ucUpdateSellingPrice(this.UserID);
            AddControllsToPanel(ds);
        }

        private void salesRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucSalesRecord ds = new ucSalesRecord(this.UserID);
            AddControllsToPanel(ds);
        }

        private void printInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPrintInvoices ds = new ucPrintInvoices(this.UserID);
            AddControllsToPanel(ds);
        }

        private void dailyRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucDailyExchangeRate ds = new ucDailyExchangeRate(this.UserID);
            AddControllsToPanel(ds);
        }

        private void allInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucInvoices ds = new ucInvoices(this.UserID);
            AddControllsToPanel(ds);
        }

        private void manageSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucInvoices ds = new ucInvoices(this.UserID);
            AddControllsToPanel(ds);
        }

        private void stockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPrintInvoices ds = new ucPrintInvoices(this.UserID);
            AddControllsToPanel(ds);
        }
    }
}
