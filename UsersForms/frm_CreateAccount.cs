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
    public partial class frm_CreateAccount : Form
    {
        ClassInserts ins = new ClassInserts();
        ClassSearch search = new ClassSearch();
        public frm_CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (search.searchUser(txt_usename.Text))
                {
                    MessageBox.Show("Username already exists pick another one.!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbx_occupation.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select your occupation please.!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_name.Text == "" || txt_surname.Text == "" || txt_usename.Text == "" || txt_password.Text == "" || txt_confirmPass.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks.!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //now record user 
                bool res = ins.AddUser(txt_ecNumber.Text, txt_name.Text, txt_surname.Text, txt_usename.Text, cmbx_occupation.SelectedItem.ToString(), txt_password.Text);
                if (res)
                {
                    MessageBox.Show("Successfully created an account for : ." + txt_usename.Text.Trim(), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message => : " + ex.Message, "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if(txt_name.Text == "")
            {
                errorProvider1.SetError(txt_name, "name is required please");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login lg = new frm_login();
            lg.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_usename.Text = "";
            txt_password.Text = "";
            txt_confirmPass.Text = "";
        }

        private void frm_CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
