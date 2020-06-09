using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Controls
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            chart1.Titles.Add("Invoices Chart");
            chart1.Series["s1"].Points.AddXY("1", "26");
            chart1.Series["s1"].Points.AddXY("2", "54");
            chart1.Series["s1"].Points.AddXY("3", "21");
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
