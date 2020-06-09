using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.CompanyConfig
{
    public partial class frm_AddCompanyInfo : Form
    {
        Company.ClassCompany com = new Company.ClassCompany();
        byte[] imgbyte;

        public frm_AddCompanyInfo()
        {
            InitializeComponent();
        }

        private void frm_AddCompanyInfo_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            bool res = com.addCompanyInfo(txt_companyName.Text, txt_email.Text, txt_phone.Text, richTxt_address.Text, imgbyte);

            if(res)
            {
                MessageBox.Show("Successfully added company details.", "Success Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add company details.", "Error Message.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image to Upload.";
                dlg.Filter = "Image File (*.jpg;*.bmp;*.gif,*.png)|*.jpg;*.bmp;*.gif;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {                   
                    try
                    {
                        String imageName = dlg.FileName;
                        Bitmap bmp = new Bitmap(imageName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = (Image)bmp;
                        FileStream fstream = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                        imgbyte = new byte[fstream.Length];
                        fstream.Read(imgbyte, 0, Convert.ToInt32(fstream.Length));
                        fstream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            /////////reading image content
            ///
            /*byte[] imagedata = (byte[])row["ProductImage"];
            MemoryStream memorystream = new MemoryStream(imagedata, 0, imagedata.Length);
            Image image = Image.FromStream(memorystream);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;*/


        }
    }
}
