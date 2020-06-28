namespace EF_CuoiKi
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bt_Add = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Sort = new System.Windows.Forms.Button();
            this.Cbb_Sort = new System.Windows.Forms.ComboBox();
            this.Cbb_Search = new System.Windows.Forms.ComboBox();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.Bt_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(579, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bt_Add
            // 
            this.Bt_Add.Location = new System.Drawing.Point(128, 195);
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.Size = new System.Drawing.Size(75, 23);
            this.Bt_Add.TabIndex = 1;
            this.Bt_Add.Text = "Add";
            this.Bt_Add.UseVisualStyleBackColor = true;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(209, 195);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(75, 23);
            this.Bt_Update.TabIndex = 1;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Location = new System.Drawing.Point(290, 195);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.Bt_Delete.TabIndex = 1;
            this.Bt_Delete.Text = "Delete";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // Bt_Sort
            // 
            this.Bt_Sort.Location = new System.Drawing.Point(371, 195);
            this.Bt_Sort.Name = "Bt_Sort";
            this.Bt_Sort.Size = new System.Drawing.Size(75, 23);
            this.Bt_Sort.TabIndex = 1;
            this.Bt_Sort.Text = "Sort";
            this.Bt_Sort.UseCompatibleTextRendering = true;
            this.Bt_Sort.UseVisualStyleBackColor = true;
            this.Bt_Sort.Click += new System.EventHandler(this.Bt_Sort_Click);
            // 
            // Cbb_Sort
            // 
            this.Cbb_Sort.FormattingEnabled = true;
            this.Cbb_Sort.Location = new System.Drawing.Point(452, 197);
            this.Cbb_Sort.Name = "Cbb_Sort";
            this.Cbb_Sort.Size = new System.Drawing.Size(121, 21);
            this.Cbb_Sort.TabIndex = 2;
            // 
            // Cbb_Search
            // 
            this.Cbb_Search.FormattingEnabled = true;
            this.Cbb_Search.Location = new System.Drawing.Point(295, 12);
            this.Cbb_Search.Name = "Cbb_Search";
            this.Cbb_Search.Size = new System.Drawing.Size(148, 21);
            this.Cbb_Search.TabIndex = 2;
            // 
            // Tb_Search
            // 
            this.Tb_Search.Location = new System.Drawing.Point(449, 12);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(140, 20);
            this.Tb_Search.TabIndex = 3;
            // 
            // Bt_Search
            // 
            this.Bt_Search.Location = new System.Drawing.Point(214, 10);
            this.Bt_Search.Name = "Bt_Search";
            this.Bt_Search.Size = new System.Drawing.Size(75, 23);
            this.Bt_Search.TabIndex = 4;
            this.Bt_Search.Text = "Search";
            this.Bt_Search.UseVisualStyleBackColor = true;
            this.Bt_Search.Click += new System.EventHandler(this.Bt_Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 231);
            this.Controls.Add(this.Bt_Search);
            this.Controls.Add(this.Tb_Search);
            this.Controls.Add(this.Cbb_Search);
            this.Controls.Add(this.Cbb_Sort);
            this.Controls.Add(this.Bt_Sort);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.Bt_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_Add;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Sort;
        private System.Windows.Forms.ComboBox Cbb_Sort;
        private System.Windows.Forms.ComboBox Cbb_Search;
        private System.Windows.Forms.TextBox Tb_Search;
        private System.Windows.Forms.Button Bt_Search;
    }
}

