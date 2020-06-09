using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Models;
using PointOfSale.Controllers;

namespace PointOfSale.Controls
{
    public partial class ucUpdateStock : UserControl
    {
        DataTable dt;
        ClassProducts pros = new ClassProducts();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        ClassStock st =  new ClassStock();
        Parameters param = new Parameters();
        Stock s;
        public int UserID { get; set; }
        public string  sql { get; set; }
        public ucUpdateStock(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void ucAddStock_Load(object sender, EventArgs e)
        {
            LoadBrands();
            LoadCategory();
            LoadGridView();
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

                    txt_proID.Text = proId;
                    txt_barcode.Text = barcode;
                    txt_productName.Text = proName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_proID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_proID.Text == "") { return; }

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
                if(txt_barcode.Text != "")
                {
                    dt = new DataTable();
                    dt = pros.SearchByBarcode(txt_barcode.Text);
                    DataRow row = dt.Rows[0];
                    txt_proID.Text = row["ProID"].ToString();
                    txt_productName.Text = row["ProName"].ToString();
                }                   
                else
                {
                    return;
                }
                    
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Quantity.Text != "")
                {
                    if ((MessageBox.Show("Confirm Update of Product", "Confirm Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        UpdateStock();
                    }
                    else
                    {
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Enter Quantity Please", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with message :" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void UpdateStock()
        {
            
            string status = "";
            int qty = Convert.ToInt32(txt_Quantity.Text);
            if(qty > 0)
            {
                status = param.Available;
            }
            else if(qty == 0)
            {
                status = param.OutOfStock;
            }

            bool res = st.UpdateStock(qty, status, Convert.ToInt32( txt_proID.Text), txt_barcode.Text);

            if(res)
            {
                MessageBox.Show("New Stock Updated.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update stock ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txt_Quantity_Validating(object sender, CancelEventArgs e)
        {
            int myNum = 0;
            String testVar = txt_Quantity.Text;

            if (int.TryParse(testVar, out myNum))
            {
                errorProvider1.SetError(txt_Quantity, "");
                errorProvider1.Icon.Dispose();
                return;
            }
            else
            {
                errorProvider1.SetError(txt_Quantity, "Enter a valid num");
                e.Cancel = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
             LoadGridView();
        }
        private void LoadGridView()
        {
            dt = ldt.LoadGridView("SELECT p.[ProID] , p.[Barcode] , p.[ProName] , p.[ProCategory], p.[ProBrand],s.[Quantity], s.[StockStatus] " +
                " FROM Products p , Stock s WHERE p.ProID = s.ProID and p.Barcode = p.Barcode");
            dgvProducts.DataSource = dt;
        }

        private void LoadCategory()
        {
            sql = "select CatName from Categories where CatStatus = 'Active' ";
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
        private void serchByCategory_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serchByCategory_cmbx.SelectedIndex != -1)
            {
                string category = serchByCategory_cmbx.SelectedItem.ToString();
                dt = st.SearchByCategory(category);
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
                dt = st.SearchByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
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
                    dt = st.SearchByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
                    dgvProducts.DataSource = dt;
                }
                return;
            }
            else
            {
                dt = st.SearchByIDProNameandCategory(txt_value.Text);
                dgvProducts.DataSource = dt;

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

        private void txt_productName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
