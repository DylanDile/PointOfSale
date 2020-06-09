namespace PointOfSale.Controls
{
    partial class ucPrintInvoices
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_RemoveSelected = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_customerNme = new System.Windows.Forms.TextBox();
            this.btn_SelectCustomer = new System.Windows.Forms.Button();
            this.customersNames_cmbx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_recordSale = new System.Windows.Forms.Button();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_vatAmount = new System.Windows.Forms.TextBox();
            this.txt_totalProductsPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_void = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_proName = new System.Windows.Forms.TextBox();
            this.txt_proPrice = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_ScanProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.productList_cmbx = new System.Windows.Forms.ComboBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_proid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_availableStock = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_discountAmnt = new System.Windows.Forms.TextBox();
            this.chckBox_Discount = new System.Windows.Forms.CheckBox();
            this.checkBx_vatAmount = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.btn_RemoveSelected);
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Location = new System.Drawing.Point(4, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(838, 580);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Order";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::PointOfSale.Properties.Resources.icons8_Update_28px_2;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(628, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(201, 44);
            this.button8.TabIndex = 8;
            this.button8.Text = "Update Selected";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_RemoveSelected
            // 
            this.btn_RemoveSelected.BackColor = System.Drawing.Color.Red;
            this.btn_RemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveSelected.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveSelected.Image = global::PointOfSale.Properties.Resources.icons8_Cancel_28px_2;
            this.btn_RemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RemoveSelected.Location = new System.Drawing.Point(417, 6);
            this.btn_RemoveSelected.Name = "btn_RemoveSelected";
            this.btn_RemoveSelected.Size = new System.Drawing.Size(205, 43);
            this.btn_RemoveSelected.TabIndex = 7;
            this.btn_RemoveSelected.Text = "Remove Selected";
            this.btn_RemoveSelected.UseVisualStyleBackColor = false;
            this.btn_RemoveSelected.Click += new System.EventHandler(this.btn_RemoveSelected_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToOrderColumns = true;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(9, 56);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(821, 500);
            this.dgvOrder.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(550, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Print Invoices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 46);
            this.panel1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txt_customerNme);
            this.groupBox3.Controls.Add(this.btn_SelectCustomer);
            this.groupBox3.Controls.Add(this.customersNames_cmbx);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Details";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::PointOfSale.Properties.Resources.icons8_Synchronize_28px1;
            this.button4.Location = new System.Drawing.Point(774, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 31);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::PointOfSale.Properties.Resources.icons8_New_28px_1;
            this.button3.Location = new System.Drawing.Point(708, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 31);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_customerNme
            // 
            this.txt_customerNme.Location = new System.Drawing.Point(360, 24);
            this.txt_customerNme.Name = "txt_customerNme";
            this.txt_customerNme.ReadOnly = true;
            this.txt_customerNme.Size = new System.Drawing.Size(342, 27);
            this.txt_customerNme.TabIndex = 3;
            // 
            // btn_SelectCustomer
            // 
            this.btn_SelectCustomer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_SelectCustomer.FlatAppearance.BorderSize = 2;
            this.btn_SelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectCustomer.ForeColor = System.Drawing.Color.Green;
            this.btn_SelectCustomer.Image = global::PointOfSale.Properties.Resources.icons8_Add_User_Male_16px;
            this.btn_SelectCustomer.Location = new System.Drawing.Point(314, 24);
            this.btn_SelectCustomer.Name = "btn_SelectCustomer";
            this.btn_SelectCustomer.Size = new System.Drawing.Size(40, 27);
            this.btn_SelectCustomer.TabIndex = 2;
            this.btn_SelectCustomer.UseVisualStyleBackColor = false;
            this.btn_SelectCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // customersNames_cmbx
            // 
            this.customersNames_cmbx.FormattingEnabled = true;
            this.customersNames_cmbx.Location = new System.Drawing.Point(87, 24);
            this.customersNames_cmbx.Name = "customersNames_cmbx";
            this.customersNames_cmbx.Size = new System.Drawing.Size(220, 27);
            this.customersNames_cmbx.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(131, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "VAT Amount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Sub Total :";
            // 
            // btn_recordSale
            // 
            this.btn_recordSale.BackColor = System.Drawing.Color.Teal;
            this.btn_recordSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recordSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recordSale.ForeColor = System.Drawing.Color.White;
            this.btn_recordSale.Image = global::PointOfSale.Properties.Resources.icons8_Print_28px;
            this.btn_recordSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recordSale.Location = new System.Drawing.Point(7, 588);
            this.btn_recordSale.Margin = new System.Windows.Forms.Padding(4);
            this.btn_recordSale.Name = "btn_recordSale";
            this.btn_recordSale.Size = new System.Drawing.Size(124, 50);
            this.btn_recordSale.TabIndex = 24;
            this.btn_recordSale.Text = "Print";
            this.btn_recordSale.UseVisualStyleBackColor = false;
            this.btn_recordSale.Click += new System.EventHandler(this.btn_recordSale_Click);
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(244, 375);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(156, 27);
            this.txt_subtotal.TabIndex = 28;
            this.txt_subtotal.Text = "0.00";
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_subtotal.TextChanged += new System.EventHandler(this.txt_subtotal_TextChanged);
            // 
            // txt_vatAmount
            // 
            this.txt_vatAmount.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vatAmount.ForeColor = System.Drawing.Color.Red;
            this.txt_vatAmount.Location = new System.Drawing.Point(306, 408);
            this.txt_vatAmount.Name = "txt_vatAmount";
            this.txt_vatAmount.ReadOnly = true;
            this.txt_vatAmount.Size = new System.Drawing.Size(94, 22);
            this.txt_vatAmount.TabIndex = 29;
            this.txt_vatAmount.Text = "0.00";
            this.txt_vatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_vatAmount.TextChanged += new System.EventHandler(this.txt_vatAmount_TextChanged);
            // 
            // txt_totalProductsPrice
            // 
            this.txt_totalProductsPrice.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalProductsPrice.ForeColor = System.Drawing.Color.Blue;
            this.txt_totalProductsPrice.Location = new System.Drawing.Point(244, 473);
            this.txt_totalProductsPrice.Name = "txt_totalProductsPrice";
            this.txt_totalProductsPrice.ReadOnly = true;
            this.txt_totalProductsPrice.Size = new System.Drawing.Size(156, 29);
            this.txt_totalProductsPrice.TabIndex = 30;
            this.txt_totalProductsPrice.Text = "0.00";
            this.txt_totalProductsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(141, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Total Price :";
            // 
            // btn_void
            // 
            this.btn_void.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_void.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_void.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_void.ForeColor = System.Drawing.Color.White;
            this.btn_void.Image = global::PointOfSale.Properties.Resources.icons8_Close_Window_28px_1;
            this.btn_void.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_void.Location = new System.Drawing.Point(134, 588);
            this.btn_void.Margin = new System.Windows.Forms.Padding(4);
            this.btn_void.Name = "btn_void";
            this.btn_void.Size = new System.Drawing.Size(124, 50);
            this.btn_void.TabIndex = 32;
            this.btn_void.Text = "Void";
            this.btn_void.UseVisualStyleBackColor = false;
            this.btn_void.Click += new System.EventHandler(this.btn_void_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_availableStock);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_proid);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_addToCart);
            this.groupBox2.Controls.Add(this.btn_addProduct);
            this.groupBox2.Controls.Add(this.productList_cmbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_ScanProduct);
            this.groupBox2.Controls.Add(this.txt_quantity);
            this.groupBox2.Controls.Add(this.txt_proPrice);
            this.groupBox2.Controls.Add(this.txt_proName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_barcode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(495, 305);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan : ";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(73, 89);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(230, 29);
            this.txt_barcode.TabIndex = 1;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit Price :";
            // 
            // txt_proName
            // 
            this.txt_proName.Location = new System.Drawing.Point(106, 171);
            this.txt_proName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_proName.Name = "txt_proName";
            this.txt_proName.ReadOnly = true;
            this.txt_proName.Size = new System.Drawing.Size(348, 27);
            this.txt_proName.TabIndex = 5;
            // 
            // txt_proPrice
            // 
            this.txt_proPrice.Location = new System.Drawing.Point(106, 207);
            this.txt_proPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_proPrice.Name = "txt_proPrice";
            this.txt_proPrice.ReadOnly = true;
            this.txt_proPrice.Size = new System.Drawing.Size(119, 27);
            this.txt_proPrice.TabIndex = 6;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(106, 242);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(119, 50);
            this.txt_quantity.TabIndex = 7;
            this.txt_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.txt_quantity_Validating);
            // 
            // btn_ScanProduct
            // 
            this.btn_ScanProduct.FlatAppearance.BorderSize = 0;
            this.btn_ScanProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ScanProduct.Image = global::PointOfSale.Properties.Resources.icons8_Barcode_Reader_50px;
            this.btn_ScanProduct.Location = new System.Drawing.Point(310, 84);
            this.btn_ScanProduct.Name = "btn_ScanProduct";
            this.btn_ScanProduct.Size = new System.Drawing.Size(75, 55);
            this.btn_ScanProduct.TabIndex = 8;
            this.btn_ScanProduct.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search Product : ";
            // 
            // productList_cmbx
            // 
            this.productList_cmbx.FormattingEnabled = true;
            this.productList_cmbx.Location = new System.Drawing.Point(15, 49);
            this.productList_cmbx.Name = "productList_cmbx";
            this.productList_cmbx.Size = new System.Drawing.Size(366, 29);
            this.productList_cmbx.TabIndex = 10;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Image = global::PointOfSale.Properties.Resources.icons8_Add_28px_1;
            this.btn_addProduct.Location = new System.Drawing.Point(387, 43);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(31, 35);
            this.btn_addProduct.TabIndex = 11;
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addToCart.FlatAppearance.BorderSize = 2;
            this.btn_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.ForeColor = System.Drawing.Color.White;
            this.btn_addToCart.Image = global::PointOfSale.Properties.Resources.icons8_Add_Shopping_Cart_28px;
            this.btn_addToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addToCart.Location = new System.Drawing.Point(330, 242);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(147, 48);
            this.btn_addToCart.TabIndex = 12;
            this.btn_addToCart.Text = " add to cart";
            this.btn_addToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addToCart.UseVisualStyleBackColor = false;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "ProID : ";
            // 
            // txt_proid
            // 
            this.txt_proid.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proid.Location = new System.Drawing.Point(77, 127);
            this.txt_proid.Name = "txt_proid";
            this.txt_proid.Size = new System.Drawing.Size(124, 29);
            this.txt_proid.TabIndex = 14;
            this.txt_proid.TextChanged += new System.EventHandler(this.txt_proid_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(237, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Available Stock :";
            // 
            // txt_availableStock
            // 
            this.txt_availableStock.Location = new System.Drawing.Point(349, 205);
            this.txt_availableStock.Name = "txt_availableStock";
            this.txt_availableStock.ReadOnly = true;
            this.txt_availableStock.Size = new System.Drawing.Size(105, 27);
            this.txt_availableStock.TabIndex = 16;
            this.txt_availableStock.TextChanged += new System.EventHandler(this.txt_availableStock_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PointOfSale.Properties.Resources.icons8_Clear_Filters_28px_11;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(265, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 37;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(103, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Discount Amount :";
            // 
            // txt_discountAmnt
            // 
            this.txt_discountAmnt.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discountAmnt.ForeColor = System.Drawing.Color.Red;
            this.txt_discountAmnt.Location = new System.Drawing.Point(306, 443);
            this.txt_discountAmnt.Name = "txt_discountAmnt";
            this.txt_discountAmnt.ReadOnly = true;
            this.txt_discountAmnt.Size = new System.Drawing.Size(94, 22);
            this.txt_discountAmnt.TabIndex = 40;
            this.txt_discountAmnt.Text = "0.00";
            this.txt_discountAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_discountAmnt.TextChanged += new System.EventHandler(this.txt_discountAmnt_TextChanged);
            // 
            // chckBox_Discount
            // 
            this.chckBox_Discount.AutoSize = true;
            this.chckBox_Discount.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBox_Discount.ForeColor = System.Drawing.Color.Blue;
            this.chckBox_Discount.Location = new System.Drawing.Point(244, 445);
            this.chckBox_Discount.Name = "chckBox_Discount";
            this.chckBox_Discount.Size = new System.Drawing.Size(51, 20);
            this.chckBox_Discount.TabIndex = 41;
            this.chckBox_Discount.Text = "Tick";
            this.chckBox_Discount.UseVisualStyleBackColor = true;
            this.chckBox_Discount.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBx_vatAmount
            // 
            this.checkBx_vatAmount.AutoSize = true;
            this.checkBx_vatAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBx_vatAmount.ForeColor = System.Drawing.Color.Blue;
            this.checkBx_vatAmount.Location = new System.Drawing.Point(244, 410);
            this.checkBx_vatAmount.Name = "checkBx_vatAmount";
            this.checkBx_vatAmount.Size = new System.Drawing.Size(51, 20);
            this.checkBx_vatAmount.TabIndex = 43;
            this.checkBx_vatAmount.Text = "Tick";
            this.checkBx_vatAmount.UseVisualStyleBackColor = true;
            this.checkBx_vatAmount.CheckedChanged += new System.EventHandler(this.checkBx_vatAmount_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(164, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 19);
            this.label16.TabIndex = 44;
            this.label16.Text = "Base Currency : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(302, 325);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 19);
            this.label19.TabIndex = 48;
            this.label19.Text = "USD";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.checkBx_vatAmount);
            this.panel2.Controls.Add(this.chckBox_Discount);
            this.panel2.Controls.Add(this.txt_discountAmnt);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btn_void);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_totalProductsPrice);
            this.panel2.Controls.Add(this.txt_vatAmount);
            this.panel2.Controls.Add(this.txt_subtotal);
            this.panel2.Controls.Add(this.btn_recordSale);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(849, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 646);
            this.panel2.TabIndex = 17;
            // 
            // ucPrintInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPrintInvoices";
            this.Size = new System.Drawing.Size(1360, 714);
            this.Load += new System.EventHandler(this.ucPrintInvoices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_RemoveSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_SelectCustomer;
        private System.Windows.Forms.ComboBox customersNames_cmbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_customerNme;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_recordSale;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_vatAmount;
        private System.Windows.Forms.TextBox txt_totalProductsPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_void;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_availableStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_proid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.ComboBox productList_cmbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ScanProduct;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_proPrice;
        private System.Windows.Forms.TextBox txt_proName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_discountAmnt;
        private System.Windows.Forms.CheckBox chckBox_Discount;
        private System.Windows.Forms.CheckBox checkBx_vatAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
    }
}
