namespace SuShiX
{
    partial class FrmAddNewDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewDish));
            this.btnOK = new System.Windows.Forms.Button();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbGiaHienTai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenMA = new System.Windows.Forms.TextBox();
            this.cbbTenMuc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(556, 365);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(167, 48);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "Thêm Món Mới";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pbReturn
            // 
            this.pbReturn.Image = ((System.Drawing.Image)(resources.GetObject("pbReturn.Image")));
            this.pbReturn.Location = new System.Drawing.Point(13, 13);
            this.pbReturn.Margin = new System.Windows.Forms.Padding(4);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(30, 30);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 25;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txbGiaHienTai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbTenMA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbTenMuc, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 132);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // txbGiaHienTai
            // 
            this.txbGiaHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbGiaHienTai.Location = new System.Drawing.Point(248, 83);
            this.txbGiaHienTai.Name = "txbGiaHienTai";
            this.txbGiaHienTai.Size = new System.Drawing.Size(179, 31);
            this.txbGiaHienTai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Mục";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Hiện Tại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Món Ăn";
            // 
            // txbTenMA
            // 
            this.txbTenMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTenMA.Location = new System.Drawing.Point(23, 83);
            this.txbTenMA.Name = "txbTenMA";
            this.txbTenMA.Size = new System.Drawing.Size(179, 31);
            this.txbTenMA.TabIndex = 3;
            // 
            // cbbTenMuc
            // 
            this.cbbTenMuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTenMuc.FormattingEnabled = true;
            this.cbbTenMuc.Location = new System.Drawing.Point(483, 82);
            this.cbbTenMuc.Name = "cbbTenMuc";
            this.cbbTenMuc.Size = new System.Drawing.Size(161, 33);
            this.cbbTenMuc.TabIndex = 5;
            this.cbbTenMuc.SelectedIndexChanged += new System.EventHandler(this.cbbTenMuc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(46, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 132);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(169, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 100);
            this.panel2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thêm Món Ăn Mới";
            // 
            // FrmAddNewDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmAddNewDish";
            this.Text = "FrmAddNewDish";
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbGiaHienTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenMA;
        private System.Windows.Forms.ComboBox cbbTenMuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}