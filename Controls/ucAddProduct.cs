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

namespace PointOfSale.Controls
{
    public partial class ucAddProduct : UserControl
    {
        ClassLoadData ldt = new ClassLoadData();
        DataTable dt;
        Product p;
        Stock s;
        Price pr;
        ClassProducts cp = new ClassProducts();
        ClassPrices cpr = new ClassPrices();
        ClassStock st = new ClassStock();
        ClassTransactions ct = new ClassTransactions();

        public string sql { get; set; }
        public int UserID  { get; set; }
        public ucAddProduct(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
            LoadBrands();
            LoadCategory();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucAddStock_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
        private void btn_save_Click(object sender, EventArgs p)
        {
            try
            {
                var controls = new[] { txt_barcode, txt_proName, txt_proTag, txt_SerialNumber };
                foreach (var control in controls)
                {
                    if(control.Text ==  "")
                    {
                        errorProvider1.SetError(control, "This field is required.");                        
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(control, "");
                    }
                }

                if(txt_barcode.Text == "" || txt_proName.Text == "" || txt_SerialNumber.Text == "")
                {
                    MessageBox.Show("Please fill the required fields.", "Warning Message.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SaveProduct();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed :" + ex.Message, "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void SaveProduct()
        {
            p = new Product();
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

            bool  res = cp.AddProducts(p);
            if(res)
            {
                bool addStock = st.AddByBarcode(txt_barcode.Text);
                if(addStock)
                {
                    bool addToPrice = cpr.AddPriceByBarcode(txt_barcode.Text, this.UserID);
                    if(addToPrice)
                    {
                        MessageBox.Show("Sucessfully added a new product.", "Success Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Transaction t = new Transaction();
                        t.UserID = this.UserID;
                        t.TransQuery = "insert into Products keys(" + txt_barcode.Text + "  and " + txt_SerialNumber.Text + ")";
                        t.Description = "insert new product with Barcode " + txt_barcode.Text;
                        t.Retry = "False";
                        t.TransStatus = "Completed";
                        ct.NewTransaction(t);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product to Selling Prices Table.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Failed to add product to Stock Table.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Clearfields();
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Failed to add a new product.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void serchByCategory_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serchByCategory_cmbx.SelectedIndex != -1)
            {
                string category = serchByCategory_cmbx.SelectedItem.ToString();
                dt = cp.SearchByCategory(category);
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
                dt =cp.SearchByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
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
                    dt = cp.SearchByBrandandCategory(searchByBrand_cmbx.SelectedItem.ToString(), serchByCategory_cmbx.SelectedItem.ToString());
                    dgvProducts.DataSource = dt;
                }
                return;
            }
            else
            {
                dt = cp.SearchByIDProNameandCategory(txt_value.Text);
                dgvProducts.DataSource = dt;

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            dt = ldt.LoadGridView("select [ProID] ,[Barcode] ,[ProName] ,[ProCategory],[ProBrand],[ProTag] from Products");
            dgvProducts.DataSource = dt;
        }

        private void LoadCategory()
        {
            category_cmbx.Items.Clear();
            serchByCategory_cmbx.Items.Clear();
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
            brand_cmbx.Items.Clear();
            searchByBrand_cmbx.Items.Clear();

            sql = " SELECT [BrName] FROM [pos].[dbo].[Brands] where BrStatus = 'Active' ";
            dt = ldt.LoadCombo(sql);
            foreach (DataRow row in dt.Rows)
            {
                string brName = row["brName"].ToString();
                brand_cmbx.Items.Add(brName);
                searchByBrand_cmbx.Items.Add(brName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_AddProCategory ac = new frm_AddProCategory(this.UserID);
            ShowForm(ac);
        }

        public void ShowForm(Form form)
        {
            form.Show();
        }

        private void btn_NewBrand_Click(object sender, EventArgs e)
        {
           frm_AddBrand ac = new frm_AddBrand(this.UserID);
            ShowForm(ac);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadBrands();
            LoadCategory();
        }
    }
}
