namespace HotelWinApp
{
    partial class frmRoomDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotalDetailInfo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.cbRoomID = new System.Windows.Forms.ComboBox();
            this.txtNumberOfCustomer = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.dtpCheckInDay = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOutDay = new System.Windows.Forms.DateTimePicker();
            this.lbServiceName = new System.Windows.Forms.Label();
            this.cbServiceName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbServicePrice = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalInfo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Detail";
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRoomType.Location = new System.Drawing.Point(59, 77);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(88, 21);
            this.lbRoomType.TabIndex = 1;
            this.lbRoomType.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Checkin Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Room Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(456, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(456, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(456, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(456, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Checkout Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(322, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Order Total";
            // 
            // lbTotalDetailInfo
            // 
            this.lbTotalDetailInfo.AutoSize = true;
            this.lbTotalDetailInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalDetailInfo.Location = new System.Drawing.Point(474, 249);
            this.lbTotalDetailInfo.Name = "lbTotalDetailInfo";
            this.lbTotalDetailInfo.Size = new System.Drawing.Size(19, 21);
            this.lbTotalDetailInfo.TabIndex = 2;
            this.lbTotalDetailInfo.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(570, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "VND";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Normal",
            "Good",
            "VIP"});
            this.cbRoomType.Location = new System.Drawing.Point(249, 77);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(139, 23);
            this.cbRoomType.TabIndex = 4;
            this.cbRoomType.Text = "Normal";
            // 
            // cbRoomID
            // 
            this.cbRoomID.FormattingEnabled = true;
            this.cbRoomID.Location = new System.Drawing.Point(608, 77);
            this.cbRoomID.Name = "cbRoomID";
            this.cbRoomID.Size = new System.Drawing.Size(139, 23);
            this.cbRoomID.TabIndex = 4;
            // 
            // txtNumberOfCustomer
            // 
            this.txtNumberOfCustomer.Location = new System.Drawing.Point(249, 112);
            this.txtNumberOfCustomer.Name = "txtNumberOfCustomer";
            this.txtNumberOfCustomer.Size = new System.Drawing.Size(139, 23);
            this.txtNumberOfCustomer.TabIndex = 5;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(608, 153);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(139, 23);
            this.txtNationality.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(608, 112);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(139, 23);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(249, 196);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(139, 23);
            this.txtRoomPrice.TabIndex = 5;
            // 
            // dtpCheckInDay
            // 
            this.dtpCheckInDay.Location = new System.Drawing.Point(249, 156);
            this.dtpCheckInDay.Name = "dtpCheckInDay";
            this.dtpCheckInDay.Size = new System.Drawing.Size(139, 23);
            this.dtpCheckInDay.TabIndex = 6;
            // 
            // dtpCheckOutDay
            // 
            this.dtpCheckOutDay.Location = new System.Drawing.Point(608, 194);
            this.dtpCheckOutDay.Name = "dtpCheckOutDay";
            this.dtpCheckOutDay.Size = new System.Drawing.Size(139, 23);
            this.dtpCheckOutDay.TabIndex = 6;
            // 
            // lbServiceName
            // 
            this.lbServiceName.AutoSize = true;
            this.lbServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbServiceName.Location = new System.Drawing.Point(59, 334);
            this.lbServiceName.Name = "lbServiceName";
            this.lbServiceName.Size = new System.Drawing.Size(106, 21);
            this.lbServiceName.TabIndex = 1;
            this.lbServiceName.Text = "Service Name";
            // 
            // cbServiceName
            // 
            this.cbServiceName.FormattingEnabled = true;
            this.cbServiceName.Items.AddRange(new object[] {
            "No Service",
            "Soda",
            "Juice"});
            this.cbServiceName.Location = new System.Drawing.Point(249, 336);
            this.cbServiceName.Name = "cbServiceName";
            this.cbServiceName.Size = new System.Drawing.Size(139, 23);
            this.cbServiceName.TabIndex = 4;
            this.cbServiceName.Text = "No Service";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(27, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "SERVICE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(456, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(608, 334);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(139, 23);
            this.txtQuantity.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(59, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Service Price";
            // 
            // lbServicePrice
            // 
            this.lbServicePrice.AutoSize = true;
            this.lbServicePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbServicePrice.Location = new System.Drawing.Point(249, 382);
            this.lbServicePrice.Name = "lbServicePrice";
            this.lbServicePrice.Size = new System.Drawing.Size(19, 21);
            this.lbServicePrice.TabIndex = 2;
            this.lbServicePrice.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(345, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "VND";
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(59, 439);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowTemplate.Height = 25;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(688, 188);
            this.dgvService.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(764, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(532, 639);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(48, 21);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total";
            // 
            // lbTotalInfo
            // 
            this.lbTotalInfo.AutoSize = true;
            this.lbTotalInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalInfo.Location = new System.Drawing.Point(608, 639);
            this.lbTotalInfo.Name = "lbTotalInfo";
            this.lbTotalInfo.Size = new System.Drawing.Size(19, 21);
            this.lbTotalInfo.TabIndex = 2;
            this.lbTotalInfo.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(704, 639);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "VND";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(764, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddService.Location = new System.Drawing.Point(636, 382);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(111, 34);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(764, 593);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 34);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(764, 439);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 34);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmRoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 670);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.dtpCheckOutDay);
            this.Controls.Add(this.dtpCheckInDay);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtNumberOfCustomer);
            this.Controls.Add(this.cbRoomID);
            this.Controls.Add(this.cbServiceName);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbServicePrice);
            this.Controls.Add(this.lbTotalInfo);
            this.Controls.Add(this.lbTotalDetailInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbServiceName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.label1);
            this.Name = "frmRoomDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Detail";
            this.Load += new System.EventHandler(this.frmRoomDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalDetailInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.ComboBox cbRoomID;
        private System.Windows.Forms.TextBox txtNumberOfCustomer;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.DateTimePicker dtpCheckInDay;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDay;
        private System.Windows.Forms.Label lbServiceName;
        private System.Windows.Forms.ComboBox cbServiceName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbServicePrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLoad;
    }
}