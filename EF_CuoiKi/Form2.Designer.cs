namespace EF_CuoiKi
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.Tb_SoLuong = new System.Windows.Forms.TextBox();
            this.Cbb_LoaiSanPham = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Bt_OK = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // Tb_TenSanPham
            // 
            this.Tb_TenSanPham.Location = new System.Drawing.Point(172, 20);
            this.Tb_TenSanPham.Name = "Tb_TenSanPham";
            this.Tb_TenSanPham.Size = new System.Drawing.Size(179, 20);
            this.Tb_TenSanPham.TabIndex = 1;
            // 
            // Tb_SoLuong
            // 
            this.Tb_SoLuong.Location = new System.Drawing.Point(172, 53);
            this.Tb_SoLuong.Name = "Tb_SoLuong";
            this.Tb_SoLuong.Size = new System.Drawing.Size(179, 20);
            this.Tb_SoLuong.TabIndex = 1;
            // 
            // Cbb_LoaiSanPham
            // 
            this.Cbb_LoaiSanPham.FormattingEnabled = true;
            this.Cbb_LoaiSanPham.Location = new System.Drawing.Point(172, 121);
            this.Cbb_LoaiSanPham.Name = "Cbb_LoaiSanPham";
            this.Cbb_LoaiSanPham.Size = new System.Drawing.Size(179, 21);
            this.Cbb_LoaiSanPham.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(394, 38);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(75, 23);
            this.Bt_OK.TabIndex = 4;
            this.Bt_OK.Text = "OK";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Location = new System.Drawing.Point(394, 81);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cancel.TabIndex = 4;
            this.Bt_Cancel.Text = "Cancel";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 169);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Bt_OK);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Cbb_LoaiSanPham);
            this.Controls.Add(this.Tb_SoLuong);
            this.Controls.Add(this.Tb_TenSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_TenSanPham;
        private System.Windows.Forms.TextBox Tb_SoLuong;
        private System.Windows.Forms.ComboBox Cbb_LoaiSanPham;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Bt_OK;
        private System.Windows.Forms.Button Bt_Cancel;
    }
}