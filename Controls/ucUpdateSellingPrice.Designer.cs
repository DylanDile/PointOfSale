namespace PointOfSale.Controls
{
    partial class ucUpdateSellingPrice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.searchByBrand_cmbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serchByCategory_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_SellingPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_proID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txt_currentPrice = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.txt_value);
            this.panel2.Controls.Add(this.searchByBrand_cmbx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.serchByCategory_cmbx);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(478, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 65);
            this.panel2.TabIndex = 76;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = global::PointOfSale.Properties.Resources.icons8_Refresh_50px_1;
            this.btn_refresh.Location = new System.Drawing.Point(772, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(59, 55);
            this.btn_refresh.TabIndex = 71;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(429, 14);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(337, 23);
            this.txt_value.TabIndex = 75;
            this.txt_value.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // searchByBrand_cmbx
            // 
            this.searchByBrand_cmbx.FormattingEnabled = true;
            this.searchByBrand_cmbx.Location = new System.Drawing.Point(292, 14);
            this.searchByBrand_cmbx.Name = "searchByBrand_cmbx";
            this.searchByBrand_cmbx.Size = new System.Drawing.Size(131, 24);
            this.searchByBrand_cmbx.TabIndex = 74;
            this.searchByBrand_cmbx.SelectedIndexChanged += new System.EventHandler(this.searchByBrand_cmbx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Category :";
            // 
            // serchByCategory_cmbx
            // 
            this.serchByCategory_cmbx.FormattingEnabled = true;
            this.serchByCategory_cmbx.Location = new System.Drawing.Point(97, 16);
            this.serchByCategory_cmbx.Name = "serchByCategory_cmbx";
            this.serchByCategory_cmbx.Size = new System.Drawing.Size(128, 24);
            this.serchByCategory_cmbx.TabIndex = 71;
            this.serchByCategory_cmbx.SelectedIndexChanged += new System.EventHandler(this.serchByCategory_cmbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "All Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(478, 172);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(860, 507);
            this.dgvProducts.TabIndex = 74;
            this.dgvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProducts_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 68);
            this.panel1.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(521, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Update Products Prices";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_productName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_proID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Scan);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 556);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Stock";
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(125, 102);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(315, 23);
            this.txt_productName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_currentPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_SellingPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 366);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(124, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "(Enter received selling price)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(103, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(203, 127);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Olive;
            this.btn_clear.Location = new System.Drawing.Point(33, 71);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(149, 39);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 2;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_save.Location = new System.Drawing.Point(33, 24);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(149, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Update Price";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_SellingPrice
            // 
            this.txt_SellingPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SellingPrice.Location = new System.Drawing.Point(127, 141);
            this.txt_SellingPrice.Name = "txt_SellingPrice";
            this.txt_SellingPrice.Size = new System.Drawing.Size(158, 29);
            this.txt_SellingPrice.TabIndex = 1;
            this.txt_SellingPrice.TextChanged += new System.EventHandler(this.txt_SellingPrice_TextChanged);
            this.txt_SellingPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SellingPrice_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price  :";
            // 
            // txt_proID
            // 
            this.txt_proID.Location = new System.Drawing.Point(100, 23);
            this.txt_proID.Name = "txt_proID";
            this.txt_proID.Size = new System.Drawing.Size(143, 23);
            this.txt_proID.TabIndex = 20;
            this.txt_proID.TextChanged += new System.EventHandler(this.txt_proID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product ID:";
            // 
            // btn_Scan
            // 
            this.btn_Scan.BackColor = System.Drawing.Color.Silver;
            this.btn_Scan.FlatAppearance.BorderSize = 0;
            this.btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scan.Image = global::PointOfSale.Properties.Resources.icons8_Barcode_Reader_50px;
            this.btn_Scan.Location = new System.Drawing.Point(324, 36);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(60, 55);
            this.btn_Scan.TabIndex = 18;
            this.btn_Scan.UseVisualStyleBackColor = false;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(92, 53);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(226, 23);
            this.txt_barcode.TabIndex = 1;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Current Price : ";
            // 
            // txt_currentPrice
            // 
            this.txt_currentPrice.AutoSize = true;
            this.txt_currentPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentPrice.ForeColor = System.Drawing.Color.Red;
            this.txt_currentPrice.Location = new System.Drawing.Point(174, 61);
            this.txt_currentPrice.Name = "txt_currentPrice";
            this.txt_currentPrice.Size = new System.Drawing.Size(123, 23);
            this.txt_currentPrice.TabIndex = 13;
            this.txt_currentPrice.Text = "CurrentPrice";
            // 
            // ucUpdateSellingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucUpdateSellingPrice";
            this.Size = new System.Drawing.Size(1343, 694);
            this.Load += new System.EventHandler(this.ucUpdateSellingPrice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.ComboBox searchByBrand_cmbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serchByCategory_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_SellingPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_proID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label txt_currentPrice;
        private System.Windows.Forms.Label label10;
    }
}
