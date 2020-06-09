using PointOfSale.Controllers;
using PointOfSale.Controls;
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

namespace PointOfSale
{
    public partial class frm_login : Form
    {
        ClassSelects sel = new ClassSelects();
        ClassUsers uc = new ClassUsers();
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            

        }

         private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar == false)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else if (txt_password.UseSystemPasswordChar == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txt_username.Text == "" || txt_password.Text == "")
                {
                    MessageBox.Show("Fill in the details please.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (sel.login(txt_username.Text.Trim(), txt_password.Text.Trim()))
                {
                    MessageBox.Show("Successfully logged in with user : ." + txt_username.Text.Trim(), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int userid = uc.UserID(txt_username.Text);
                    Main_Menu mm = new Main_Menu(userid);
                    this.Hide();
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username of password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to login.", "Error Message : =>  " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_CreateAccount cacc = new frm_CreateAccount();
            cacc.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar == false)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else if (txt_password.UseSystemPasswordChar == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDFPrints pDFPrints = new PDFPrints();
            pDFPrints.AnotherTest();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserModel um = new UserModel();
            um.loggedUser = txt_username.Text;

            MessageBox.Show(um.loggedUser);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UserModel um = new UserModel();
            um.loggedUser = txt_username.Text;

            MessageBox.Show(um.loggedUser);

            ClassUsers cu = new ClassUsers();
            int id = cu.UserID(um.loggedUser);
            MessageBox.Show(id.ToString());

        }
    }
}
