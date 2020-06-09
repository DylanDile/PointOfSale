using PointOfSale.Controllers;
using PointOfSale.Models;
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
    public partial class frm_AddCustomer : Form
    {
        ClassCustomers cc = new ClassCustomers();
        DataTable dt;
        ClassLoadData ldt = new ClassLoadData();
        public frm_AddCustomer()
        {
            InitializeComponent();
            LoadGridView();
        }
        private void LoadGridView()
        {
            dt = ldt.LoadGridView("select * from Customers");
            dgvCustomers.DataSource = dt;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customerName.Text == "" ||
                    rchTxt_CustomerAddress.Text == "" || txt_customerPhone.Text == "" ||
                    txt_customerEmail.Text == "")
                {
                    MessageBox.Show("Do not leave blank spaces.!", "Warning Message.!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to add new Customer Details. ", "Question Message?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                
                    AddCustomer();
                    LoadGridView();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message : " + ex.Message, "Error Message.!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCustomer()
        {
            DataRow row = cc.SearcCustomerByName(txt_customerName.Text);
            if(row != null)
            {
                MessageBox.Show("Customer name already exists.", "Error Message.!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer c = new Customer();
            c.CustName = txt_customerName.Text;
            c.CustAddress = rchTxt_CustomerAddress.Text;
            c.CustPhone = txt_customerPhone.Text;
            c.CustEmail = txt_customerEmail.Text;
            bool res = cc.NewCustomer(c);
            if(res)
            {
                MessageBox.Show("Successfully added a new customer.", "Success Message.!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView();
                ClearAllText(this);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
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

        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
