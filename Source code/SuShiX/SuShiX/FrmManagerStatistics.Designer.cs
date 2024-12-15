namespace SuShiX
{
    partial class FrmManagerStatistics
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
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txbTotalRevenue = new System.Windows.Forms.TextBox();
            this.txbTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.pnlStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatisticsInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txbBranchName = new System.Windows.Forms.TextBox();
            this.cbbDishName = new System.Windows.Forms.ComboBox();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbStatisticsImage = new System.Windows.Forms.PictureBox();
            this.pnlRoot.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.pnlStatisticsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsImage)).BeginInit();
            this.SuspendLayout();
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
            this.pnlRoot.Size = new System.Drawing.Size(1363, 753);
            this.pnlRoot.TabIndex = 2;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(545, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 753);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.txbTotalRevenue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txbTotalAmount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalRevenue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalAmount, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 642);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(812, 108);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txbTotalRevenue
            // 
            this.txbTotalRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalRevenue.Location = new System.Drawing.Point(519, 53);
            this.txbTotalRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTotalRevenue.Name = "txbTotalRevenue";
            this.txbTotalRevenue.ReadOnly = true;
            this.txbTotalRevenue.Size = new System.Drawing.Size(177, 44);
            this.txbTotalRevenue.TabIndex = 9;
            this.txbTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbTotalAmount
            // 
            this.txbTotalAmount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txbTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTotalAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalAmount.Location = new System.Drawing.Point(115, 53);
            this.txbTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTotalAmount.Name = "txbTotalAmount";
            this.txbTotalAmount.ReadOnly = true;
            this.txbTotalAmount.Size = new System.Drawing.Size(177, 44);
            this.txbTotalAmount.TabIndex = 8;
            this.txbTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.lblTotalRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRevenue.Location = new System.Drawing.Point(410, 3);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(396, 39);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Tổng Doanh Thu";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalAmount.Location = new System.Drawing.Point(6, 3);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(395, 39);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Tổng Số Lượng";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlLoginInfo.Controls.Add(this.pnlStatistics);
            this.pnlLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoginInfo.Location = new System.Drawing.Point(0, 150);
            this.pnlLoginInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(818, 489);
            this.pnlLoginInfo.TabIndex = 2;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.ColumnCount = 1;
            this.pnlStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStatistics.Controls.Add(this.pnlStatisticsInfo, 0, 1);
            this.pnlStatistics.Controls.Add(this.dgvStatistics, 0, 2);
            this.pnlStatistics.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 0);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.RowCount = 3;
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.588957F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.17791F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.pnlStatistics.Size = new System.Drawing.Size(818, 489);
            this.pnlStatistics.TabIndex = 0;
            // 
            // pnlStatisticsInfo
            // 
            this.pnlStatisticsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStatisticsInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlStatisticsInfo.ColumnCount = 4;
            this.pnlStatisticsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlStatisticsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.64014F));
            this.pnlStatisticsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.96886F));
            this.pnlStatisticsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.pnlStatisticsInfo.Controls.Add(this.label1, 3, 0);
            this.pnlStatisticsInfo.Controls.Add(this.dtpEndDate, 2, 1);
            this.pnlStatisticsInfo.Controls.Add(this.lblEndDate, 2, 0);
            this.pnlStatisticsInfo.Controls.Add(this.lblStartDate, 1, 0);
            this.pnlStatisticsInfo.Controls.Add(this.lblBranchName, 0, 0);
            this.pnlStatisticsInfo.Controls.Add(this.dtpStartDate, 1, 1);
            this.pnlStatisticsInfo.Controls.Add(this.txbBranchName, 0, 1);
            this.pnlStatisticsInfo.Controls.Add(this.cbbDishName, 3, 1);
            this.pnlStatisticsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatisticsInfo.Location = new System.Drawing.Point(3, 45);
            this.pnlStatisticsInfo.Name = "pnlStatisticsInfo";
            this.pnlStatisticsInfo.RowCount = 2;
            this.pnlStatisticsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlStatisticsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlStatisticsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlStatisticsInfo.Size = new System.Drawing.Size(812, 78);
            this.pnlStatisticsInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(579, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Món Ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(416, 36);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(138, 44);
            this.dtpEndDate.TabIndex = 10;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndDate.Location = new System.Drawing.Point(401, 3);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(169, 27);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "Ngày Kết Thúc";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartDate.Location = new System.Drawing.Point(197, 3);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(195, 27);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Ngày Bắt Đầu";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.lblBranchName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBranchName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBranchName.Location = new System.Drawing.Point(6, 3);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(182, 27);
            this.lblBranchName.TabIndex = 1;
            this.lblBranchName.Text = "Tên Chi Nhánh";
            this.lblBranchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBranchName.Click += new System.EventHandler(this.lblBranchName_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(225, 36);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(138, 44);
            this.dtpStartDate.TabIndex = 9;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // txbBranchName
            // 
            this.txbBranchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBranchName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBranchName.Location = new System.Drawing.Point(6, 37);
            this.txbBranchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBranchName.Name = "txbBranchName";
            this.txbBranchName.ReadOnly = true;
            this.txbBranchName.Size = new System.Drawing.Size(182, 44);
            this.txbBranchName.TabIndex = 8;
            this.txbBranchName.TabStop = false;
            // 
            // cbbDishName
            // 
            this.cbbDishName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDishName.FormattingEnabled = true;
            this.cbbDishName.Location = new System.Drawing.Point(599, 37);
            this.cbbDishName.Name = "cbbDishName";
            this.cbbDishName.Size = new System.Drawing.Size(186, 44);
            this.cbbDishName.TabIndex = 12;
            this.cbbDishName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishName,
            this.Amount,
            this.Revenue});
            this.dgvStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistics.Location = new System.Drawing.Point(3, 129);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowHeadersWidth = 51;
            this.dgvStatistics.RowTemplate.Height = 24;
            this.dgvStatistics.Size = new System.Drawing.Size(812, 357);
            this.dgvStatistics.TabIndex = 1;
            this.dgvStatistics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatistics_CellContentClick);
            // 
            // DishName
            // 
            this.DishName.DataPropertyName = "DishName";
            this.DishName.HeaderText = "Tên Món";
            this.DishName.MinimumWidth = 6;
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            this.DishName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DishName.Width = 240;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Doanh Số";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 240;
            // 
            // Revenue
            // 
            this.Revenue.DataPropertyName = "Revenue";
            this.Revenue.HeaderText = "Doanh Thu";
            this.Revenue.MinimumWidth = 6;
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            this.Revenue.Width = 240;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.75F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(812, 36);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::SuShiX.Properties.Resources.sushi_logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(818, 150);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
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
            this.pbStatisticsImage.Size = new System.Drawing.Size(545, 753);
            this.pbStatisticsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatisticsImage.TabIndex = 2;
            this.pbStatisticsImage.TabStop = false;
            // 
            // FrmManagerStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 753);
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmManagerStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.pnlRoot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatisticsInfo.ResumeLayout(false);
            this.pnlStatisticsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbStatisticsImage;
        private System.Windows.Forms.TableLayoutPanel pnlStatistics;
        private System.Windows.Forms.TableLayoutPanel pnlStatisticsInfo;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.TextBox txbBranchName;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txbTotalRevenue;
        private System.Windows.Forms.TextBox txbTotalAmount;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDishName;
        private System.Windows.Forms.Button button1;
    }
}