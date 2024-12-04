namespace SuShiX
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbCardType = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.txbReservedPoint = new System.Windows.Forms.TextBox();
            this.lblReservedPoint = new System.Windows.Forms.Label();
            this.txbTotalPoint = new System.Windows.Forms.TextBox();
            this.lblTotalPoint = new System.Windows.Forms.Label();
            this.txbStartedCycle = new System.Windows.Forms.TextBox();
            this.lblStartedCycle = new System.Windows.Forms.Label();
            this.txbCertifiedDate = new System.Windows.Forms.TextBox();
            this.lblCertifiedDate = new System.Windows.Forms.Label();
            this.txbCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txbIdNumber = new System.Windows.Forms.TextBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.pbDisplayPassword = new System.Windows.Forms.PictureBox();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbLoginImage = new System.Windows.Forms.PictureBox();
            this.pnlRoot.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.ColumnCount = 2;
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.18868F));
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.81132F));
            this.pnlRoot.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.pnlRoot.Controls.Add(this.pbLoginImage, 0, 0);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 1;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.Size = new System.Drawing.Size(2164, 1291);
            this.pnlRoot.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.pnlLoginInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1194, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.71542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.28458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 1291);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlLoginInfo.Controls.Add(this.pictureBox1);
            this.pnlLoginInfo.Controls.Add(this.txbCardType);
            this.pnlLoginInfo.Controls.Add(this.lblCardType);
            this.pnlLoginInfo.Controls.Add(this.txbReservedPoint);
            this.pnlLoginInfo.Controls.Add(this.lblReservedPoint);
            this.pnlLoginInfo.Controls.Add(this.txbTotalPoint);
            this.pnlLoginInfo.Controls.Add(this.lblTotalPoint);
            this.pnlLoginInfo.Controls.Add(this.txbStartedCycle);
            this.pnlLoginInfo.Controls.Add(this.lblStartedCycle);
            this.pnlLoginInfo.Controls.Add(this.txbCertifiedDate);
            this.pnlLoginInfo.Controls.Add(this.lblCertifiedDate);
            this.pnlLoginInfo.Controls.Add(this.txbCardNumber);
            this.pnlLoginInfo.Controls.Add(this.lblCardNumber);
            this.pnlLoginInfo.Controls.Add(this.txbIdNumber);
            this.pnlLoginInfo.Controls.Add(this.cbbGender);
            this.pnlLoginInfo.Controls.Add(this.txbEmail);
            this.pnlLoginInfo.Controls.Add(this.txbPhoneNumber);
            this.pnlLoginInfo.Controls.Add(this.lblGender);
            this.pnlLoginInfo.Controls.Add(this.lblIdNumber);
            this.pnlLoginInfo.Controls.Add(this.lblEmail);
            this.pnlLoginInfo.Controls.Add(this.lblPhoneNumber);
            this.pnlLoginInfo.Controls.Add(this.lblFullName);
            this.pnlLoginInfo.Controls.Add(this.txbFullName);
            this.pnlLoginInfo.Controls.Add(this.pbDisplayPassword);
            this.pnlLoginInfo.Controls.Add(this.btnUpdateInfo);
            this.pnlLoginInfo.Controls.Add(this.txbPassword);
            this.pnlLoginInfo.Controls.Add(this.txbUsername);
            this.pnlLoginInfo.Controls.Add(this.lblPassword);
            this.pnlLoginInfo.Controls.Add(this.lblUsername);
            this.pnlLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoginInfo.Location = new System.Drawing.Point(0, 306);
            this.pnlLoginInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(970, 985);
            this.pnlLoginInfo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SuShiX.Properties.Resources.return_button;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txbCardType
            // 
            this.txbCardType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCardType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCardType.Location = new System.Drawing.Point(745, 536);
            this.txbCardType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbCardType.Name = "txbCardType";
            this.txbCardType.ReadOnly = true;
            this.txbCardType.Size = new System.Drawing.Size(192, 35);
            this.txbCardType.TabIndex = 38;
            // 
            // lblCardType
            // 
            this.lblCardType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(546, 539);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(149, 26);
            this.lblCardType.TabIndex = 37;
            this.lblCardType.Text = "Tên Loại Thẻ";
            // 
            // txbReservedPoint
            // 
            this.txbReservedPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbReservedPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReservedPoint.Location = new System.Drawing.Point(745, 453);
            this.txbReservedPoint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbReservedPoint.Name = "txbReservedPoint";
            this.txbReservedPoint.ReadOnly = true;
            this.txbReservedPoint.Size = new System.Drawing.Size(192, 35);
            this.txbReservedPoint.TabIndex = 36;
            // 
            // lblReservedPoint
            // 
            this.lblReservedPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservedPoint.AutoSize = true;
            this.lblReservedPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservedPoint.Location = new System.Drawing.Point(546, 453);
            this.lblReservedPoint.Name = "lblReservedPoint";
            this.lblReservedPoint.Size = new System.Drawing.Size(209, 26);
            this.lblReservedPoint.TabIndex = 35;
            this.lblReservedPoint.Text = "Tổng Điểm Duy Trì";
            // 
            // txbTotalPoint
            // 
            this.txbTotalPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTotalPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPoint.Location = new System.Drawing.Point(745, 373);
            this.txbTotalPoint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbTotalPoint.Name = "txbTotalPoint";
            this.txbTotalPoint.ReadOnly = true;
            this.txbTotalPoint.Size = new System.Drawing.Size(192, 35);
            this.txbTotalPoint.TabIndex = 34;
            // 
            // lblTotalPoint
            // 
            this.lblTotalPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPoint.AutoSize = true;
            this.lblTotalPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoint.Location = new System.Drawing.Point(546, 375);
            this.lblTotalPoint.Name = "lblTotalPoint";
            this.lblTotalPoint.Size = new System.Drawing.Size(124, 26);
            this.lblTotalPoint.TabIndex = 33;
            this.lblTotalPoint.Text = "Tổng Điểm";
            // 
            // txbStartedCycle
            // 
            this.txbStartedCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbStartedCycle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStartedCycle.Location = new System.Drawing.Point(745, 285);
            this.txbStartedCycle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbStartedCycle.Name = "txbStartedCycle";
            this.txbStartedCycle.ReadOnly = true;
            this.txbStartedCycle.Size = new System.Drawing.Size(192, 35);
            this.txbStartedCycle.TabIndex = 32;
            // 
            // lblStartedCycle
            // 
            this.lblStartedCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartedCycle.AutoSize = true;
            this.lblStartedCycle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartedCycle.Location = new System.Drawing.Point(546, 293);
            this.lblStartedCycle.Name = "lblStartedCycle";
            this.lblStartedCycle.Size = new System.Drawing.Size(190, 26);
            this.lblStartedCycle.TabIndex = 31;
            this.lblStartedCycle.Text = "Ngày BD Chu Kỳ";
            // 
            // txbCertifiedDate
            // 
            this.txbCertifiedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCertifiedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCertifiedDate.Location = new System.Drawing.Point(745, 201);
            this.txbCertifiedDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbCertifiedDate.Name = "txbCertifiedDate";
            this.txbCertifiedDate.ReadOnly = true;
            this.txbCertifiedDate.Size = new System.Drawing.Size(192, 35);
            this.txbCertifiedDate.TabIndex = 30;
            // 
            // lblCertifiedDate
            // 
            this.lblCertifiedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCertifiedDate.AutoSize = true;
            this.lblCertifiedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertifiedDate.Location = new System.Drawing.Point(546, 204);
            this.lblCertifiedDate.Name = "lblCertifiedDate";
            this.lblCertifiedDate.Size = new System.Drawing.Size(112, 26);
            this.lblCertifiedDate.TabIndex = 29;
            this.lblCertifiedDate.Text = "Ngày Lập";
            // 
            // txbCardNumber
            // 
            this.txbCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCardNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCardNumber.Location = new System.Drawing.Point(745, 118);
            this.txbCardNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbCardNumber.Name = "txbCardNumber";
            this.txbCardNumber.ReadOnly = true;
            this.txbCardNumber.Size = new System.Drawing.Size(192, 35);
            this.txbCardNumber.TabIndex = 28;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(546, 119);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(92, 26);
            this.lblCardNumber.TabIndex = 27;
            this.lblCardNumber.Text = "Mã Thẻ";
            // 
            // txbIdNumber
            // 
            this.txbIdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbIdNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdNumber.Location = new System.Drawing.Point(217, 536);
            this.txbIdNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbIdNumber.Name = "txbIdNumber";
            this.txbIdNumber.Size = new System.Drawing.Size(290, 35);
            this.txbIdNumber.TabIndex = 25;
            // 
            // cbbGender
            // 
            this.cbbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGender.Location = new System.Drawing.Point(217, 627);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(114, 35);
            this.cbbGender.TabIndex = 24;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(217, 453);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(290, 35);
            this.txbEmail.TabIndex = 23;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.Location = new System.Drawing.Point(217, 373);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(290, 35);
            this.txbPhoneNumber.TabIndex = 22;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(60, 628);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(111, 26);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNumber.Location = new System.Drawing.Point(60, 539);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(80, 26);
            this.lblIdNumber.TabIndex = 20;
            this.lblIdNumber.Text = "CCCD";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(60, 456);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 26);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(60, 375);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(156, 26);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Số Điện Thoại";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(60, 293);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 26);
            this.lblFullName.TabIndex = 17;
            this.lblFullName.Text = "Họ Tên";
            // 
            // txbFullName
            // 
            this.txbFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.Location = new System.Drawing.Point(217, 292);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(290, 35);
            this.txbFullName.TabIndex = 16;
            // 
            // pbDisplayPassword
            // 
            this.pbDisplayPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDisplayPassword.BackColor = System.Drawing.SystemColors.Window;
            this.pbDisplayPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbDisplayPassword.Image")));
            this.pbDisplayPassword.Location = new System.Drawing.Point(475, 208);
            this.pbDisplayPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbDisplayPassword.Name = "pbDisplayPassword";
            this.pbDisplayPassword.Size = new System.Drawing.Size(30, 31);
            this.pbDisplayPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisplayPassword.TabIndex = 15;
            this.pbDisplayPassword.TabStop = false;
            this.pbDisplayPassword.Click += new System.EventHandler(this.pbDisplayPassword_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnUpdateInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.Location = new System.Drawing.Point(465, 739);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(146, 55);
            this.btnUpdateInfo.TabIndex = 14;
            this.btnUpdateInfo.Text = "Cập Nhật";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(217, 204);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(290, 35);
            this.txbPassword.TabIndex = 8;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(217, 118);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(290, 35);
            this.txbUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(60, 207);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(118, 26);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(60, 119);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(166, 26);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên Tài Khoản";
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::SuShiX.Properties.Resources.sushi_logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(970, 306);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // pbLoginImage
            // 
            this.pbLoginImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.pbLoginImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLoginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoginImage.Image = global::SuShiX.Properties.Resources.login2;
            this.pbLoginImage.Location = new System.Drawing.Point(0, 0);
            this.pbLoginImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbLoginImage.Name = "pbLoginImage";
            this.pbLoginImage.Size = new System.Drawing.Size(1194, 1291);
            this.pbLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginImage.TabIndex = 2;
            this.pbLoginImage.TabStop = false;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2164, 1291);
            this.Controls.Add(this.pnlRoot);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.pnlRoot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.PictureBox pbDisplayPassword;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbLoginImage;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txbIdNumber;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbReservedPoint;
        private System.Windows.Forms.Label lblReservedPoint;
        private System.Windows.Forms.TextBox txbTotalPoint;
        private System.Windows.Forms.Label lblTotalPoint;
        private System.Windows.Forms.TextBox txbStartedCycle;
        private System.Windows.Forms.Label lblStartedCycle;
        private System.Windows.Forms.TextBox txbCertifiedDate;
        private System.Windows.Forms.Label lblCertifiedDate;
        private System.Windows.Forms.TextBox txbCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txbCardType;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}