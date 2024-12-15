namespace SuShiX
{
    partial class FrmUpdateMenu
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbAreaName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnAddNewDish = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pbStatisticsImage = new System.Windows.Forms.PictureBox();
            this.TenMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangMonAn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.75F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1118, 46);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuShiX.Properties.Resources.return_button;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.ColumnCount = 1;
            this.pnlStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStatistics.Controls.Add(this.dgvMenu, 0, 2);
            this.pnlStatistics.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.pnlStatistics.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 0);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.RowCount = 3;
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.588957F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46099F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.02837F));
            this.pnlStatistics.Size = new System.Drawing.Size(1124, 608);
            this.pnlStatistics.TabIndex = 0;
            // 
            // dgvMenu
            // 
            this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMA,
            this.GiaHienTai,
            this.TinhTrangMonAn,
            this.TenMuc});
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(3, 118);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(1118, 487);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.cbbAreaName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1118, 57);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // cbbAreaName
            // 
            this.cbbAreaName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbAreaName.FormattingEnabled = true;
            this.cbbAreaName.Location = new System.Drawing.Point(573, 6);
            this.cbbAreaName.Name = "cbbAreaName";
            this.cbbAreaName.Size = new System.Drawing.Size(529, 44);
            this.cbbAreaName.TabIndex = 3;
            this.cbbAreaName.SelectedIndexChanged += new System.EventHandler(this.cbbAreaName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khu Vực";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlLoginInfo.Controls.Add(this.pnlStatistics);
            this.pnlLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoginInfo.Location = new System.Drawing.Point(0, 173);
            this.pnlLoginInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(1124, 608);
            this.pnlLoginInfo.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel2.Controls.Add(this.btnEditMenu, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewDish, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 784);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1118, 81);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(9)))), ((int)(((byte)(1)))));
            this.btnEditMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMenu.ForeColor = System.Drawing.Color.White;
            this.btnEditMenu.Location = new System.Drawing.Point(563, 6);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(549, 69);
            this.btnEditMenu.TabIndex = 2;
            this.btnEditMenu.Text = "Lưu Thay Đổi";
            this.btnEditMenu.UseVisualStyleBackColor = false;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
            // 
            // btnAddNewDish
            // 
            this.btnAddNewDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(9)))), ((int)(((byte)(1)))));
            this.btnAddNewDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewDish.ForeColor = System.Drawing.Color.White;
            this.btnAddNewDish.Location = new System.Drawing.Point(6, 6);
            this.btnAddNewDish.Name = "btnAddNewDish";
            this.btnAddNewDish.Size = new System.Drawing.Size(548, 69);
            this.btnAddNewDish.TabIndex = 0;
            this.btnAddNewDish.Text = "Thêm Món Mới ";
            this.btnAddNewDish.UseVisualStyleBackColor = false;
            this.btnAddNewDish.Click += new System.EventHandler(this.btnAddNewDish_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlLoginInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(748, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.907834F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 868);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::SuShiX.Properties.Resources.sushi_logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1124, 173);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // pnlRoot
            // 
            this.pnlRoot.ColumnCount = 2;
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlRoot.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.pnlRoot.Controls.Add(this.pbStatisticsImage, 0, 0);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 1;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.Size = new System.Drawing.Size(1872, 868);
            this.pnlRoot.TabIndex = 3;
            // 
            // pbStatisticsImage
            // 
            this.pbStatisticsImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.pbStatisticsImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbStatisticsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStatisticsImage.Image = global::SuShiX.Properties.Resources.login2;
            this.pbStatisticsImage.Location = new System.Drawing.Point(0, 0);
            this.pbStatisticsImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbStatisticsImage.Name = "pbStatisticsImage";
            this.pbStatisticsImage.Size = new System.Drawing.Size(748, 868);
            this.pbStatisticsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatisticsImage.TabIndex = 2;
            this.pbStatisticsImage.TabStop = false;
            // 
            // TenMA
            // 
            this.TenMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMA.DataPropertyName = "TenMA";
            this.TenMA.FillWeight = 200F;
            this.TenMA.HeaderText = "Tên Món";
            this.TenMA.MinimumWidth = 6;
            this.TenMA.Name = "TenMA";
            this.TenMA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GiaHienTai
            // 
            this.GiaHienTai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaHienTai.DataPropertyName = "GiaHienTai";
            this.GiaHienTai.HeaderText = "Giá Hiện Tại";
            this.GiaHienTai.MinimumWidth = 6;
            this.GiaHienTai.Name = "GiaHienTai";
            // 
            // TinhTrangMonAn
            // 
            this.TinhTrangMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrangMonAn.DataPropertyName = "TinhTrangMonAn";
            this.TinhTrangMonAn.HeaderText = "Tình Trạng Món Ăn";
            this.TinhTrangMonAn.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.TinhTrangMonAn.MinimumWidth = 6;
            this.TinhTrangMonAn.Name = "TinhTrangMonAn";
            this.TinhTrangMonAn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrangMonAn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenMuc
            // 
            this.TenMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMuc.DataPropertyName = "TenMuc";
            this.TenMuc.HeaderText = "Tên Mục";
            this.TenMuc.MinimumWidth = 10;
            this.TenMuc.Name = "TenMuc";
            this.TenMuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmUpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 868);
            this.Controls.Add(this.pnlRoot);
            this.Name = "FrmUpdateMenu";
            this.Text = "FrmUpdateMenu";
            this.Load += new System.EventHandler(this.FrmUpdateMenu_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pnlLoginInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStatisticsImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel pnlStatistics;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditMenu;
        private System.Windows.Forms.Button btnAddNewDish;
        private System.Windows.Forms.ComboBox cbbAreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHienTai;
        private System.Windows.Forms.DataGridViewComboBoxColumn TinhTrangMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMuc;
    }
}