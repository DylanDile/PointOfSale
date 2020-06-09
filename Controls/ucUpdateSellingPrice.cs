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
    public partial class ucUpdateSellingPrice : UserControl
    {
        DataTable dt;
        ClassProducts pros = new ClassProducts();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        ClassStock st = new ClassStock();
        Parameters param = new Parameters();
        Stock s;
        ClassPrices cp = new ClassPrices();
        public int UserID { get; set; }
        public string sql { get; set; }
        public ucUpdateSellingPrice(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void ucUpdateSellingPrice_Load(object sender, EventArgs e)
        {
            LoadBrands();
            LoadCategory();
            LoadGridView();
        }

        private void txt_proID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_proID.Text == "") { txt_currentPrice.Text = ""; return; }

                FillValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillValues()
        {
            dt = new DataTable();
            dt = pros.SearchProduct(Convert.ToInt32(txt_proID.Text));
            DataRow row = dt.Rows[0];
            txt_barcode.Text = row["Barcode"].ToString();
            txt_productName.Text = row["ProName"].ToString();            

        }
        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_barcode.Text != "")
                {
                    dt = new DataTable();
                    dt = pros.SearchByBarcode(txt_barcode.Text);
                    DataRow row = dt.Rows[0];
                    txt_proID.Text = row["ProID"].ToString();
                    txt_productName.Text = row["ProName"].ToString();
                }
                else
                {
                    txt_currentPrice.Text = "";
                    return;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void serchByCategory_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serchByCategory_cmbx.SelectedIndex != -1)
            {
                string category = serchByCategory_cmbx.SelectedItem.ToString();
                dt = cp.SearchPriceByCategory( category);
                dgvProducts.DataSource = dt;
            }
            else
            {
                return;
            }
        }

        private void searchByBrand_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (searchByBrand_cmbx.SelectedIndex != -1 && serchByCategory_cmbx.SelectedIndex != -1)
            {
                dt = cp.SearchPriceByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
                dgvProducts.DataSource = dt;
            }
            else
            {
                return;
            }
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            if (txt_value.Text == "")
            {
                if (searchByBrand_cmbx.SelectedIndex != -1 && serchByCategory_cmbx.SelectedIndex != -1)
                {
                    dt = cp.SearchPriceByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
                    dgvProducts.DataSource = dt;
                }
                return;
            }
            else
            {
                dt = cp.SearchPriceByIDProNameandCategory(txt_value.Text);
                dgvProducts.DataSource = dt;

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void txt_SellingPrice_Validating(object sender, CancelEventArgs e)
        {
            int myNum = 0;
            String testVar = txt_SellingPrice.Text;

            if (int.TryParse(testVar, out myNum))
            {
                errorProvider1.SetError(txt_SellingPrice, "");
                errorProvider1.Icon.Dispose();
                return;
            }
            else
            {
                errorProvider1.SetError(txt_SellingPrice, "Enter a valid num");
                e.Cancel = true;
            }
        }

        private void txt_SellingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadGridView()
        {
            dt = ldt.LoadGridView(" SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],sp.PriceNew, sp.PriceStatus , sp.PriceDate  " +
                "FROM Products p , SellingPrices sp WHERE p.ProID = sp.ProID and p.Barcode = sp.Barcode");
            dgvProducts.DataSource = dt;
        }

        private void LoadCategory()
        {
            sql = " select CatName from Categories where CatStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string catName = row["catName"].ToString();
                serchByCategory_cmbx.Items.Add(catName);
            }
        }
        private void LoadBrands()
        {
            sql = " SELECT [brName] FROM [pos].[dbo].[Brands] where brStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string brName = row["brName"].ToString();
                searchByBrand_cmbx.Items.Add(brName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SellingPrice.Text != "")
                {
                    if ((MessageBox.Show("Confirm Update of Selling Price for : " + txt_productName.Text, "Confirm Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        UpdatePrice();
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Enter Price Please", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePrice()
        {
            int proid = Convert.ToInt32(txt_proID.Text);
            decimal price = Convert.ToDecimal(txt_SellingPrice.Text);
            string status = "";
            if(price > 0.00m)
            {
                status = param.Active;
            }
            else
            {
                status = param.InActive;
            }

            bool res = cp.UpdateProductPrice(txt_barcode.Text, proid, price, status, this.UserID);
            if(res)
            {
                MessageBox.Show("Successfully updated price for : " + txt_productName.Text, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Failed to update price.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    string proId = dgvProducts.SelectedRows[0].Cells[0].Value + string.Empty;
                    string barcode = dgvProducts.SelectedRows[0].Cells[1].Value + string.Empty;
                    string proName = dgvProducts.SelectedRows[0].Cells[2].Value + string.Empty;
                    string currentPrice = dgvProducts.SelectedRows[0].Cells[5].Value + string.Empty;

                    txt_proID.Text = proId;
                    txt_barcode.Text = barcode;
                    txt_productName.Text = proName;
                    txt_currentPrice.Text = currentPrice;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
