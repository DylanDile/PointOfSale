﻿using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class frm_QuoteReport : Form
    {
        ClassProducts pros = new ClassProducts();
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        DataSet ds;
        Connection cn = new Connection();
        ClassEncryption enc = new ClassEncryption();
        Company.ClassCompany com = new Company.ClassCompany();

        private string customerName { get; set; }
        private string customerAddress { get; set; }
        private string customerPhone { get; set; }
        private string customerEmail { get; set; }
        private string quotationNumber { get; set; }
        public decimal subtotal { get; set; }
        public decimal discount { get; set; }
        public decimal vat  { get; set; }
        public decimal totalProductPrice { get; set; }
        public frm_QuoteReport(DataTable dataTable, string custName, string custAddress, string custPhone,
            string custEmail, string quoteNum, decimal subtotal, decimal discount, decimal vat , decimal totalPrice )
        {
            InitializeComponent();
            this.dt = dataTable;
            this.customerName = custName;
            this.customerPhone = custPhone;
            this.customerEmail = custEmail;
            this.customerAddress =custAddress;
            this.quotationNumber = quoteNum;
            this.subtotal = subtotal;
            this.discount = discount;
            this.vat = vat;
            this.totalProductPrice = totalPrice;
        }

        private Decimal ProductsTotal()
        {
            DataTable dataTable = this.dt;
            decimal totalPrice  = 0.00m;
            foreach (DataRow row in dataTable.Rows)
            {
                decimal price = Convert.ToDecimal( row["Total Price"].ToString());
                totalPrice += price;
            }
            return totalPrice;
        }
        private void frm_QuoteReport_Load(object sender, EventArgs e)
        {
            string expDate = DateTime.Now.Date.AddDays(10).ToString("dd/MM/yyyy");            

            DataRow companyInfo = com.getCompanyInfo();
            string comEmail = companyInfo["ccEmail"].ToString();
            string comPhone = companyInfo["ccPhone"].ToString();
            string comAddress = companyInfo["ccAddress"].ToString();

            DataTable dataTable = com.DataForGrid("select top 1 * from [CompanyBranch] where brStatus = 'working' ");
            DataRow branchInfor = dataTable.Rows[0];
            string branchName = branchInfor["brName"].ToString();
            string branchCode = branchInfor["brCode"].ToString();
            string branchAddress = branchInfor["brAddress"].ToString();

            
            ParameterFields data = new ParameterFields();

            //customer details 
            ParameterField PID = new ParameterField();
            ParameterField address = new ParameterField();
            ParameterField phone = new ParameterField();
            ParameterField email = new ParameterField();

            //company details
            ParameterField ccEmail = new ParameterField();
            ParameterField ccPhone = new ParameterField();
            ParameterField ccAddress = new ParameterField();

            //branch details
            ParameterField brName = new ParameterField();
            ParameterField brCode = new ParameterField();
            ParameterField brAddress = new ParameterField();

            //quotation code
            ParameterField expiryDate = new ParameterField();
            ParameterField quoteNumber = new ParameterField();

            //amounts
            ParameterField parSubtotal = new ParameterField();
            ParameterField parDiscount = new ParameterField();
            ParameterField parVat = new ParameterField();
            ParameterField parTotalPrice = new ParameterField();

            //aligning with parameter fields at the report 
            //customer
            PID.Name = "customerName";
            address.Name = "customerAddress";
            phone.Name = "customerPhone";
            email.Name = "customerEmail";

            //company
            ccEmail.Name = "companyEmail";
            ccPhone.Name = "companyPhone";
            ccAddress.Name = "companyAddress";

            //branch
            brName.Name = "branchName";
            brCode.Name = "branchCode";
            brAddress.Name = "branchAddress";

            //quotation code and epxiry date
            expiryDate.Name = "expiryDate";
            quoteNumber.Name = "quotationNumber";

            //amounts
            parSubtotal.Name = "subTotal";
            parDiscount.Name = "discount";
            parVat.Name = "vat";
            parTotalPrice.Name = "totalGoodsPrice";

            //exact values for customer details
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            ParameterDiscreteValue val1 = new ParameterDiscreteValue();
            ParameterDiscreteValue val2 = new ParameterDiscreteValue();
            ParameterDiscreteValue val3 = new ParameterDiscreteValue();

            //exact values for company details
            ParameterDiscreteValue valComEmail = new ParameterDiscreteValue();
            ParameterDiscreteValue valComPhone = new ParameterDiscreteValue();
            ParameterDiscreteValue valComAddress = new ParameterDiscreteValue();

            //exact values for branch details
            ParameterDiscreteValue valBrName = new ParameterDiscreteValue();
            ParameterDiscreteValue valBrCode = new ParameterDiscreteValue();
            ParameterDiscreteValue valBrAddress = new ParameterDiscreteValue();

            //exact values for quotation number
            ParameterDiscreteValue valQuoteNumber = new ParameterDiscreteValue();
            ParameterDiscreteValue valExpiryDate = new ParameterDiscreteValue();

            //discrete values
            ParameterDiscreteValue valSubtotal = new ParameterDiscreteValue();
            ParameterDiscreteValue valDiscount = new ParameterDiscreteValue();
            ParameterDiscreteValue valVat = new ParameterDiscreteValue();
            ParameterDiscreteValue valTotalPrice = new ParameterDiscreteValue();

            //aisgning customer values
            val.Value = this.customerName;
            val1.Value = this.customerAddress;
            val2.Value = this.customerPhone;
            val3.Value = this.customerEmail;

            //asigning company details
            valComEmail.Value = comEmail;
            valComPhone.Value = comPhone;
            valComAddress.Value = comAddress;

            //asigning branch details
            valBrName.Value = branchName;
            valBrCode.Value = branchCode;
            valBrAddress.Value = branchAddress;

            //asigning values to quote number and expiry date
            valQuoteNumber.Value = this.quotationNumber;
            valExpiryDate.Value = expDate;

            //asigning amounts
            valSubtotal.Value = this.subtotal;
            valDiscount.Value = this.discount;
            valVat.Value = this.vat;
            valTotalPrice.Value = this.totalProductPrice;

            //adding customer values to the destined ids
            PID.CurrentValues.Add(val);
            address.CurrentValues.Add(val1);
            phone.CurrentValues.Add(val2);
            email.CurrentValues.Add(val3);

            //adding company details
            ccEmail.CurrentValues.Add(valComEmail);
            ccAddress.CurrentValues.Add(valComAddress);
            ccPhone.CurrentValues.Add(valComPhone);

            //adding branch details
            brName.CurrentValues.Add(valBrName);
            brAddress.CurrentValues.Add(valBrAddress);
            brCode.CurrentValues.Add(valBrCode);

            //adding quoteNumber and expiry date
            quoteNumber.CurrentValues.Add(valQuoteNumber);
            expiryDate.CurrentValues.Add(valExpiryDate);

            //adding values to the parametes
            parSubtotal.CurrentValues.Add(valSubtotal);
            parDiscount.CurrentValues.Add(valDiscount);
            parVat.CurrentValues.Add(valVat);
            parTotalPrice.CurrentValues.Add(valTotalPrice);

            data.Add(PID);
            data.Add(address);
            data.Add(phone);
            data.Add(email);

            data.Add(ccEmail);
            data.Add(ccAddress);
            data.Add(ccPhone);

            data.Add(brName);
            data.Add(brAddress);
            data.Add(brCode);

            data.Add(quoteNumber);
            data.Add(expiryDate);

            data.Add(parSubtotal);
            data.Add(parDiscount);
            data.Add(parVat);
            data.Add(parTotalPrice);

            crystalReportQuotation.ParameterFieldInfo = data;

            DataTable dataTb = this.dt;
            dataTb.TableName = "tbl_quotation";

            All_Reports.crptQuotation rpt = new All_Reports.crptQuotation();
            rpt.Database.Tables["tbl_quotation"].SetDataSource(dataTb);
            crystalReportQuotation.ReportSource = null;
            crystalReportQuotation.ReportSource = rpt;            
        }
    }
}
