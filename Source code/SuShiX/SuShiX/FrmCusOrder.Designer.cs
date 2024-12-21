namespace SuShiX
{
    partial class FrmCusOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCusOrder));
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogoCusOrder = new System.Windows.Forms.PictureBox();
            this.pnlOrder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGeneralInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.pnlGeneralOrderInfo = new System.Windows.Forms.Panel();
            this.txbGeneralNote = new System.Windows.Forms.TextBox();
            this.txbTimeOpen = new System.Windows.Forms.TextBox();
            this.txbMotorbikeParking = new System.Windows.Forms.TextBox();
            this.txbCarParking = new System.Windows.Forms.TextBox();
            this.txbBranchPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbBranchName = new System.Windows.Forms.TextBox();
            this.cbbBranchAddress = new System.Windows.Forms.ComboBox();
            this.cbbAreaName = new System.Windows.Forms.ComboBox();
            this.cbbOrderType = new System.Windows.Forms.ComboBox();
            this.lblGeneralNote = new System.Windows.Forms.Label();
            this.lblMotorbikeParking = new System.Windows.Forms.Label();
            this.lblCarParking = new System.Windows.Forms.Label();
            this.lblTimeOpen = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblBranchPhoneNumber = new System.Windows.Forms.Label();
            this.lblBranchAddress = new System.Windows.Forms.Label();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlShipping = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverAddress = new System.Windows.Forms.Label();
            this.lblReceiverPhoneNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbReceiverPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbReceiverAddress = new System.Windows.Forms.TextBox();
            this.pnlBookingOnline = new System.Windows.Forms.TableLayoutPanel();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblCusNumber = new System.Windows.Forms.Label();
            this.pnlCusNumber = new System.Windows.Forms.Panel();
            this.nudCusNumber = new System.Windows.Forms.NumericUpDown();
            this.pnlArrivalTime = new System.Windows.Forms.Panel();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.pnlOrderDetails = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.Choice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCusOrder)).BeginInit();
            this.pnlOrder.SuspendLayout();
            this.pnlGeneralInfo.SuspendLayout();
            this.pnlGeneralOrderInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlShipping.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBookingOnline.SuspendLayout();
            this.pnlCusNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCusNumber)).BeginInit();
            this.pnlArrivalTime.SuspendLayout();
            this.pnlOrderDetails.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlRoot.ColumnCount = 2;
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlRoot.Controls.Add(this.pbLogoCusOrder, 0, 0);
            this.pnlRoot.Controls.Add(this.pnlOrder, 1, 0);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 1;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.Size = new System.Drawing.Size(1260, 757);
            this.pnlRoot.TabIndex = 0;
            // 
            // pbLogoCusOrder
            // 
            this.pbLogoCusOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogoCusOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoCusOrder.Image = global::SuShiX.Properties.Resources.logo_cus_order;
            this.pbLogoCusOrder.Location = new System.Drawing.Point(7, 7);
            this.pbLogoCusOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogoCusOrder.Name = "pbLogoCusOrder";
            this.pbLogoCusOrder.Size = new System.Drawing.Size(367, 743);
            this.pbLogoCusOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoCusOrder.TabIndex = 0;
            this.pbLogoCusOrder.TabStop = false;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrder.AutoSize = true;
            this.pnlOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOrder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlOrder.ColumnCount = 1;
            this.pnlOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlOrder.Controls.Add(this.pnlGeneralInfo, 0, 0);
            this.pnlOrder.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.pnlOrder.Controls.Add(this.pnlOrderDetails, 0, 2);
            this.pnlOrder.Location = new System.Drawing.Point(385, 7);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.RowCount = 3;
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.86486F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64865F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.62162F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOrder.Size = new System.Drawing.Size(868, 743);
            this.pnlOrder.TabIndex = 1;
            // 
            // pnlGeneralInfo
            // 
            this.pnlGeneralInfo.ColumnCount = 1;
            this.pnlGeneralInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlGeneralInfo.Controls.Add(this.lblGeneralInfo, 0, 0);
            this.pnlGeneralInfo.Controls.Add(this.pnlGeneralOrderInfo, 0, 1);
            this.pnlGeneralInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralInfo.Location = new System.Drawing.Point(7, 7);
            this.pnlGeneralInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGeneralInfo.Name = "pnlGeneralInfo";
            this.pnlGeneralInfo.RowCount = 2;
            this.pnlGeneralInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneralInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnlGeneralInfo.Size = new System.Drawing.Size(854, 246);
            this.pnlGeneralInfo.TabIndex = 0;
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGeneralInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.Location = new System.Drawing.Point(4, 0);
            this.lblGeneralInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(846, 36);
            this.lblGeneralInfo.TabIndex = 0;
            this.lblGeneralInfo.Text = "Thông Tin Phiếu Đặt";
            this.lblGeneralInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGeneralOrderInfo
            // 
            this.pnlGeneralOrderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlGeneralOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneralOrderInfo.Controls.Add(this.txbGeneralNote);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbTimeOpen);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbMotorbikeParking);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbCarParking);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbBranchPhoneNumber);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbBranchName);
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbBranchAddress);
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbAreaName);
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbOrderType);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblGeneralNote);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblMotorbikeParking);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblCarParking);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblTimeOpen);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblBranchName);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblBranchPhoneNumber);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblBranchAddress);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblAreaName);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblOrderType);
            this.pnlGeneralOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralOrderInfo.Location = new System.Drawing.Point(3, 39);
            this.pnlGeneralOrderInfo.Name = "pnlGeneralOrderInfo";
            this.pnlGeneralOrderInfo.Size = new System.Drawing.Size(848, 204);
            this.pnlGeneralOrderInfo.TabIndex = 1;
            // 
            // txbGeneralNote
            // 
            this.txbGeneralNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbGeneralNote.Location = new System.Drawing.Point(145, 141);
            this.txbGeneralNote.Multiline = true;
            this.txbGeneralNote.Name = "txbGeneralNote";
            this.txbGeneralNote.Size = new System.Drawing.Size(677, 50);
            this.txbGeneralNote.TabIndex = 17;
            // 
            // txbTimeOpen
            // 
            this.txbTimeOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTimeOpen.Location = new System.Drawing.Point(714, 109);
            this.txbTimeOpen.Name = "txbTimeOpen";
            this.txbTimeOpen.ReadOnly = true;
            this.txbTimeOpen.Size = new System.Drawing.Size(108, 26);
            this.txbTimeOpen.TabIndex = 16;
            // 
            // txbMotorbikeParking
            // 
            this.txbMotorbikeParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMotorbikeParking.Location = new System.Drawing.Point(472, 109);
            this.txbMotorbikeParking.Name = "txbMotorbikeParking";
            this.txbMotorbikeParking.ReadOnly = true;
            this.txbMotorbikeParking.Size = new System.Drawing.Size(61, 26);
            this.txbMotorbikeParking.TabIndex = 15;
            // 
            // txbCarParking
            // 
            this.txbCarParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCarParking.Location = new System.Drawing.Point(145, 109);
            this.txbCarParking.Name = "txbCarParking";
            this.txbCarParking.ReadOnly = true;
            this.txbCarParking.Size = new System.Drawing.Size(61, 26);
            this.txbCarParking.TabIndex = 14;
            // 
            // txbBranchPhoneNumber
            // 
            this.txbBranchPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBranchPhoneNumber.Location = new System.Drawing.Point(531, 77);
            this.txbBranchPhoneNumber.Name = "txbBranchPhoneNumber";
            this.txbBranchPhoneNumber.ReadOnly = true;
            this.txbBranchPhoneNumber.Size = new System.Drawing.Size(88, 26);
            this.txbBranchPhoneNumber.TabIndex = 13;
            // 
            // txbBranchName
            // 
            this.txbBranchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBranchName.Location = new System.Drawing.Point(145, 77);
            this.txbBranchName.Name = "txbBranchName";
            this.txbBranchName.ReadOnly = true;
            this.txbBranchName.Size = new System.Drawing.Size(186, 26);
            this.txbBranchName.TabIndex = 12;
            // 
            // cbbBranchAddress
            // 
            this.cbbBranchAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbBranchAddress.FormattingEnabled = true;
            this.cbbBranchAddress.Location = new System.Drawing.Point(145, 45);
            this.cbbBranchAddress.Name = "cbbBranchAddress";
            this.cbbBranchAddress.Size = new System.Drawing.Size(545, 27);
            this.cbbBranchAddress.TabIndex = 11;
            this.cbbBranchAddress.SelectedIndexChanged += new System.EventHandler(this.cbbBranchAddress_SelectedIndexChanged);
            // 
            // cbbAreaName
            // 
            this.cbbAreaName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbAreaName.FormattingEnabled = true;
            this.cbbAreaName.Location = new System.Drawing.Point(459, 12);
            this.cbbAreaName.Name = "cbbAreaName";
            this.cbbAreaName.Size = new System.Drawing.Size(260, 27);
            this.cbbAreaName.TabIndex = 10;
            this.cbbAreaName.SelectedIndexChanged += new System.EventHandler(this.cbbAreaName_SelectedIndexChanged);
            // 
            // cbbOrderType
            // 
            this.cbbOrderType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbOrderType.FormattingEnabled = true;
            this.cbbOrderType.Items.AddRange(new object[] {
            "Đặt Bàn Trực Tuyến",
            "Giao Hàng Tận Nơi"});
            this.cbbOrderType.Location = new System.Drawing.Point(145, 12);
            this.cbbOrderType.Name = "cbbOrderType";
            this.cbbOrderType.Size = new System.Drawing.Size(186, 27);
            this.cbbOrderType.TabIndex = 9;
            this.cbbOrderType.SelectedIndexChanged += new System.EventHandler(this.cbbOrderType_SelectedIndexChanged);
            // 
            // lblGeneralNote
            // 
            this.lblGeneralNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneralNote.AutoSize = true;
            this.lblGeneralNote.Location = new System.Drawing.Point(15, 172);
            this.lblGeneralNote.Name = "lblGeneralNote";
            this.lblGeneralNote.Size = new System.Drawing.Size(59, 19);
            this.lblGeneralNote.TabIndex = 8;
            this.lblGeneralNote.Text = "Ghi Chú";
            // 
            // lblMotorbikeParking
            // 
            this.lblMotorbikeParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotorbikeParking.AutoSize = true;
            this.lblMotorbikeParking.Location = new System.Drawing.Point(360, 112);
            this.lblMotorbikeParking.Name = "lblMotorbikeParking";
            this.lblMotorbikeParking.Size = new System.Drawing.Size(106, 19);
            this.lblMotorbikeParking.TabIndex = 7;
            this.lblMotorbikeParking.Text = "Bãi Đỗ Xe Máy";
            // 
            // lblCarParking
            // 
            this.lblCarParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCarParking.AutoSize = true;
            this.lblCarParking.Location = new System.Drawing.Point(15, 112);
            this.lblCarParking.Name = "lblCarParking";
            this.lblCarParking.Size = new System.Drawing.Size(100, 19);
            this.lblCarParking.TabIndex = 6;
            this.lblCarParking.Text = "Bãi Đỗ Xe Hơi";
            // 
            // lblTimeOpen
            // 
            this.lblTimeOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeOpen.AutoSize = true;
            this.lblTimeOpen.Location = new System.Drawing.Point(569, 112);
            this.lblTimeOpen.Name = "lblTimeOpen";
            this.lblTimeOpen.Size = new System.Drawing.Size(139, 19);
            this.lblTimeOpen.TabIndex = 5;
            this.lblTimeOpen.Text = "Thời Gian Hoạt Động";
            // 
            // lblBranchName
            // 
            this.lblBranchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(15, 80);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(101, 19);
            this.lblBranchName.TabIndex = 4;
            this.lblBranchName.Text = "Tên Chi Nhánh";
            // 
            // lblBranchPhoneNumber
            // 
            this.lblBranchPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBranchPhoneNumber.AutoSize = true;
            this.lblBranchPhoneNumber.Location = new System.Drawing.Point(360, 80);
            this.lblBranchPhoneNumber.Name = "lblBranchPhoneNumber";
            this.lblBranchPhoneNumber.Size = new System.Drawing.Size(165, 19);
            this.lblBranchPhoneNumber.TabIndex = 3;
            this.lblBranchPhoneNumber.Text = "Số Điện Thoại Chi Nhánh";
            // 
            // lblBranchAddress
            // 
            this.lblBranchAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBranchAddress.AutoSize = true;
            this.lblBranchAddress.Location = new System.Drawing.Point(15, 47);
            this.lblBranchAddress.Name = "lblBranchAddress";
            this.lblBranchAddress.Size = new System.Drawing.Size(124, 19);
            this.lblBranchAddress.TabIndex = 2;
            this.lblBranchAddress.Text = "Địa Chỉ Chi Nhánh";
            // 
            // lblAreaName
            // 
            this.lblAreaName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Location = new System.Drawing.Point(360, 15);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(93, 19);
            this.lblAreaName.TabIndex = 1;
            this.lblAreaName.Text = "Tên Khu Vực";
            // 
            // lblOrderType
            // 
            this.lblOrderType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(15, 15);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(99, 19);
            this.lblOrderType.TabIndex = 0;
            this.lblOrderType.Text = "Loại Phiếu Đặt";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlShipping, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBookingOnline, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 263);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 93);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlShipping
            // 
            this.pnlShipping.Controls.Add(this.tableLayoutPanel2);
            this.pnlShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShipping.Location = new System.Drawing.Point(432, 6);
            this.pnlShipping.Name = "pnlShipping";
            this.pnlShipping.Size = new System.Drawing.Size(418, 81);
            this.pnlShipping.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.93976F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.06024F));
            this.tableLayoutPanel2.Controls.Add(this.lblReceiverAddress, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblReceiverPhoneNumber, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(418, 81);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblReceiverAddress
            // 
            this.lblReceiverAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverAddress.Location = new System.Drawing.Point(6, 3);
            this.lblReceiverAddress.Name = "lblReceiverAddress";
            this.lblReceiverAddress.Size = new System.Drawing.Size(136, 36);
            this.lblReceiverAddress.TabIndex = 0;
            this.lblReceiverAddress.Text = "Địa Chỉ Nhận";
            this.lblReceiverAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceiverPhoneNumber
            // 
            this.lblReceiverPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverPhoneNumber.Location = new System.Drawing.Point(6, 42);
            this.lblReceiverPhoneNumber.Name = "lblReceiverPhoneNumber";
            this.lblReceiverPhoneNumber.Size = new System.Drawing.Size(136, 36);
            this.lblReceiverPhoneNumber.TabIndex = 1;
            this.lblReceiverPhoneNumber.Text = "Số Điện Thoại Nhận";
            this.lblReceiverPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbReceiverPhoneNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(151, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 30);
            this.panel1.TabIndex = 3;
            // 
            // txbReceiverPhoneNumber
            // 
            this.txbReceiverPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbReceiverPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.txbReceiverPhoneNumber.Name = "txbReceiverPhoneNumber";
            this.txbReceiverPhoneNumber.Size = new System.Drawing.Size(261, 26);
            this.txbReceiverPhoneNumber.TabIndex = 0;
            this.txbReceiverPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbReceiverAddress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(151, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 30);
            this.panel2.TabIndex = 4;
            // 
            // txbReceiverAddress
            // 
            this.txbReceiverAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbReceiverAddress.Location = new System.Drawing.Point(0, 0);
            this.txbReceiverAddress.Multiline = true;
            this.txbReceiverAddress.Name = "txbReceiverAddress";
            this.txbReceiverAddress.Size = new System.Drawing.Size(261, 30);
            this.txbReceiverAddress.TabIndex = 0;
            // 
            // pnlBookingOnline
            // 
            this.pnlBookingOnline.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlBookingOnline.ColumnCount = 2;
            this.pnlBookingOnline.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71014F));
            this.pnlBookingOnline.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.28986F));
            this.pnlBookingOnline.Controls.Add(this.lblArrivalTime, 0, 0);
            this.pnlBookingOnline.Controls.Add(this.lblCusNumber, 0, 1);
            this.pnlBookingOnline.Controls.Add(this.pnlCusNumber, 1, 1);
            this.pnlBookingOnline.Controls.Add(this.pnlArrivalTime, 1, 0);
            this.pnlBookingOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookingOnline.Location = new System.Drawing.Point(6, 6);
            this.pnlBookingOnline.Name = "pnlBookingOnline";
            this.pnlBookingOnline.RowCount = 2;
            this.pnlBookingOnline.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBookingOnline.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBookingOnline.Size = new System.Drawing.Size(417, 81);
            this.pnlBookingOnline.TabIndex = 2;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrivalTime.Location = new System.Drawing.Point(6, 3);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(115, 36);
            this.lblArrivalTime.TabIndex = 0;
            this.lblArrivalTime.Text = "Thời Gian Đến";
            this.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCusNumber
            // 
            this.lblCusNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCusNumber.Location = new System.Drawing.Point(6, 42);
            this.lblCusNumber.Name = "lblCusNumber";
            this.lblCusNumber.Size = new System.Drawing.Size(115, 36);
            this.lblCusNumber.TabIndex = 1;
            this.lblCusNumber.Text = "Số Lượng Khách";
            this.lblCusNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCusNumber
            // 
            this.pnlCusNumber.Controls.Add(this.nudCusNumber);
            this.pnlCusNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCusNumber.Location = new System.Drawing.Point(130, 45);
            this.pnlCusNumber.Name = "pnlCusNumber";
            this.pnlCusNumber.Size = new System.Drawing.Size(281, 30);
            this.pnlCusNumber.TabIndex = 3;
            // 
            // nudCusNumber
            // 
            this.nudCusNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCusNumber.Location = new System.Drawing.Point(0, 0);
            this.nudCusNumber.Name = "nudCusNumber";
            this.nudCusNumber.Size = new System.Drawing.Size(281, 26);
            this.nudCusNumber.TabIndex = 0;
            // 
            // pnlArrivalTime
            // 
            this.pnlArrivalTime.Controls.Add(this.dtpArrivalTime);
            this.pnlArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArrivalTime.Location = new System.Drawing.Point(130, 6);
            this.pnlArrivalTime.Name = "pnlArrivalTime";
            this.pnlArrivalTime.Size = new System.Drawing.Size(281, 30);
            this.pnlArrivalTime.TabIndex = 4;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpArrivalTime.Location = new System.Drawing.Point(0, 0);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(281, 26);
            this.dtpArrivalTime.TabIndex = 3;
            // 
            // pnlOrderDetails
            // 
            this.pnlOrderDetails.ColumnCount = 2;
            this.pnlOrderDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.9369F));
            this.pnlOrderDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.06309F));
            this.pnlOrderDetails.Controls.Add(this.pnlButton, 1, 0);
            this.pnlOrderDetails.Controls.Add(this.dgvOrderDetails, 0, 0);
            this.pnlOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderDetails.Location = new System.Drawing.Point(6, 365);
            this.pnlOrderDetails.Name = "pnlOrderDetails";
            this.pnlOrderDetails.RowCount = 1;
            this.pnlOrderDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOrderDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.pnlOrderDetails.Size = new System.Drawing.Size(856, 372);
            this.pnlOrderDetails.TabIndex = 2;
            // 
            // pnlButton
            // 
            this.pnlButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlButton.ColumnCount = 1;
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButton.Controls.Add(this.btnOrder, 0, 0);
            this.pnlButton.Controls.Add(this.btnExit, 0, 1);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(764, 3);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.RowCount = 2;
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButton.Size = new System.Drawing.Size(89, 366);
            this.pnlButton.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.Location = new System.Drawing.Point(6, 6);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(77, 172);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Lập Phiếu";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(6, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 173);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Quay Lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choice,
            this.DishName,
            this.DishType,
            this.Amount,
            this.Price,
            this.TotalAmount,
            this.Note});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvOrderDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 35;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrderDetails.Size = new System.Drawing.Size(755, 366);
            this.dgvOrderDetails.TabIndex = 0;
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            this.dgvOrderDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellValueChanged);
            // 
            // Choice
            // 
            this.Choice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Choice.HeaderText = "Đặt";
            this.Choice.MinimumWidth = 6;
            this.Choice.Name = "Choice";
            this.Choice.Width = 50;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.FillWeight = 32.40876F;
            this.DishName.HeaderText = "Tên Món";
            this.DishName.MinimumWidth = 6;
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            this.DishName.Width = 110;
            // 
            // DishType
            // 
            this.DishType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DishType.DataPropertyName = "DishType";
            this.DishType.FillWeight = 32.40876F;
            this.DishType.HeaderText = "Tên Mục";
            this.DishType.MinimumWidth = 6;
            this.DishType.Name = "DishType";
            this.DishType.ReadOnly = true;
            this.DishType.Width = 150;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.FillWeight = 437.9562F;
            this.Amount.HeaderText = "SL";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 40;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 32.40876F;
            this.Price.HeaderText = "Đơn Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalAmount.FillWeight = 32.40876F;
            this.TotalAmount.HeaderText = "Thành Tiền";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 150;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.FillWeight = 32.40876F;
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // FrmCusOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 757);
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCusOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCusOrder)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.pnlGeneralInfo.ResumeLayout(false);
            this.pnlGeneralOrderInfo.ResumeLayout(false);
            this.pnlGeneralOrderInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlShipping.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBookingOnline.ResumeLayout(false);
            this.pnlCusNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCusNumber)).EndInit();
            this.pnlArrivalTime.ResumeLayout(false);
            this.pnlOrderDetails.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.PictureBox pbLogoCusOrder;
        private System.Windows.Forms.TableLayoutPanel pnlOrder;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralInfo;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Panel pnlGeneralOrderInfo;
        private System.Windows.Forms.Label lblTimeOpen;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblBranchPhoneNumber;
        private System.Windows.Forms.Label lblBranchAddress;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblMotorbikeParking;
        private System.Windows.Forms.Label lblCarParking;
        private System.Windows.Forms.Label lblGeneralNote;
        private System.Windows.Forms.ComboBox cbbAreaName;
        private System.Windows.Forms.ComboBox cbbOrderType;
        private System.Windows.Forms.ComboBox cbbBranchAddress;
        private System.Windows.Forms.TextBox txbTimeOpen;
        private System.Windows.Forms.TextBox txbMotorbikeParking;
        private System.Windows.Forms.TextBox txbCarParking;
        private System.Windows.Forms.TextBox txbBranchPhoneNumber;
        private System.Windows.Forms.TextBox txbBranchName;
        private System.Windows.Forms.TextBox txbGeneralNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlShipping;
        private System.Windows.Forms.TableLayoutPanel pnlBookingOnline;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblCusNumber;
        private System.Windows.Forms.Panel pnlCusNumber;
        private System.Windows.Forms.NumericUpDown nudCusNumber;
        private System.Windows.Forms.Panel pnlArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblReceiverAddress;
        private System.Windows.Forms.Label lblReceiverPhoneNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbReceiverPhoneNumber;
        private System.Windows.Forms.TextBox txbReceiverAddress;
        private System.Windows.Forms.TableLayoutPanel pnlOrderDetails;
        private System.Windows.Forms.TableLayoutPanel pnlButton;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}