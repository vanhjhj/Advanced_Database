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
            this.btnOrder = new System.Windows.Forms.Button();
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
            this.pnlRoot.Size = new System.Drawing.Size(1924, 1033);
            this.pnlRoot.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlLoginInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1061, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.71542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.28458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 1033);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.BackColor = System.Drawing.Color.PeachPuff;
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
            this.pnlLoginInfo.Controls.Add(this.btnOrder);
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
            this.pnlLoginInfo.Location = new System.Drawing.Point(0, 244);
            this.pnlLoginInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(863, 789);
            this.pnlLoginInfo.TabIndex = 2;
            // 
            // txbCardType
            // 
            this.txbCardType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCardType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCardType.Location = new System.Drawing.Point(655, 373);
            this.txbCardType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCardType.Name = "txbCardType";
            this.txbCardType.ReadOnly = true;
            this.txbCardType.Size = new System.Drawing.Size(171, 30);
            this.txbCardType.TabIndex = 38;
            // 
            // lblCardType
            // 
            this.lblCardType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(477, 375);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(123, 23);
            this.lblCardType.TabIndex = 37;
            this.lblCardType.Text = "Tên Loại Thẻ";
            // 
            // txbReservedPoint
            // 
            this.txbReservedPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbReservedPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReservedPoint.Location = new System.Drawing.Point(655, 307);
            this.txbReservedPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbReservedPoint.Name = "txbReservedPoint";
            this.txbReservedPoint.ReadOnly = true;
            this.txbReservedPoint.Size = new System.Drawing.Size(171, 30);
            this.txbReservedPoint.TabIndex = 36;
            // 
            // lblReservedPoint
            // 
            this.lblReservedPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservedPoint.AutoSize = true;
            this.lblReservedPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservedPoint.Location = new System.Drawing.Point(477, 307);
            this.lblReservedPoint.Name = "lblReservedPoint";
            this.lblReservedPoint.Size = new System.Drawing.Size(172, 23);
            this.lblReservedPoint.TabIndex = 35;
            this.lblReservedPoint.Text = "Tổng Điểm Duy Trì";
            // 
            // txbTotalPoint
            // 
            this.txbTotalPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTotalPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPoint.Location = new System.Drawing.Point(655, 242);
            this.txbTotalPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTotalPoint.Name = "txbTotalPoint";
            this.txbTotalPoint.ReadOnly = true;
            this.txbTotalPoint.Size = new System.Drawing.Size(171, 30);
            this.txbTotalPoint.TabIndex = 34;
            // 
            // lblTotalPoint
            // 
            this.lblTotalPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPoint.AutoSize = true;
            this.lblTotalPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoint.Location = new System.Drawing.Point(477, 244);
            this.lblTotalPoint.Name = "lblTotalPoint";
            this.lblTotalPoint.Size = new System.Drawing.Size(102, 23);
            this.lblTotalPoint.TabIndex = 33;
            this.lblTotalPoint.Text = "Tổng Điểm";
            // 
            // txbStartedCycle
            // 
            this.txbStartedCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbStartedCycle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStartedCycle.Location = new System.Drawing.Point(655, 172);
            this.txbStartedCycle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbStartedCycle.Name = "txbStartedCycle";
            this.txbStartedCycle.ReadOnly = true;
            this.txbStartedCycle.Size = new System.Drawing.Size(171, 30);
            this.txbStartedCycle.TabIndex = 32;
            // 
            // lblStartedCycle
            // 
            this.lblStartedCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartedCycle.AutoSize = true;
            this.lblStartedCycle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartedCycle.Location = new System.Drawing.Point(477, 179);
            this.lblStartedCycle.Name = "lblStartedCycle";
            this.lblStartedCycle.Size = new System.Drawing.Size(154, 23);
            this.lblStartedCycle.TabIndex = 31;
            this.lblStartedCycle.Text = "Ngày BD Chu Kỳ";
            // 
            // txbCertifiedDate
            // 
            this.txbCertifiedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCertifiedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCertifiedDate.Location = new System.Drawing.Point(655, 105);
            this.txbCertifiedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCertifiedDate.Name = "txbCertifiedDate";
            this.txbCertifiedDate.ReadOnly = true;
            this.txbCertifiedDate.Size = new System.Drawing.Size(171, 30);
            this.txbCertifiedDate.TabIndex = 30;
            // 
            // lblCertifiedDate
            // 
            this.lblCertifiedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCertifiedDate.AutoSize = true;
            this.lblCertifiedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertifiedDate.Location = new System.Drawing.Point(477, 107);
            this.lblCertifiedDate.Name = "lblCertifiedDate";
            this.lblCertifiedDate.Size = new System.Drawing.Size(92, 23);
            this.lblCertifiedDate.TabIndex = 29;
            this.lblCertifiedDate.Text = "Ngày Lập";
            // 
            // txbCardNumber
            // 
            this.txbCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCardNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCardNumber.Location = new System.Drawing.Point(655, 38);
            this.txbCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCardNumber.Name = "txbCardNumber";
            this.txbCardNumber.ReadOnly = true;
            this.txbCardNumber.Size = new System.Drawing.Size(171, 30);
            this.txbCardNumber.TabIndex = 28;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(477, 40);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(76, 23);
            this.lblCardNumber.TabIndex = 27;
            this.lblCardNumber.Text = "Mã Thẻ";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(549, 577);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(129, 44);
            this.btnOrder.TabIndex = 26;
            this.btnOrder.Text = "Đặt Món";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // txbIdNumber
            // 
            this.txbIdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbIdNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdNumber.Location = new System.Drawing.Point(185, 373);
            this.txbIdNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIdNumber.Name = "txbIdNumber";
            this.txbIdNumber.Size = new System.Drawing.Size(259, 30);
            this.txbIdNumber.TabIndex = 25;
            // 
            // cbbGender
            // 
            this.cbbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGender.Location = new System.Drawing.Point(185, 445);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(101, 30);
            this.cbbGender.TabIndex = 24;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(185, 307);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(259, 30);
            this.txbEmail.TabIndex = 23;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.Location = new System.Drawing.Point(185, 242);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(259, 30);
            this.txbPhoneNumber.TabIndex = 22;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(45, 447);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(91, 23);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNumber.Location = new System.Drawing.Point(45, 375);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(66, 23);
            this.lblIdNumber.TabIndex = 20;
            this.lblIdNumber.Text = "CCCD";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 309);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 23);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(45, 244);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(128, 23);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Số Điện Thoại";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(45, 179);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(72, 23);
            this.lblFullName.TabIndex = 17;
            this.lblFullName.Text = "Họ Tên";
            // 
            // txbFullName
            // 
            this.txbFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.Location = new System.Drawing.Point(185, 177);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(259, 30);
            this.txbFullName.TabIndex = 16;
            // 
            // pbDisplayPassword
            // 
            this.pbDisplayPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDisplayPassword.BackColor = System.Drawing.SystemColors.Window;
            this.pbDisplayPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbDisplayPassword.Image")));
            this.pbDisplayPassword.Location = new System.Drawing.Point(417, 107);
            this.pbDisplayPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbDisplayPassword.Name = "pbDisplayPassword";
            this.pbDisplayPassword.Size = new System.Drawing.Size(27, 25);
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
            this.btnUpdateInfo.Location = new System.Drawing.Point(199, 577);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(129, 44);
            this.btnUpdateInfo.TabIndex = 14;
            this.btnUpdateInfo.Text = "Cập Nhật";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(185, 107);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(259, 30);
            this.txbPassword.TabIndex = 8;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(185, 38);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(259, 30);
            this.txbUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(45, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(45, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 23);
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
            this.pbLogo.Size = new System.Drawing.Size(863, 244);
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
            this.pbLoginImage.Size = new System.Drawing.Size(1061, 1033);
            this.pbLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginImage.TabIndex = 2;
            this.pbLoginImage.TabStop = false;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.pnlRoot);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRoot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
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
        private System.Windows.Forms.Button btnOrder;
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
    }
}