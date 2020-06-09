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

namespace PointOfSale.Admin
{
    public partial class ucAddSellingPrices : UserControl
    {
        ClassSelects sel = new ClassSelects();
        ClassSearch search = new ClassSearch();
        ClassInserts ins = new ClassInserts();
        Connection cn = new Connection();
        ClassProducts pros = new ClassProducts();
        Company.ClassCompany com = new Company.ClassCompany();
        ClassLoadData ldt = new ClassLoadData();
        DataTable dt;
        public ucAddSellingPrices()
        {
            InitializeComponent();
        }

        private void ucAddSellingPrices_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadPrices();
        }
        private void LoadGridView()
        {
            dt = ldt.LoadGridView("select pdctID , pdctBarcode , pdctName , pdctTag , pdctOther from products where pdctStatus = 'Active'");
            dgvProducts.DataSource = dt;
        }

        private void LoadPrices()
        {
            dt = ldt.LoadGridView(" select p.pdctID , p.pdctName , sp.priceNew from Products p , SellingPrices sp " +
                " where p.pdctID = sp.pdctID and p.pdctStatus = 'Active' and sp.priceStatus = 'Active' ");
            dgvPrices.DataSource = dt;
        }

        private void dgvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    string proId = dgvProducts.SelectedRows[0].Cells[0].Value + string.Empty;
                    string proBarcode = dgvProducts.SelectedRows[0].Cells[1].Value + string.Empty;
                    string proName = dgvProducts.SelectedRows[0].Cells[2].Value + string.Empty;
                    string proDesc = dgvProducts.SelectedRows[0].Cells[4].Value + string.Empty;
                    txt_proID.Text = proId;
                    txt_proName.Text = proName;
                    txt_barcode.Text = proBarcode;
                    rchtxt_descripiton.Text = proDesc;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = search.SearchValue("select pdctID , pdctBarcode , pdctName , pdctTag , pdctOther " +
                    " from products " +
                    " where pdctStatus = 'Active' " +
                    " and pdctName  like '%" + txt_search.Text + "%' or pdctBarcode like '" + txt_search.Text + "' ");
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {               
                bool res = ins.AddSellingPrice(Convert.ToInt32(txt_proID.Text), Convert.ToDecimal(txt_price.Text));
                if(res)
                {
                    MessageBox.Show("Successfully added price for : " + txt_proName.Text, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPrices();
                    txt_proID.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add the selling price ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_price_Validating(object sender, CancelEventArgs e)
        {
            decimal price = 0;
            String testVar = txt_price.Text;

            if (Decimal.TryParse(testVar, out price))
            {
                return;
            }
            else
            {
                MessageBox.Show("Enter a valid decimal value please. Eg: 10.50 ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dt = search.SearchValue("select p.pdctID , p.pdctName , sp.priceNew from Products p , SellingPrices sp " +
                " where p.pdctID = sp.pdctID and p.pdctStatus = 'Active' and sp.priceStatus = 'Active' " +
                    " and p.pdctName  like '%" + txt_searchPrice.Text + "%' or p.pdctBarcode like '" + txt_searchPrice.Text + "' ");
                dgvPrices.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_proID_TextChanged(object sender, EventArgs e)
        {
            if(txt_proID.Text == "")
            {
                txt_barcode.Text = "";
                rchtxt_descripiton.Text = "";
                txt_proName.Text = "";
                txt_price.Text = "0.00";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_proID.Text = "";
        }
    }
}
