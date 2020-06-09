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
    public partial class ucSalesRecord : UserControl
    {
        DataTable dt;
        ClassProducts pros = new ClassProducts();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        ClassStock st = new ClassStock();
        Parameters param = new Parameters();
        Stock s;
        public int UserID { get; set; }
        public string sql { get; set; }
        IList<Cart> items = new List<Cart>();
       
        public ucSalesRecord(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ucSalesRecord_Load(object sender, EventArgs e)
        {
            LoadBrands();            
        }

        private void LoadBrands()
        {
            sql = " SELECT [ProName] FROM [pos].[dbo].[Products] where ProStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string proName = row["ProName"].ToString();
                productList_cmbx.Items.Add(proName);
            }
        }

        private void productList_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productList_cmbx.Text == "")
            {
                return;
            }

            int index = productList_cmbx.FindString(productList_cmbx.Text);
            productList_cmbx.SelectedIndex = index;
            return;

            sql = " SELECT [ProName] FROM [pos].[dbo].[Products] where ProName like '%" + productList_cmbx.Text + "%' and ProStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string proName = row["ProName"].ToString();               
                productList_cmbx.Items.Add(proName);
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
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {                
                if(productList_cmbx.SelectedIndex != -1)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Item");
                dt.Columns.Add("ProName");
                dt.Columns.Add("Price");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("TotalPrice");
                int counter = 1;
                foreach (var item in items)
                {
                    counter += 1;
                    dt.Rows.Add(counter, item.ProName, item.Quantity, item.Price, item.TotalPrice);
                }

                PrintFiscal pf = new PrintFiscal( this.UserID, this.items);
                pf.print();
            }
            catch (Exception ex)
            {

            }
        }
        private void RecordSales()
        {

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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_barcode.Text != "")
                {
                    dt = new DataTable();
                    string barcode = txt_barcode.Text;
                    string sql = " select p.[ProID],p.[Barcode],p.[ProName], sp.[PriceNew] , st.[Quantity]  " +
                        "FROM Products p , SellingPrices sp, Stock st  " +
                        " WHERE p.ProID = st.ProID  and p.ProID = sp.ProID  and p.Barcode = '" + barcode +"' ";
                    dt = ldt.LoadDataTable(sql);

                    DataRow row = dt.Rows[0];
                    txt_proName.Text = row["ProName"].ToString();
                    txt_proid.Text = row["ProID"].ToString();
                    txt_proPrice.Text = row["PriceNew"].ToString();
                    txt_availableStock.Text = row["Quantity"].ToString();

                }
                else
                {
                    ClearAllText(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
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

        private void txt_availableStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_availableStock.Text == "")
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

        private void CalculateTotalPrice()
        {
            if(items.Count > 0)
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

        private void button7_Click(object sender, EventArgs e)
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

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_subtotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = Convert.ToDecimal(txt_totalProductsPrice.Text);               
                decimal vatAmnt = Math.Round(Convert.ToDecimal(0.15m * subtotal), 2);
                decimal totalPrice = Convert.ToDecimal(subtotal + vatAmnt);
                
                txt_vatAmount.Text = vatAmnt.ToString();
                txt_totalProductsPrice.Text = totalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_amountReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_amountReceived.Text  == "")
                {
                    return; 
                }
                decimal subtotal = SubTotal();
                decimal AmntRecievd = Convert.ToDecimal(txt_amountReceived.Text);
                decimal  change = Math.Round(Convert.ToDecimal(AmntRecievd- subtotal), 2);

                txt_change.Text = change.ToString();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
