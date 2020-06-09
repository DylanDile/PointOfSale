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
    public partial class ucPrintQuotations : UserControl
    {
        ClassSelects sel = new ClassSelects();
        Connection cn = new Connection();
        ClassProducts pros = new ClassProducts();
        Company.ClassCompany com = new Company.ClassCompany();
        ClassLoadData ldt = new ClassLoadData();
        DataTable dt;
        public ucPrintQuotations()
        {
            InitializeComponent();
        }

        private void ucPrintQuotations_Load(object sender, EventArgs e)
        {
            pros.AddColumns();
            LoadGridView();
        }
        private void LoadGridView()
        {
            dt = ldt.LoadGridView("select ProID , Barcode , ProName , ProTag from products where ProStatus = 'Active'");
            dgvProducts.DataSource = dt;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "")
                {
                    string sql = "select top 1 * from products where ProName like '%" + txt_search.Text + "%' or ProTag like '%" + txt_search.Text + "%' or Barcode like '%" + txt_search.Text + "%' ";
                    DataRow row = sel.proSearch(sql);
                    if (row == null)
                    {
                        return;
                    }
                    string proName = row["ProName"].ToString();
                    int prdtID = Convert.ToInt32(row["ProID"].ToString());
                    decimal price = sel.priceSearch(prdtID);

                    txt_proName.Text = proName;
                    txt_proPrice.Text = price.ToString();
                }
                else
                {
                    txt_proName.Text = "";
                    txt_proPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txt_quantity.Text == "")
                {
                    return;
                }
                if (txt_proPrice.Text != "")
                {
                    int qty = Convert.ToInt16(txt_quantity.Text);
                    decimal price = Convert.ToDecimal(txt_proPrice.Text);
                    decimal totalPrice = Math.Round((qty * price), 2);

                    txt_totalPrice.Text = totalPrice.ToString();

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string proName = txt_proName.Text;
            int qty = Convert.ToInt16(txt_quantity.Text);
            decimal price = Convert.ToDecimal(txt_proPrice.Text);
            decimal totalPrice = Math.Round((qty * price), 2);
            int newQty = qty;
            decimal newTotalPrice = totalPrice;

            pros.AddRows(proName, newQty, price, newTotalPrice);
            dgvOrder.DataSource = pros.dt();
            decimal subTotal = ProductsTotal();
            txt_subtotal.Text = subTotal.ToString();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dgvOrder.DataSource = null;
            this.dgvOrder.Rows.Clear();
            pros.dt().Rows.Clear();
        }

        private void dgvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    string proId = dgvProducts.SelectedRows[0].Cells[0].Value + string.Empty;
                    string proName = dgvProducts.SelectedRows[0].Cells[2].Value + string.Empty;

                    txt_search.Text = proName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Decimal ProductsTotal()
        {
            DataTable dataTable = pros.dt();
            decimal totalPrice = 0.00m;
            foreach (DataRow row in dataTable.Rows)
            {
                decimal price = Convert.ToDecimal(row["Total Price"].ToString());
                totalPrice += price;
            }
            return totalPrice;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_customerEmail.Text == "" || txt_customerName.Text == "" || txt_customerPhone.Text == "")
            {
                MessageBox.Show("Fill in the blanks please.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable branchInfo = com.getBranchInfo();
            DataRow compInfo = com.getCompanyInfo();
            frm_QuoteReport qr;
            string quoteNo = "QT"+DateTime.Now.Date.ToString("yyyyMMddHmmss");
            qr = new frm_QuoteReport(pros.dt(), txt_customerName.Text, rchTxt_CustomerAddress.Text,
                txt_customerPhone.Text, txt_customerEmail.Text, quoteNo, Convert.ToDecimal(txt_subtotal.Text),
                Convert.ToDecimal(txt_discountAmnt.Text), Convert.ToDecimal(txt_vatAmount.Text), Convert.ToDecimal(txt_totalProductsPrice.Text));
            qr.Show();
        }

        private void txt_subtotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = ProductsTotal();
                decimal discount = Math.Round(Convert.ToDecimal(0.10m * subtotal), 2);
                decimal vatAmnt = Math.Round(Convert.ToDecimal(0.15m * subtotal), 2);
                decimal totalPrice = Convert.ToDecimal(subtotal - (discount + vatAmnt));

                txt_discountAmnt.Text = discount.ToString();
                txt_vatAmount.Text = vatAmnt.ToString();
                txt_totalProductsPrice.Text = totalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
