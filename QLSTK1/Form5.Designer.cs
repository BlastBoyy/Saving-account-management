
namespace QuanLiSoTietKiem
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboLoaiTK = new System.Windows.Forms.ComboBox();
            this.dataSomo = new System.Windows.Forms.DataGridView();
            this.dataSodong = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSodong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo đóng/mở sổ tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại tiết kiệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(414, 153);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(221, 27);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            // 
            // comboLoaiTK
            // 
            this.comboLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoaiTK.FormattingEnabled = true;
            this.comboLoaiTK.Location = new System.Drawing.Point(130, 152);
            this.comboLoaiTK.Name = "comboLoaiTK";
            this.comboLoaiTK.Size = new System.Drawing.Size(217, 28);
            this.comboLoaiTK.TabIndex = 4;
            // 
            // dataSomo
            // 
            this.dataSomo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataSomo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSomo.Location = new System.Drawing.Point(81, 223);
            this.dataSomo.Name = "dataSomo";
            this.dataSomo.RowHeadersWidth = 51;
            this.dataSomo.RowTemplate.Height = 24;
            this.dataSomo.Size = new System.Drawing.Size(308, 187);
            this.dataSomo.TabIndex = 5;
            // 
            // dataSodong
            // 
            this.dataSodong.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataSodong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSodong.Location = new System.Drawing.Point(395, 223);
            this.dataSodong.Name = "dataSodong";
            this.dataSodong.RowHeadersWidth = 51;
            this.dataSodong.RowTemplate.Height = 24;
            this.dataSodong.Size = new System.Drawing.Size(330, 187);
            this.dataSodong.TabIndex = 6;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(664, 145);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(115, 46);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Tạo báo cáo";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataSodong);
            this.Controls.Add(this.dataSomo);
            this.Controls.Add(this.comboLoaiTK);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Form5";
            this.Text = "Báo cáo tháng";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSodong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboLoaiTK;
        private System.Windows.Forms.DataGridView dataSomo;
        private System.Windows.Forms.DataGridView dataSodong;
        private System.Windows.Forms.Button buttonCreate;
    }
}