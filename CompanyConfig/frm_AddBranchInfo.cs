using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.CompanyConfig
{
    public partial class frm_AddBranchInfo : Form
    {
        Company.ClassCompany com = new Company.ClassCompany();
        public frm_AddBranchInfo()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataTable dt = com.getBranchInfo();
            foreach(DataRow row in dt.Rows)
            {
                string brCode = row["brCode"].ToString();
                string brName = row["brName"].ToString();

                if (brCode == txt_branchCode.Text)
                {
                    MessageBox.Show("Branch Code already exists.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool res = com.addBranchInfo(txt_branchName.Text, richTxt_address.Text, txt_branchCode.Text);
            if (res)
            {
                MessageBox.Show("Successfully added branch details.", "Success Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clearfields();
                loadGrid();
            }
            else
            {
                MessageBox.Show("Failed to add branch details.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clearfields();
        }

        private void Clearfields()
        {
            txt_branchCode.Text = "";
            txt_branchName.Text = "";
            richTxt_address.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frm_AddBranchInfo_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void loadGrid()
        {
            DataTable dataTable = com.DataForGrid("select * from [CompanyBranch]");
            dgvBranches.DataSource = dataTable;
        }
    }
}
