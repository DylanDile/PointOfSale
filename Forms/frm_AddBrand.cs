using PointOfSale.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Forms
{
    public partial class frm_AddBrand : Form
    {
        ClassBrandsAndCategory bnc = new ClassBrandsAndCategory();
        DataTable dt;

        public int UserID { get; set; }
        public frm_AddBrand(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add a new Brand. ", "Question Message?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bool res = bnc.AddBrand(txt_brandName.Text, rchtxt_BrandDescription.Text, this.UserID);
                    if (res)
                    {
                        MessageBox.Show("Successfully added a new Brand. ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
           
        }
        public void ClearFields()
        {
            txt_brandName.Text = "";
            rchtxt_BrandDescription.Text = "";
        }
    }
}
