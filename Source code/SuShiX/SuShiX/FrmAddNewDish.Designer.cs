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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbTenMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbGiaHienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenMA = new System.Windows.Forms.TextBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.clbAreaList = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.pbReturn);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 226);
            this.panel1.TabIndex = 0;
            // 
            // pbReturn
            // 
            this.pbReturn.Image = ((System.Drawing.Image)(resources.GetObject("pbReturn.Image")));
            this.pbReturn.Location = new System.Drawing.Point(19, 26);
            this.pbReturn.Margin = new System.Windows.Forms.Padding(4);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(64, 42);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 38;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
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
            this.btnOK.Location = new System.Drawing.Point(716, 425);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(201, 60);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "Thêm Món Mới";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(483, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 112);
            this.panel4.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thêm Món Ăn Mới";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddDish, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clbAreaList, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1463, 1160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.cbbTenMuc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbGiaHienTai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbTenMA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1457, 226);
            this.panel2.TabIndex = 1;
            // 
            // cbbTenMuc
            // 
            this.cbbTenMuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTenMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenMuc.FormattingEnabled = true;
            this.cbbTenMuc.Location = new System.Drawing.Point(1205, 91);
            this.cbbTenMuc.Name = "cbbTenMuc";
            this.cbbTenMuc.Size = new System.Drawing.Size(161, 39);
            this.cbbTenMuc.TabIndex = 42;
            this.cbbTenMuc.SelectedIndexChanged += new System.EventHandler(this.cbbTenMuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1012, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên Mục";
            // 
            // txbGiaHienTai
            // 
            this.txbGiaHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbGiaHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGiaHienTai.Location = new System.Drawing.Point(720, 88);
            this.txbGiaHienTai.Name = "txbGiaHienTai";
            this.txbGiaHienTai.Size = new System.Drawing.Size(179, 38);
            this.txbGiaHienTai.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên Món Ăn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Món Ăn";
            // 
            // txbTenMA
            // 
            this.txbTenMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTenMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenMA.Location = new System.Drawing.Point(266, 92);
            this.txbTenMA.Name = "txbTenMA";
            this.txbTenMA.Size = new System.Drawing.Size(179, 38);
            this.txbTenMA.TabIndex = 3;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(7)))), ((int)(((byte)(1)))));
            this.btnAddDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDish.Location = new System.Drawing.Point(575, 1002);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(312, 83);
            this.btnAddDish.TabIndex = 2;
            this.btnAddDish.Text = "Thêm Món Ăn ";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // clbAreaList
            // 
            this.clbAreaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbAreaList.Location = new System.Drawing.Point(3, 467);
            this.clbAreaList.Name = "clbAreaList";
            this.clbAreaList.Size = new System.Drawing.Size(1457, 458);
            this.clbAreaList.TabIndex = 0;
            // 
            // FrmAddNewDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1463, 1160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddNewDish";
            this.Text = "Thêm Món Ăn Mới";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbTenMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbGiaHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenMA;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.CheckedListBox clbAreaList;
    }
}