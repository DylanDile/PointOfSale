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
using PointOfSale.Company;
using PointOfSale.Models;

namespace PointOfSale.Controls
{
    public partial class ucManageProducts : UserControl
    {
        ClassProducts pros = new ClassProducts();
        ClassCompany com = new ClassCompany();
        ClassLoadData ldt = new ClassLoadData();
        ClassTransactions ct = new ClassTransactions();
        DataTable dt;
        Product p;
        public string sql { get; set; }
        public int UserID { get; set; }
        public ucManageProducts(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void ucManageProducts_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadBrands();
            LoadCategory();
        }
        private void LoadGridView()
        {
            dt = ldt.LoadGridView("select [ProID] ,[Barcode] ,[ProName] ,[ProCategory],[ProBrand],[ProTag] from Products");
            dgvProducts.DataSource = dt;
        }

        private void LoadCategory()
        {
            sql = "select CatName from Categories where CatStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string catName = row["catName"].ToString();
                category_cmbx.Items.Add(catName);
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
                brand_cmbx.Items.Add(brName);
                searchByBrand_cmbx.Items.Add(brName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }

        private void Clearfields()
        {
            txt_barcode.Text = "";
            txt_frontCameraPXL.Text = "";
            txt_BankCameraPXL.Text = "";
            txt_proName.Text = "";
            txt_proTag.Text = "";
            txt_RAM.Text = "";
            txt_screenSize.Text = "";
            txt_SerialNumber.Text = "";
            txt_ROM.Text = "";
            txt_OSVerison.Text = "";
            txt_OtherInfor.Text = "";
        }

        private void dgvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    string proId = dgvProducts.SelectedRows[0].Cells[0].Value + string.Empty;
                    string proName = dgvProducts.SelectedRows[0].Cells[2].Value + string.Empty;

                    txt_proID.Text = proId;
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
                if(txt_proID.Text == "") { return; }

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
            txt_frontCameraPXL.Text = row["FrontCamera"].ToString();
            txt_BankCameraPXL.Text = row["BackCamera"].ToString();
            txt_proName.Text = row["ProName"].ToString();
            txt_proTag.Text = row["ProTag"].ToString();
            txt_RAM.Text = row["RAM"].ToString();
            txt_screenSize.Text = row["ScreenSize"].ToString();
            txt_SerialNumber.Text = row["SerialNumber"].ToString();
            txt_ROM.Text = row["ROM"].ToString();
            txt_OSVerison.Text = row["ProOS"].ToString();
            txt_OtherInfor.Text = row["OtherInfo"].ToString();
            brand_cmbx.Text = row["ProBrand"].ToString();
            category_cmbx. Text = row["ProCategory"].ToString();
            proStatus_cmbx.Text = row["ProStatus"].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var controls = new[] { txt_barcode, txt_proName, txt_proTag, txt_SerialNumber };
                foreach (var control in controls)
                {
                    if (control.Text == "")
                    {
                        errorProvider1.SetError(control, "This field is required.");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(control, "");
                    }
                }

                if (txt_barcode.Text == "" || txt_proName.Text == "" || txt_SerialNumber.Text == "")
                {
                    MessageBox.Show("Please fill the required fields.", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if ((MessageBox.Show("Confirm Update of Product", "Confirm Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    UpdateProduct();
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

        private void UpdateProduct()
        {
            p = new Product();
            p.ProID =Convert.ToInt32(txt_proID.Text);
            p.Barcode = txt_barcode.Text;
            p.ProName = txt_proName.Text;
            p.ProCategory = category_cmbx.SelectedItem.ToString();
            p.ProBrand = brand_cmbx.SelectedItem.ToString();
            p.ProTag = txt_proTag.Text;
            p.FrontCameraPXL = txt_frontCameraPXL.Text;
            p.BackCameraPXL = txt_BankCameraPXL.Text;
            p.ScreenSize = txt_screenSize.Text;
            p.ProOS = txt_OSVerison.Text;
            p.ProRam = txt_RAM.Text;
            p.ProROM = txt_ROM.Text;
            p.SerialNumber = txt_SerialNumber.Text;
            p.OtherInfor = txt_OtherInfor.Text;
            p.DateAdded = DateTime.Now.Date;
            p.ProStatus = proStatus_cmbx.Text.ToString();

            bool res = pros.UpdateProduct(p);
            if (res)
            {
                MessageBox.Show("Sucessfully updated product with ID : " + txt_proID.Text, "Success Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Transaction t = new Transaction();
                t.UserID = this.UserID;
                t.TransQuery = "Updated Product with keys ( Barcode : " + txt_barcode.Text + "  " +
                    " and Serial Number : " + txt_SerialNumber.Text + "  and Proid : " + txt_proID.Text+ " )";
                t.Description = "insert new product with Barcode " + txt_barcode.Text;
                t.Retry = "False";
                t.TransStatus = "Completed";
                ct.NewTransaction(t);

                Clearfields();
            }
            else
            {
                MessageBox.Show("Failed to update product.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void serchByCategory_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serchByCategory_cmbx.SelectedIndex != -1)
            {
                string category = serchByCategory_cmbx.SelectedItem.ToString();
                dt = pros.SearchByCategory(category);
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
                dt = pros.SearchByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
                dgvProducts.DataSource = dt;
            }
            else
            {
                return;
            }
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            if(txt_value.Text =="")
            {
                if(searchByBrand_cmbx.SelectedIndex != -1 && serchByCategory_cmbx.SelectedIndex != -1)
                {
                    dt = pros.SearchByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
                    dgvProducts.DataSource = dt;
                }               
                return;
            }
            else
            {
                dt = pros.SearchByIDProNameandCategory(txt_value.Text);
                dgvProducts.DataSource = dt;

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
