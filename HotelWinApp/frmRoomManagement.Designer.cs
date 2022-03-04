namespace HotelWinApp
{
    partial class frmRoomManagement
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
            this.dvgRoom = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnModifyService = new System.Windows.Forms.Button();
            this.btnModifyRoomType = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgRoom
            // 
            this.dvgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRoom.Location = new System.Drawing.Point(12, 82);
            this.dvgRoom.Name = "dvgRoom";
            this.dvgRoom.ReadOnly = true;
            this.dvgRoom.RowTemplate.Height = 25;
            this.dvgRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRoom.Size = new System.Drawing.Size(651, 224);
            this.dvgRoom.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(107, 39);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Rooms";
            // 
            // btnModifyService
            // 
            this.btnModifyService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyService.Location = new System.Drawing.Point(238, 8);
            this.btnModifyService.Name = "btnModifyService";
            this.btnModifyService.Size = new System.Drawing.Size(172, 48);
            this.btnModifyService.TabIndex = 2;
            this.btnModifyService.Text = "Modify Service";
            this.btnModifyService.UseVisualStyleBackColor = true;
            // 
            // btnModifyRoomType
            // 
            this.btnModifyRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyRoomType.Location = new System.Drawing.Point(460, 8);
            this.btnModifyRoomType.Name = "btnModifyRoomType";
            this.btnModifyRoomType.Size = new System.Drawing.Size(172, 48);
            this.btnModifyRoomType.TabIndex = 2;
            this.btnModifyRoomType.Text = "Modify Room Type";
            this.btnModifyRoomType.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(669, 201);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 40);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(669, 136);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 42);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmRoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 314);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnModifyRoomType);
            this.Controls.Add(this.btnModifyService);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dvgRoom);
            this.Name = "frmRoomManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms Management";
            this.Load += new System.EventHandler(this.frmRoomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgRoom;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnModifyService;
        private System.Windows.Forms.Button btnModifyRoomType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLoad;
    }
}