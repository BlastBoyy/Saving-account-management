
namespace QuanLiSoTietKiem
{
    partial class Form4
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaso = new System.Windows.Forms.TextBox();
            this.textKhachhang = new System.Windows.Forms.TextBox();
            this.comboLoaiTK = new System.Windows.Forms.ComboBox();
            this.DataTraCuu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra cứu sổ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(635, 138);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 40);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Tra cứu";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại tiết kiệm";
            // 
            // textMaso
            // 
            this.textMaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaso.Location = new System.Drawing.Point(207, 107);
            this.textMaso.Name = "textMaso";
            this.textMaso.Size = new System.Drawing.Size(353, 27);
            this.textMaso.TabIndex = 5;
            // 
            // textKhachhang
            // 
            this.textKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKhachhang.Location = new System.Drawing.Point(249, 182);
            this.textKhachhang.Name = "textKhachhang";
            this.textKhachhang.Size = new System.Drawing.Size(311, 27);
            this.textKhachhang.TabIndex = 6;
            // 
            // comboLoaiTK
            // 
            this.comboLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoaiTK.FormattingEnabled = true;
            this.comboLoaiTK.Location = new System.Drawing.Point(261, 145);
            this.comboLoaiTK.Name = "comboLoaiTK";
            this.comboLoaiTK.Size = new System.Drawing.Size(299, 28);
            this.comboLoaiTK.TabIndex = 7;
            // 
            // DataTraCuu
            // 
            this.DataTraCuu.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DataTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTraCuu.Location = new System.Drawing.Point(45, 230);
            this.DataTraCuu.Name = "DataTraCuu";
            this.DataTraCuu.RowHeadersWidth = 51;
            this.DataTraCuu.RowTemplate.Height = 24;
            this.DataTraCuu.Size = new System.Drawing.Size(705, 195);
            this.DataTraCuu.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataTraCuu);
            this.Controls.Add(this.comboLoaiTK);
            this.Controls.Add(this.textKhachhang);
            this.Controls.Add(this.textMaso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Form4";
            this.Text = "Tra cứu sổ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaso;
        private System.Windows.Forms.TextBox textKhachhang;
        private System.Windows.Forms.ComboBox comboLoaiTK;
        private System.Windows.Forms.DataGridView DataTraCuu;
    }
}