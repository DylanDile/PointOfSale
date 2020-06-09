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
    public partial class frm_AddProCategory : Form
    {
        ClassBrandsAndCategory bnc = new ClassBrandsAndCategory();
        DataTable dt;

        public int UserID { get; set; }
        public frm_AddProCategory(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to add a new Category. ", "Question Message?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool res = bnc.AddCategory(txt_CategoryName.Text, rchtxt_CategoryDescription.Text, this.UserID);
                    if (res)
                    {
                        MessageBox.Show("Successfully added a new Category. ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClearFields()
        {
            txt_CategoryName.Text = "";
            rchtxt_CategoryDescription.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
