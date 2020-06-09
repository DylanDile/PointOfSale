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
using PointOfSale.Forms;
using System.Web;
using Newtonsoft.Json;
using PointOfSale.Company;
using PointOfSale.ReportForms;

namespace PointOfSale.Controls
{
    public partial class ucPrintInvoices : UserControl
    {
        DataTable dt;
        ClassCompany com = new ClassCompany();
        ClassCustomers cc = new ClassCustomers();
        ClassProducts pros = new ClassProducts();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        ClassStock st = new ClassStock();
        Parameters param = new Parameters();
        ClassRates rt = new ClassRates();
        Stock s;
        public int UserID { get; set; }
        public string sql { get; set; }
        IList<Cart> items = new List<Cart>();
        public ucPrintInvoices(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void ucPrintInvoices_Load(object sender, EventArgs e)
        {
            LoadProNames();
            LoadCustomers();
            //txt_BasicCurrency.Text = "USD";
        }

         private void LoadCustomers()
        {
            customersNames_cmbx.Items.Clear();
            dt = ldt.LoadGridView("SELECT CustName FROM Customers ");
            foreach (DataRow row in dt.Rows)
            {
                string customerName = row["CustName"].ToString();
                customersNames_cmbx.Items.Add(customerName);
            }
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_barcode.Text != "")
                {
                    dt = new DataTable();
                    string barcode = txt_barcode.Text;
                    string sql = " select p.[ProID],p.[Barcode],p.[ProName], sp.[PriceNew] , st.[Quantity]  " +
                        "FROM Products p , SellingPrices sp, Stock st  " +
                        " WHERE p.ProID = st.ProID  and p.ProID = sp.ProID  and p.Barcode = '" + barcode + "' ";
                    dt = ldt.LoadDataTable(sql);

                    DataRow row = dt.Rows[0];
                    txt_proName.Text = row["ProName"].ToString();
                    txt_proid.Text = row["ProID"].ToString();
                    txt_proPrice.Text = row["PriceNew"].ToString();
                    txt_availableStock.Text = row["Quantity"].ToString();

                }
                else
                {
                    ClearAllText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProNames()
        {
            productList_cmbx.Items.Clear();
            sql = " SELECT [ProName] FROM [pos].[dbo].[Products] where ProStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string proName = row["ProName"].ToString();
                productList_cmbx.Items.Add(proName);
            }
        }       
        private void CalculateTotalPrice()
        {
            if (items.Count > 0)
            {
                decimal subTotal = 0.00m;
                foreach (var item in items)
                {
                    subTotal += item.TotalPrice;
                }

                txt_subtotal.Text = subTotal.ToString();
            }
            else
            {
                txt_subtotal.Text = "0.00";
            }

        }
        private decimal SubTotal()
        {
            decimal subTotal = 0.00m;
            foreach (var item in items)
            {
                subTotal += item.TotalPrice;
            }

            return subTotal;
        }
        private decimal AmountDue()
        {
            decimal subTotal = 0.00m;
            foreach (var item in items)
            {
                subTotal += item.TotalPrice;
            }

            decimal vat = Convert.ToDecimal(txt_vatAmount.Text);
            decimal discount = Convert.ToDecimal(txt_discountAmnt.Text);

            decimal amountDue = (subTotal + vat) - discount;
            return amountDue;
        }
        private void RefreshCart()
        {
            var source = new BindingSource();
            source.DataSource = items;
            dgvOrder.DataSource = source;
        }

        private void RemoveFromCart(int itemID)
        {
            items.Remove(items.Single(x => x.id == itemID));
            RefreshCart();
        }
        private void txt_proid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (productList_cmbx.SelectedIndex != -1)
                {
                    dt = new DataTable();
                    int proid = Convert.ToInt32(txt_proid.Text);
                    dt = pros.SearchProduct(proid);
                    DataRow row = dt.Rows[0];
                    txt_barcode.Text = row["Barcode"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (productList_cmbx.SelectedIndex != -1)
                {
                    dt = new DataTable();
                    string proName = productList_cmbx.SelectedItem.ToString();
                    dt = pros.SearchByProName(proName);

                    DataRow row = dt.Rows[0];
                    txt_barcode.Text = row["Barcode"].ToString();
                }
                LoadProNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_availableStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_availableStock.Text == "")
                {
                    return;
                }
                if(txt_proid.Text == "")
                {
                    return;
                }
                int stock = Convert.ToInt32(txt_availableStock.Text);
                if (stock < 1)
                {
                    MessageBox.Show("We are out of stock for that product.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_quantity.Enabled = false;

                }
                else
                {
                    txt_quantity.Enabled = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void txt_quantity_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_quantity.Enabled == false)
                {
                    MessageBox.Show("We are out of stock for that product.!", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var source = new BindingSource();
                string proName = txt_proName.Text;
                int qty = Convert.ToInt32(txt_quantity.Text);
                decimal price = Convert.ToDecimal(txt_proPrice.Text);
                decimal subPrice = Math.Round(Convert.ToDecimal(qty * price), 2);
                Cart c = new Cart();
                int counter = 1;
                foreach (var item in items)
                {
                    counter += 1;
                    if (item.ProName == proName)
                    {
                        item.Quantity += qty;
                        if (item.Quantity < 1)
                        {
                            RemoveFromCart(item.id);
                            CalculateTotalPrice();
                            return;
                        }
                        item.TotalPrice = item.Quantity * item.Price;
                        RefreshCart();
                        CalculateTotalPrice();
                        return;
                    }
                }

                items.Add(new Cart() { id = counter, ProName = proName, Quantity = qty, Price = price, TotalPrice = subPrice });
                source.DataSource = items;
                dgvOrder.DataSource = source;
                CalculateTotalPrice();
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_subtotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = Convert.ToDecimal(txt_subtotal.Text);
                decimal vatAmountRate = 0.15m;
                decimal discountRate = 0.10m;
                decimal vatAmount = 0.00m;
                decimal discAmount = 0.00m;
                if (checkBx_vatAmount.Checked == true)
                {                
                    vatAmount = Math.Round( (vatAmountRate * subtotal), 2);
                    txt_vatAmount.Text = vatAmount.ToString();

                }
                else
                {
                    txt_vatAmount.Text = "0.00";

                }
                if (chckBox_Discount.Checked == true)
                { 
                    discAmount = Math.Round( (discountRate * subtotal), 2);
                    txt_discountAmnt.Text = discAmount.ToString();

                }
                else
                {
                    txt_discountAmnt.Text = "0.00";
                } 
                
                decimal amountDue = (SubTotal() + vatAmount) - discAmount;
                txt_totalProductsPrice.Text = amountDue.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_amountReceived_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_RemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrder.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    int itemID = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells[0].Value + string.Empty);
                    string proName = dgvOrder.SelectedRows[0].Cells[2].Value + string.Empty;
                    items.Remove(items.Single(x => x.id == itemID));
                    //items.Remove(new Cart() { id = itemID }); //this was going to work also

                    RefreshCart();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrder.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    string proName = dgvOrder.SelectedRows[0].Cells[1].Value + string.Empty;
                    productList_cmbx.Text = proName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm(new frm_AddCustomer());
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(customersNames_cmbx.Text == "")
            {
                return;
            }

            DataRow row = cc.SearcCustomerByName(customersNames_cmbx.Text);
            string custName = row["CustName"].ToString();
            txt_customerNme.Text = custName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btn_recordSale_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (cmbx_currency.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Currency Please ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/
                if (MessageBox.Show("Do you want to save the Invoice?. ", "Question Message?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveInvoice();
                }
                string currency ="USD";
                DataRow custInfo = cc.SearcCustomerByName(txt_customerNme.Text);
                DataTable pros = new DataTable();
                pros.Columns.Add("Product Name");
                pros.Columns.Add("Quantity");
                pros.Columns.Add("Price");
                pros.Columns.Add("Total Price");

                foreach (var item in items)
                {
                    pros.Rows.Add(item.ProName, item.Quantity, item.Price, item.TotalPrice);
                }
               
                string invoiceNo = GenerateInvNo();
                frm_InvoiceReport qr = new frm_InvoiceReport(
                    pros, 
                    custInfo["CustName"].ToString(), 
                    custInfo["CustAddress"].ToString(),
                    custInfo["CustPhone"].ToString(),
                    custInfo["CustEmail"].ToString(), 
                    invoiceNo, 
                    Convert.ToDecimal(txt_subtotal.Text),
                    Convert.ToDecimal(txt_discountAmnt.Text), 
                    Convert.ToDecimal(txt_vatAmount.Text), 
                    Convert.ToDecimal(txt_totalProductsPrice.Text),
                    currency);
                MessageBox.Show("Loading the report......");
               
                qr.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveInvoice()
        {
            //Convert the products to a data array
            Cart[][] newKeys = items.Select(x => new Cart[] { x }).ToArray();
            string json = JsonConvert.SerializeObject(newKeys);
            string jsonAll = JsonConvert.SerializeObject(items);
            DataRow custInfo = cc.SearcCustomerByName(txt_customerNme.Text);
            int custID = int.Parse( custInfo["CustID"].ToString());
            string custName = custInfo["CustName"].ToString();
            bool res = cc.AddInvoice(GenerateInvNo(), custID, custName, json, SubTotal(),
                Convert.ToDecimal(txt_vatAmount.Text), Convert.ToDecimal(txt_discountAmnt.Text), AmountDue(), param.newInvStatus, DateTime.Now.Date, this.UserID);
            if(res)
            {
                MessageBox.Show("Invoice has been stored.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to store an invoice. ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }
        private static Random random = new Random();
        private string GenerateInvNo()
        {
            string invoiceNo;
            string tday = DateTime.Now.ToString("yyyyMMdd");
            string invNo = "INV";

            DataRow row = cc.LastInvoic();
            if(row == null)
            {
                invoiceNo = invNo + tday + "001";
            }
            else
            {
                string lastInv = row["InvNum"].ToString();
                string lastNum = lastInv.Substring(9, 3);
                int plusOne = int.Parse(lastNum) + 1;
                invoiceNo = invNo + tday + plusOne.ToString();
            }
            return invoiceNo;
        }
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 9)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBox_Discount.Checked == true)
            {
                decimal subTotal =  Convert.ToDecimal( txt_subtotal.Text);
                decimal discountRate = 0.10m;
                decimal discAmount = Math.Round((discountRate * subTotal),2);
               
                txt_discountAmnt.Text = discAmount.ToString();
                
            }
            else
            {
                txt_discountAmnt.Text = "0.00";
            }
            decimal dsAmnt = Convert.ToDecimal( txt_discountAmnt.Text);
            decimal amountDue = (SubTotal() - dsAmnt);
            txt_totalProductsPrice.Text = amountDue.ToString();
        }

        private void checkBx_vatAmount_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBx_vatAmount.Checked == true)
            {
                decimal subTotal = Convert.ToDecimal(txt_subtotal.Text);
                decimal vatAmountRate = 0.15m;
                decimal vatAmount = Math.Round( (vatAmountRate * subTotal), 2);                
                txt_vatAmount.Text = vatAmount.ToString();
                
            }
            else
            {
                txt_vatAmount.Text = "0.00";
                 
            }
            decimal vat = Convert.ToDecimal(txt_vatAmount.Text);
            decimal amountDue = Math.Round((SubTotal() + vat), 2);
            txt_totalProductsPrice.Text = amountDue.ToString();
        }

        private void txt_vatAmount_TextChanged(object sender, EventArgs e)
        {
            decimal vat = Convert.ToDecimal(txt_vatAmount.Text);
            decimal amountDue = (SubTotal() + vat);
            txt_totalProductsPrice.Text = amountDue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the items from the order also?. ", "Question Message?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvOrder.DataSource = null;
                items.Clear();
            }
             ClearAllText();
        }

        private void txt_discountAmnt_TextChanged(object sender, EventArgs e)
        {
            decimal dsAmnt = Convert.ToDecimal(txt_discountAmnt.Text);
            decimal amountDue = (SubTotal() - dsAmnt);
            txt_totalProductsPrice.Text = amountDue.ToString();
        }
        private void ClearAllText()
        {
            txt_proName.Text = "";
            txt_quantity.Text = "";
            txt_subtotal.Text = "0.00";
            txt_totalProductsPrice.Text = "0.00";
            txt_vatAmount.Text = "0.00";
            txt_discountAmnt.Text = "0.00";
            txt_proPrice.Text = "0.00";
            txt_availableStock.Text = "0";
            txt_proid.Text = "";
            txt_barcode.Text = "";
        }

        private void btn_void_Click(object sender, EventArgs e)
        {
            items.Clear();
            ClearAllText();
        }

        private void cmbx_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                if(cmbx_currency.SelectedIndex == -1)
                {
                    return;
                }
                txt_BasicCurrency.Text = cmbx_currency.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void txt_BasicCurrency_Click(object sender, EventArgs e)
        {

        }

        private void txt_BasicCurrency_TextChanged(object sender, EventArgs e)
        {
           /* try
            {
                string currency = txt_BasicCurrency.Text;
                dt = rt.CheckTodayRate(DateTime.Now.Date);
                DataRow row = dt.Rows[0];
                decimal usdtozwl = Convert.ToDecimal(row["USDtoZWL"].ToString());
                decimal usdtorand = Convert.ToDecimal(row["USDtoRAND"].ToString());
                decimal usdtokwacha = Convert.ToDecimal(row["USDtoKWACHA"].ToString());
                decimal usdtopula = Convert.ToDecimal(row["USDtoPULA"].ToString());

                decimal subtotal = SubTotal();
                decimal newSubTotal = 0.00m;
                if (currency == "USD")
                {
                    txt_CurrentRate.Text = "$1";
                    txt_subtotal.Text = subtotal.ToString();
                }
                else if (currency == "ZWL")
                {
                    txt_CurrentRate.Text = usdtozwl.ToString();
                    newSubTotal = subtotal * usdtozwl;
                    txt_subtotal.Text = newSubTotal.ToString();
                }
                else if (currency == "RAND")
                {
                    txt_CurrentRate.Text = usdtorand.ToString();
                    newSubTotal = subtotal * usdtorand;
                    txt_subtotal.Text = newSubTotal.ToString();
                }
                else if (currency == "KWACHA")
                {
                    txt_CurrentRate.Text = usdtokwacha.ToString();
                    newSubTotal = subtotal * usdtokwacha;
                    txt_subtotal.Text = newSubTotal.ToString();
                }
                else if (currency == "PULA")
                {
                    txt_CurrentRate.Text = usdtopula.ToString();
                    newSubTotal = subtotal * usdtopula;
                    txt_subtotal.Text = newSubTotal.ToString();
                }
                else
                {
                    txt_CurrentRate.Text = "$1";
                    newSubTotal = subtotal * 1;
                    txt_subtotal.Text = newSubTotal.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    
    }
}