
namespace QuanLiSoTietKiem
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
            this.MainTitle = new System.Windows.Forms.Label();
            this.buttonMoSo = new System.Windows.Forms.Button();
            this.buttonGui = new System.Windows.Forms.Button();
            this.buttonRut = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainTitle.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainTitle.Location = new System.Drawing.Point(228, 65);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(407, 58);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Quản lí sổ tiết kiệm";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTitle.UseWaitCursor = true;
            // 
            // buttonMoSo
            // 
            this.buttonMoSo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonMoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoSo.Location = new System.Drawing.Point(238, 216);
            this.buttonMoSo.Name = "buttonMoSo";
            this.buttonMoSo.Size = new System.Drawing.Size(160, 40);
            this.buttonMoSo.TabIndex = 1;
            this.buttonMoSo.Text = "Mở sổ tiết kiệm";
            this.buttonMoSo.UseVisualStyleBackColor = false;
            this.buttonMoSo.Click += new System.EventHandler(this.buttonMoSo_Click);
            // 
            // buttonGui
            // 
            this.buttonGui.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGui.Location = new System.Drawing.Point(238, 287);
            this.buttonGui.Name = "buttonGui";
            this.buttonGui.Size = new System.Drawing.Size(160, 40);
            this.buttonGui.TabIndex = 2;
            this.buttonGui.Text = "Lập phiếu gửi tiền";
            this.buttonGui.UseVisualStyleBackColor = false;
            this.buttonGui.Click += new System.EventHandler(this.buttonGui_Click);
            // 
            // buttonRut
            // 
            this.buttonRut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRut.Location = new System.Drawing.Point(357, 362);
            this.buttonRut.Name = "buttonRut";
            this.buttonRut.Size = new System.Drawing.Size(160, 40);
            this.buttonRut.TabIndex = 3;
            this.buttonRut.Text = "Lập phiếu rút tiền";
            this.buttonRut.UseVisualStyleBackColor = false;
            this.buttonRut.Click += new System.EventHandler(this.buttonRut_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(480, 216);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(162, 40);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Tra cứu sổ";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(480, 287);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(162, 40);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Báo cáo tháng";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiSoTietKiem.Properties.Resources.light_blue_theme_wj4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 503);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRut);
            this.Controls.Add(this.buttonGui);
            this.Controls.Add(this.buttonMoSo);
            this.Controls.Add(this.MainTitle);
            this.Name = "FormMain";
            this.Text = "Quản lí sổ tiết kiệm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button buttonMoSo;
        private System.Windows.Forms.Button buttonGui;
        private System.Windows.Forms.Button buttonRut;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReport;
    }
}

