namespace PointOfSale.Controls
{
    partial class ucAddProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.searchByBrand_cmbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serchByCategory_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_SerialNumber = new System.Windows.Forms.TextBox();
            this.txt_ROM = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_RAM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_OSVerison = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_screenSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_BankCameraPXL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_frontCameraPXL = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_OtherInfor = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.brand_cmbx = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_proName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.category_cmbx = new System.Windows.Forms.ComboBox();
            this.txt_proTag = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_NewBrand = new System.Windows.Forms.Button();
            this.btn_NewCategory = new System.Windows.Forms.Button();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Location = new System.Drawing.Point(4, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1375, 647);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill the details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1293, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "Refresh";
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
            this.panel2.Location = new System.Drawing.Point(584, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 65);
            this.panel2.TabIndex = 74;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(429, 14);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(270, 23);
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
            this.label2.Location = new System.Drawing.Point(907, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Added Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(584, 116);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(784, 480);
            this.dgvProducts.TabIndex = 72;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txt_OtherInfor);
            this.groupBox6.Location = new System.Drawing.Point(7, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(571, 414);
            this.groupBox6.TabIndex = 67;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Specs";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_SerialNumber);
            this.groupBox5.Controls.Add(this.txt_ROM);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txt_RAM);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(15, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 162);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Storage and Processor";
            // 
            // txt_SerialNumber
            // 
            this.txt_SerialNumber.Location = new System.Drawing.Point(14, 122);
            this.txt_SerialNumber.Name = "txt_SerialNumber";
            this.txt_SerialNumber.Size = new System.Drawing.Size(281, 23);
            this.txt_SerialNumber.TabIndex = 47;
            // 
            // txt_ROM
            // 
            this.txt_ROM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ROM.Location = new System.Drawing.Point(59, 55);
            this.txt_ROM.MaxLength = 50;
            this.txt_ROM.Name = "txt_ROM";
            this.txt_ROM.Size = new System.Drawing.Size(165, 23);
            this.txt_ROM.TabIndex = 45;
            this.txt_ROM.Tag = "Please enter Firstname";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "ROM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 18);
            this.label15.TabIndex = 40;
            this.label15.Text = "Serail Number :";
            // 
            // txt_RAM
            // 
            this.txt_RAM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RAM.Location = new System.Drawing.Point(59, 22);
            this.txt_RAM.MaxLength = 50;
            this.txt_RAM.Name = "txt_RAM";
            this.txt_RAM.Size = new System.Drawing.Size(165, 23);
            this.txt_RAM.TabIndex = 41;
            this.txt_RAM.Tag = "Please enter Firstname";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "RAM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_OSVerison);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_screenSize);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(328, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 172);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display and Version";
            // 
            // txt_OSVerison
            // 
            this.txt_OSVerison.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OSVerison.Location = new System.Drawing.Point(13, 117);
            this.txt_OSVerison.MaxLength = 50;
            this.txt_OSVerison.Name = "txt_OSVerison";
            this.txt_OSVerison.Size = new System.Drawing.Size(206, 23);
            this.txt_OSVerison.TabIndex = 44;
            this.txt_OSVerison.Tag = "Please enter Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "OS version";
            // 
            // txt_screenSize
            // 
            this.txt_screenSize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_screenSize.Location = new System.Drawing.Point(16, 45);
            this.txt_screenSize.MaxLength = 50;
            this.txt_screenSize.Name = "txt_screenSize";
            this.txt_screenSize.Size = new System.Drawing.Size(158, 23);
            this.txt_screenSize.TabIndex = 41;
            this.txt_screenSize.Tag = "Please enter Firstname";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Screen Size (inches)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(356, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(203, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
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
            this.btn_save.Location = new System.Drawing.Point(33, 24);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(149, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_BankCameraPXL);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_frontCameraPXL);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 97);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // txt_BankCameraPXL
            // 
            this.txt_BankCameraPXL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BankCameraPXL.Location = new System.Drawing.Point(181, 57);
            this.txt_BankCameraPXL.MaxLength = 50;
            this.txt_BankCameraPXL.Name = "txt_BankCameraPXL";
            this.txt_BankCameraPXL.Size = new System.Drawing.Size(112, 23);
            this.txt_BankCameraPXL.TabIndex = 44;
            this.txt_BankCameraPXL.Tag = "Please enter Surname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Back Camera (pixels)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Front Camera (pixels)";
            // 
            // txt_frontCameraPXL
            // 
            this.txt_frontCameraPXL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_frontCameraPXL.Location = new System.Drawing.Point(181, 20);
            this.txt_frontCameraPXL.MaxLength = 50;
            this.txt_frontCameraPXL.Name = "txt_frontCameraPXL";
            this.txt_frontCameraPXL.Size = new System.Drawing.Size(112, 23);
            this.txt_frontCameraPXL.TabIndex = 41;
            this.txt_frontCameraPXL.Tag = "Please enter Firstname";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 20);
            this.label17.TabIndex = 62;
            this.label17.Text = "Other information";
            // 
            // txt_OtherInfor
            // 
            this.txt_OtherInfor.Location = new System.Drawing.Point(10, 318);
            this.txt_OtherInfor.Name = "txt_OtherInfor";
            this.txt_OtherInfor.Size = new System.Drawing.Size(337, 85);
            this.txt_OtherInfor.TabIndex = 61;
            this.txt_OtherInfor.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.btn_NewBrand);
            this.groupBox7.Controls.Add(this.btn_NewCategory);
            this.groupBox7.Controls.Add(this.btn_Scan);
            this.groupBox7.Controls.Add(this.txt_barcode);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.brand_cmbx);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.txt_proName);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.category_cmbx);
            this.groupBox7.Controls.Add(this.txt_proTag);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(7, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(571, 193);
            this.groupBox7.TabIndex = 66;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Details";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(90, 24);
            this.txt_barcode.MaxLength = 50;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(281, 27);
            this.txt_barcode.TabIndex = 41;
            this.txt_barcode.Tag = "Please enter Firstname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Brand :";
            // 
            // brand_cmbx
            // 
            this.brand_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brand_cmbx.FormattingEnabled = true;
            this.brand_cmbx.Location = new System.Drawing.Point(342, 57);
            this.brand_cmbx.Name = "brand_cmbx";
            this.brand_cmbx.Size = new System.Drawing.Size(168, 24);
            this.brand_cmbx.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Wheat;
            this.button2.Location = new System.Drawing.Point(377, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_proName
            // 
            this.txt_proName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proName.Location = new System.Drawing.Point(122, 124);
            this.txt_proName.MaxLength = 50;
            this.txt_proName.Name = "txt_proName";
            this.txt_proName.Size = new System.Drawing.Size(309, 27);
            this.txt_proName.TabIndex = 44;
            this.txt_proName.Tag = "Please enter Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Category :";
            // 
            // category_cmbx
            // 
            this.category_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_cmbx.FormattingEnabled = true;
            this.category_cmbx.Location = new System.Drawing.Point(90, 57);
            this.category_cmbx.Name = "category_cmbx";
            this.category_cmbx.Size = new System.Drawing.Size(185, 24);
            this.category_cmbx.TabIndex = 12;
            // 
            // txt_proTag
            // 
            this.txt_proTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proTag.Location = new System.Drawing.Point(122, 157);
            this.txt_proTag.MaxLength = 10;
            this.txt_proTag.Name = "txt_proTag";
            this.txt_proTag.Size = new System.Drawing.Size(217, 27);
            this.txt_proTag.TabIndex = 48;
            this.txt_proTag.Tag = "Please enter EC number";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 20);
            this.label20.TabIndex = 45;
            this.label20.Text = "Barcode";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(2, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 20);
            this.label22.TabIndex = 47;
            this.label22.Text = "Product Tag";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 20);
            this.label21.TabIndex = 40;
            this.label21.Text = "Name / Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Products ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 59);
            this.panel1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = global::PointOfSale.Properties.Resources.icons8_Refresh_50px_1;
            this.btn_refresh.Location = new System.Drawing.Point(705, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(59, 55);
            this.btn_refresh.TabIndex = 71;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PointOfSale.Properties.Resources.icons8_Synchronize_28px;
            this.button1.Location = new System.Drawing.Point(511, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 29);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_NewBrand
            // 
            this.btn_NewBrand.BackColor = System.Drawing.Color.Navy;
            this.btn_NewBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewBrand.ForeColor = System.Drawing.Color.White;
            this.btn_NewBrand.Image = global::PointOfSale.Properties.Resources.icons8_New_28px_1;
            this.btn_NewBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NewBrand.Location = new System.Drawing.Point(415, 87);
            this.btn_NewBrand.Name = "btn_NewBrand";
            this.btn_NewBrand.Size = new System.Drawing.Size(95, 31);
            this.btn_NewBrand.TabIndex = 50;
            this.btn_NewBrand.Text = "Brand";
            this.btn_NewBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NewBrand.UseVisualStyleBackColor = false;
            this.btn_NewBrand.Click += new System.EventHandler(this.btn_NewBrand_Click);
            // 
            // btn_NewCategory
            // 
            this.btn_NewCategory.BackColor = System.Drawing.Color.Navy;
            this.btn_NewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewCategory.ForeColor = System.Drawing.Color.White;
            this.btn_NewCategory.Image = global::PointOfSale.Properties.Resources.icons8_New_28px_1;
            this.btn_NewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NewCategory.Location = new System.Drawing.Point(161, 87);
            this.btn_NewCategory.Name = "btn_NewCategory";
            this.btn_NewCategory.Size = new System.Drawing.Size(114, 31);
            this.btn_NewCategory.TabIndex = 49;
            this.btn_NewCategory.Text = "Category";
            this.btn_NewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NewCategory.UseVisualStyleBackColor = false;
            this.btn_NewCategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Scan
            // 
            this.btn_Scan.BackColor = System.Drawing.Color.Silver;
            this.btn_Scan.FlatAppearance.BorderSize = 0;
            this.btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scan.Image = global::PointOfSale.Properties.Resources.icons8_Barcode_Reader_50px;
            this.btn_Scan.Location = new System.Drawing.Point(377, 6);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(54, 45);
            this.btn_Scan.TabIndex = 17;
            this.btn_Scan.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(521, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = "refresh";
            // 
            // ucAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucAddProduct";
            this.Size = new System.Drawing.Size(1389, 715);
            this.Load += new System.EventHandler(this.ucAddStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox brand_cmbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox category_cmbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.TextBox txt_ROM;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txt_RAM;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.TextBox txt_OSVerison;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txt_screenSize;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txt_BankCameraPXL;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txt_frontCameraPXL;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txt_OtherInfor;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_Scan;
        internal System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox txt_proName;
        internal System.Windows.Forms.TextBox txt_proTag;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_SerialNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.ComboBox searchByBrand_cmbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serchByCategory_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btn_NewCategory;
        private System.Windows.Forms.Button btn_NewBrand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}
