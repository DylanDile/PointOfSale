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
    public partial class frm_ChangePassword : Form
    {
        ClassSearch search = new ClassSearch();
        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void txt_oldPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
