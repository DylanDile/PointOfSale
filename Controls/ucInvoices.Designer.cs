namespace PointOfSale.Controls
{
    partial class ucInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serchByCategory_cmbx = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkr_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkr_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AllowUserToResizeColumns = false;
            this.dgvInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.Delete,
            this.Update});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInvoices.GridColor = System.Drawing.Color.White;
            this.dgvInvoices.Location = new System.Drawing.Point(5, 124);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(5);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInvoices.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInvoices.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvoices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInvoices.Size = new System.Drawing.Size(1365, 591);
            this.dgvInvoices.TabIndex = 11;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_View);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpkr_EndDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpkr_StartDate);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.txt_value);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.serchByCategory_cmbx);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(5, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 65);
            this.panel2.TabIndex = 71;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(939, 36);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(332, 26);
            this.txt_value.TabIndex = 75;
            this.txt_value.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Category :";
            // 
            // serchByCategory_cmbx
            // 
            this.serchByCategory_cmbx.FormattingEnabled = true;
            this.serchByCategory_cmbx.Items.AddRange(new object[] {
            "due",
            "closed"});
            this.serchByCategory_cmbx.Location = new System.Drawing.Point(117, 14);
            this.serchByCategory_cmbx.Name = "serchByCategory_cmbx";
            this.serchByCategory_cmbx.Size = new System.Drawing.Size(134, 26);
            this.serchByCategory_cmbx.TabIndex = 71;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = global::PointOfSale.Properties.Resources.icons8_Synchronize_28px2;
            this.btn_refresh.Location = new System.Drawing.Point(1277, 34);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(59, 28);
            this.btn_refresh.TabIndex = 71;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Start Date :";
            // 
            // dtpkr_StartDate
            // 
            this.dtpkr_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkr_StartDate.Location = new System.Drawing.Point(382, 13);
            this.dtpkr_StartDate.Name = "dtpkr_StartDate";
            this.dtpkr_StartDate.Size = new System.Drawing.Size(129, 26);
            this.dtpkr_StartDate.TabIndex = 76;
            // 
            // dtpkr_EndDate
            // 
            this.dtpkr_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkr_EndDate.Location = new System.Drawing.Point(642, 12);
            this.dtpkr_EndDate.Name = "dtpkr_EndDate";
            this.dtpkr_EndDate.Size = new System.Drawing.Size(129, 26);
            this.dtpkr_EndDate.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "End Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Search ";
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.Silver;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(777, 9);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 33);
            this.btn_View.TabIndex = 80;
            this.btn_View.Text = "view";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 72;
            this.label5.Text = "Invoices";
            // 
            // View
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.DefaultCellStyle = dataGridViewCellStyle3;
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "VIEW";
            this.View.ToolTipText = "View";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "DELETE";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Update.DefaultCellStyle = dataGridViewCellStyle5;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // ucInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvInvoices);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucInvoices";
            this.Size = new System.Drawing.Size(1382, 720);
            this.Load += new System.EventHandler(this.ucInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serchByCategory_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkr_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkr_StartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}
