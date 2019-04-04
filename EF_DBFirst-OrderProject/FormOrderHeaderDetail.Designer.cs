namespace EF_DBFirst_OrderProject
{
    partial class FormOrderHeaderDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.txtBoxOrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBoxProducts = new System.Windows.Forms.ComboBox();
            this.btnUpdateDet = new System.Windows.Forms.Button();
            this.btnDeleteDet = new System.Windows.Forms.Button();
            this.btnInsertDet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(807, 34);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(100, 20);
            this.txtFreight.TabIndex = 23;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(549, 34);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(96, 20);
            this.dtpRequiredDate.TabIndex = 22;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(435, 35);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(96, 20);
            this.dtpOrderDate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Freight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ship Via";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "RequiredDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "OrderDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer";
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(661, 34);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(121, 21);
            this.cmbShipVia.TabIndex = 14;
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(304, 34);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(108, 21);
            this.cmbEmployees.TabIndex = 13;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(132, 34);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(144, 21);
            this.cmbCustomers.TabIndex = 12;
            // 
            // txtBoxOrderID
            // 
            this.txtBoxOrderID.Location = new System.Drawing.Point(8, 34);
            this.txtBoxOrderID.Name = "txtBoxOrderID";
            this.txtBoxOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderID.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "OrderID";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(132, 61);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(144, 79);
            this.txtBoxAddress.TabIndex = 26;
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(132, 146);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(144, 20);
            this.txtBoxCountry.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(8, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 18);
            this.panel1.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Order Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(495, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Order Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 168);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total Amount";
            // 
            // txtBoxTotalAmount
            // 
            this.txtBoxTotalAmount.Enabled = false;
            this.txtBoxTotalAmount.Location = new System.Drawing.Point(90, 390);
            this.txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            this.txtBoxTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalAmount.TabIndex = 34;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(796, 232);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantity.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(704, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Products";
            // 
            // cmbBoxProducts
            // 
            this.cmbBoxProducts.FormattingEnabled = true;
            this.cmbBoxProducts.Location = new System.Drawing.Point(796, 280);
            this.cmbBoxProducts.Name = "cmbBoxProducts";
            this.cmbBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProducts.TabIndex = 38;
            // 
            // btnUpdateDet
            // 
            this.btnUpdateDet.Location = new System.Drawing.Point(721, 330);
            this.btnUpdateDet.Name = "btnUpdateDet";
            this.btnUpdateDet.Size = new System.Drawing.Size(151, 23);
            this.btnUpdateDet.TabIndex = 39;
            this.btnUpdateDet.Text = "Update Order Detail";
            this.btnUpdateDet.UseVisualStyleBackColor = true;
            this.btnUpdateDet.Click += new System.EventHandler(this.btnUpdateDet_Click);
            // 
            // btnDeleteDet
            // 
            this.btnDeleteDet.Location = new System.Drawing.Point(721, 359);
            this.btnDeleteDet.Name = "btnDeleteDet";
            this.btnDeleteDet.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteDet.TabIndex = 40;
            this.btnDeleteDet.Text = "Delete Order Detail";
            this.btnDeleteDet.UseVisualStyleBackColor = true;
            this.btnDeleteDet.Click += new System.EventHandler(this.btnDeleteDet_Click);
            // 
            // btnInsertDet
            // 
            this.btnInsertDet.Location = new System.Drawing.Point(721, 388);
            this.btnInsertDet.Name = "btnInsertDet";
            this.btnInsertDet.Size = new System.Drawing.Size(151, 23);
            this.btnInsertDet.TabIndex = 41;
            this.btnInsertDet.Text = "Insert Order Detail";
            this.btnInsertDet.UseVisualStyleBackColor = true;
            this.btnInsertDet.Click += new System.EventHandler(this.btnInsertDet_Click);
            // 
            // FormOrderHeaderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.btnInsertDet);
            this.Controls.Add(this.btnDeleteDet);
            this.Controls.Add(this.btnUpdateDet);
            this.Controls.Add(this.cmbBoxProducts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.txtBoxTotalAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxCountry);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxOrderID);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbShipVia);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.cmbCustomers);
            this.Name = "FormOrderHeaderDetail";
            this.Text = "FormOrderHeaderDetail";
            this.Load += new System.EventHandler(this.FormOrderHeaderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.TextBox txtBoxOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTotalAmount;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBoxProducts;
        private System.Windows.Forms.Button btnUpdateDet;
        private System.Windows.Forms.Button btnDeleteDet;
        private System.Windows.Forms.Button btnInsertDet;
    }
}