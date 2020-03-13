namespace QLKHO
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btntimKiem = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaphang.ForeColor = System.Drawing.Color.Black;
            this.btnNhaphang.Location = new System.Drawing.Point(154, 154);
            this.btnNhaphang.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(229, 53);
            this.btnNhaphang.TabIndex = 2;
            this.btnNhaphang.Text = "Nhập Hàng";
            this.btnNhaphang.UseVisualStyleBackColor = true;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Kho";
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHang.ForeColor = System.Drawing.Color.Black;
            this.btnXuatHang.Location = new System.Drawing.Point(520, 154);
            this.btnXuatHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(229, 53);
            this.btnXuatHang.TabIndex = 4;
            this.btnXuatHang.Text = "Xuất Hàng";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(154, 381);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(229, 53);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(154, 267);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(229, 53);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = " Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btntimKiem
            // 
            this.btntimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntimKiem.BackgroundImage")));
            this.btntimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimKiem.ForeColor = System.Drawing.Color.Black;
            this.btntimKiem.Location = new System.Drawing.Point(520, 267);
            this.btntimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimKiem.Name = "btntimKiem";
            this.btntimKiem.Size = new System.Drawing.Size(229, 53);
            this.btntimKiem.TabIndex = 8;
            this.btntimKiem.Text = "Tìm Kiếm";
            this.btntimKiem.UseVisualStyleBackColor = true;
            this.btntimKiem.Click += new System.EventHandler(this.btntimKiem_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(520, 381);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(229, 53);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(959, 517);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.btntimKiem);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnXuatHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhaphang);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btntimKiem;
        private System.Windows.Forms.Button buttonExit;
    }
}