namespace SuShiX
{
    partial class FrmInvoice
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlOrderInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGeneralOrderInfo = new System.Windows.Forms.Panel();
            this.txbCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOrderList = new System.Windows.Forms.ComboBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.txbTelephoneNum = new System.Windows.Forms.TextBox();
            this.cbbOrderType = new System.Windows.Forms.ComboBox();
            this.lblTelephoneNum = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.pnlInvoiceInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoiceCreation = new System.Windows.Forms.Button();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInvoiceAndComment = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInvoicePoint = new System.Windows.Forms.TableLayoutPanel();
            this.txbPoint = new System.Windows.Forms.TextBox();
            this.txbGross = new System.Windows.Forms.TextBox();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txbTotalAmount = new System.Windows.Forms.TextBox();
            this.pnlEvaluation = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCommentPoint = new System.Windows.Forms.TableLayoutPanel();
            this.nudServicePoint = new System.Windows.Forms.NumericUpDown();
            this.nudSpacePoint = new System.Windows.Forms.NumericUpDown();
            this.nudPricePoint = new System.Windows.Forms.NumericUpDown();
            this.nudDishPoint = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSpacePoint = new System.Windows.Forms.Label();
            this.lblPricePoint = new System.Windows.Forms.Label();
            this.lblDishPoint = new System.Windows.Forms.Label();
            this.lblLocationPoint = new System.Windows.Forms.Label();
            this.nudLocationPoint = new System.Windows.Forms.NumericUpDown();
            this.pnlComment = new System.Windows.Forms.TableLayoutPanel();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlOrderInfo.SuspendLayout();
            this.pnlGeneralOrderInfo.SuspendLayout();
            this.pnlInvoiceInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.pnlInvoiceAndComment.SuspendLayout();
            this.pnlInvoicePoint.SuspendLayout();
            this.pnlEvaluation.SuspendLayout();
            this.pnlCommentPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDishPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocationPoint)).BeginInit();
            this.pnlComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.ColumnCount = 2;
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlRoot.Controls.Add(this.pbLogo, 0, 0);
            this.pnlRoot.Controls.Add(this.pnlOrderInfo, 1, 0);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 1;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 753F));
            this.pnlRoot.Size = new System.Drawing.Size(1262, 753);
            this.pnlRoot.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::SuShiX.Properties.Resources.logo_cus_order;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(372, 747);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlOrderInfo
            // 
            this.pnlOrderInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlOrderInfo.ColumnCount = 1;
            this.pnlOrderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOrderInfo.Controls.Add(this.pnlGeneralOrderInfo, 0, 1);
            this.pnlOrderInfo.Controls.Add(this.lblBranchName, 0, 0);
            this.pnlOrderInfo.Controls.Add(this.pnlInvoiceInfo, 0, 2);
            this.pnlOrderInfo.Controls.Add(this.pnlInvoiceAndComment, 0, 3);
            this.pnlOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderInfo.Location = new System.Drawing.Point(381, 3);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.RowCount = 4;
            this.pnlOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.220883F));
            this.pnlOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.19009F));
            this.pnlOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.23962F));
            this.pnlOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.61713F));
            this.pnlOrderInfo.Size = new System.Drawing.Size(878, 747);
            this.pnlOrderInfo.TabIndex = 1;
            // 
            // pnlGeneralOrderInfo
            // 
            this.pnlGeneralOrderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlGeneralOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGeneralOrderInfo.Controls.Add(this.txbCard);
            this.pnlGeneralOrderInfo.Controls.Add(this.label1);
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbOrderList);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblOrderList);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbTelephoneNum);
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbOrderType);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblTelephoneNum);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblOrderType);
            this.pnlGeneralOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralOrderInfo.Location = new System.Drawing.Point(6, 47);
            this.pnlGeneralOrderInfo.Name = "pnlGeneralOrderInfo";
            this.pnlGeneralOrderInfo.Size = new System.Drawing.Size(866, 97);
            this.pnlGeneralOrderInfo.TabIndex = 2;
            // 
            // txbCard
            // 
            this.txbCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCard.Location = new System.Drawing.Point(632, 58);
            this.txbCard.Name = "txbCard";
            this.txbCard.Size = new System.Drawing.Size(186, 30);
            this.txbCard.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thẻ";
            // 
            // cbbOrderList
            // 
            this.cbbOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbOrderList.FormattingEnabled = true;
            this.cbbOrderList.Location = new System.Drawing.Point(195, 58);
            this.cbbOrderList.Name = "cbbOrderList";
            this.cbbOrderList.Size = new System.Drawing.Size(186, 30);
            this.cbbOrderList.TabIndex = 20;
            this.cbbOrderList.SelectedIndexChanged += new System.EventHandler(this.cbbOrderList_SelectedIndexChanged);
            // 
            // lblOrderList
            // 
            this.lblOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(13, 61);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(176, 22);
            this.lblOrderList.TabIndex = 19;
            this.lblOrderList.Text = "Danh Sách Phiếu Đặt";
            // 
            // txbTelephoneNum
            // 
            this.txbTelephoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTelephoneNum.Location = new System.Drawing.Point(632, 9);
            this.txbTelephoneNum.Name = "txbTelephoneNum";
            this.txbTelephoneNum.Size = new System.Drawing.Size(186, 30);
            this.txbTelephoneNum.TabIndex = 18;
            this.txbTelephoneNum.Leave += new System.EventHandler(this.txbTelephoneNum_Leave);
            // 
            // cbbOrderType
            // 
            this.cbbOrderType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbOrderType.FormattingEnabled = true;
            this.cbbOrderType.Items.AddRange(new object[] {
            "Đặt Bàn Trực Tuyến",
            "Giao Hàng Tận Nơi",
            "Đặt Bàn Trực Tiếp"});
            this.cbbOrderType.Location = new System.Drawing.Point(195, 9);
            this.cbbOrderType.Name = "cbbOrderType";
            this.cbbOrderType.Size = new System.Drawing.Size(186, 30);
            this.cbbOrderType.TabIndex = 9;
            this.cbbOrderType.SelectedIndexChanged += new System.EventHandler(this.cbbOrderType_SelectedIndexChanged);
            // 
            // lblTelephoneNum
            // 
            this.lblTelephoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelephoneNum.AutoSize = true;
            this.lblTelephoneNum.Location = new System.Drawing.Point(438, 12);
            this.lblTelephoneNum.Name = "lblTelephoneNum";
            this.lblTelephoneNum.Size = new System.Drawing.Size(158, 22);
            this.lblTelephoneNum.TabIndex = 1;
            this.lblTelephoneNum.Text = "Số Điện Thoại Đặt";
            // 
            // lblOrderType
            // 
            this.lblOrderType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(13, 12);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(128, 22);
            this.lblOrderType.TabIndex = 0;
            this.lblOrderType.Text = "Loại Phiếu Đặt";
            // 
            // lblBranchName
            // 
            this.lblBranchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBranchName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBranchName.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.Location = new System.Drawing.Point(7, 3);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(864, 38);
            this.lblBranchName.TabIndex = 1;
            this.lblBranchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInvoiceInfo
            // 
            this.pnlInvoiceInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlInvoiceInfo.ColumnCount = 1;
            this.pnlInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlInvoiceInfo.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.pnlInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoiceInfo.Location = new System.Drawing.Point(6, 153);
            this.pnlInvoiceInfo.Name = "pnlInvoiceInfo";
            this.pnlInvoiceInfo.RowCount = 1;
            this.pnlInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInvoiceInfo.Size = new System.Drawing.Size(866, 309);
            this.pnlInvoiceInfo.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.41109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58891F));
            this.tableLayoutPanel2.Controls.Add(this.pnlButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvInvoiceDetails, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(854, 297);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlButton.ColumnCount = 1;
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButton.Controls.Add(this.btnComment, 0, 1);
            this.pnlButton.Controls.Add(this.btnExit, 0, 2);
            this.pnlButton.Controls.Add(this.btnInvoiceCreation, 0, 0);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(723, 3);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.RowCount = 3;
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlButton.Size = new System.Drawing.Size(128, 291);
            this.pnlButton.TabIndex = 2;
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComment.Location = new System.Drawing.Point(6, 102);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(116, 87);
            this.btnComment.TabIndex = 4;
            this.btnComment.Text = "Gửi Đánh Giá";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(6, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 87);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quay Lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoiceCreation
            // 
            this.btnInvoiceCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnInvoiceCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvoiceCreation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInvoiceCreation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInvoiceCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceCreation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoiceCreation.Location = new System.Drawing.Point(6, 6);
            this.btnInvoiceCreation.Name = "btnInvoiceCreation";
            this.btnInvoiceCreation.Size = new System.Drawing.Size(116, 87);
            this.btnInvoiceCreation.TabIndex = 0;
            this.btnInvoiceCreation.Text = "Xuất Hóa Đơn";
            this.btnInvoiceCreation.UseVisualStyleBackColor = false;
            this.btnInvoiceCreation.Click += new System.EventHandler(this.btnInvoiceCreation_Click);
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishName,
            this.Amount,
            this.Price,
            this.TotalAmount});
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.RowHeadersWidth = 51;
            this.dgvInvoiceDetails.RowTemplate.Height = 24;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(714, 291);
            this.dgvInvoiceDetails.TabIndex = 0;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.HeaderText = "Tên Món";
            this.DishName.MinimumWidth = 6;
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Thành Tiền";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 125;
            // 
            // pnlInvoiceAndComment
            // 
            this.pnlInvoiceAndComment.ColumnCount = 2;
            this.pnlInvoiceAndComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlInvoiceAndComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlInvoiceAndComment.Controls.Add(this.pnlInvoicePoint, 0, 0);
            this.pnlInvoiceAndComment.Controls.Add(this.pnlEvaluation, 1, 0);
            this.pnlInvoiceAndComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoiceAndComment.Location = new System.Drawing.Point(6, 471);
            this.pnlInvoiceAndComment.Name = "pnlInvoiceAndComment";
            this.pnlInvoiceAndComment.RowCount = 1;
            this.pnlInvoiceAndComment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInvoiceAndComment.Size = new System.Drawing.Size(866, 270);
            this.pnlInvoiceAndComment.TabIndex = 4;
            // 
            // pnlInvoicePoint
            // 
            this.pnlInvoicePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlInvoicePoint.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlInvoicePoint.ColumnCount = 2;
            this.pnlInvoicePoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlInvoicePoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlInvoicePoint.Controls.Add(this.txbPoint, 1, 3);
            this.pnlInvoicePoint.Controls.Add(this.txbGross, 1, 2);
            this.pnlInvoicePoint.Controls.Add(this.txbDiscount, 1, 1);
            this.pnlInvoicePoint.Controls.Add(this.lblPoint, 0, 3);
            this.pnlInvoicePoint.Controls.Add(this.lblGross, 0, 2);
            this.pnlInvoicePoint.Controls.Add(this.lblDiscount, 0, 1);
            this.pnlInvoicePoint.Controls.Add(this.lblTotalAmount, 0, 0);
            this.pnlInvoicePoint.Controls.Add(this.txbTotalAmount, 1, 0);
            this.pnlInvoicePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoicePoint.Location = new System.Drawing.Point(3, 3);
            this.pnlInvoicePoint.Name = "pnlInvoicePoint";
            this.pnlInvoicePoint.RowCount = 4;
            this.pnlInvoicePoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInvoicePoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInvoicePoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInvoicePoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInvoicePoint.Size = new System.Drawing.Size(253, 264);
            this.pnlInvoicePoint.TabIndex = 0;
            // 
            // txbPoint
            // 
            this.txbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPoint.Location = new System.Drawing.Point(94, 214);
            this.txbPoint.Name = "txbPoint";
            this.txbPoint.ReadOnly = true;
            this.txbPoint.Size = new System.Drawing.Size(153, 30);
            this.txbPoint.TabIndex = 12;
            // 
            // txbGross
            // 
            this.txbGross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbGross.Location = new System.Drawing.Point(94, 149);
            this.txbGross.Name = "txbGross";
            this.txbGross.ReadOnly = true;
            this.txbGross.Size = new System.Drawing.Size(153, 30);
            this.txbGross.TabIndex = 11;
            // 
            // txbDiscount
            // 
            this.txbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDiscount.Location = new System.Drawing.Point(94, 84);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.ReadOnly = true;
            this.txbDiscount.Size = new System.Drawing.Size(153, 30);
            this.txbDiscount.TabIndex = 10;
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoint.Location = new System.Drawing.Point(6, 198);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(79, 63);
            this.lblPoint.TabIndex = 7;
            this.lblPoint.Text = "Điểm Cộng";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGross
            // 
            this.lblGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGross.Location = new System.Drawing.Point(6, 133);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(79, 62);
            this.lblGross.TabIndex = 5;
            this.lblGross.Text = "Thành Tiền";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Location = new System.Drawing.Point(6, 68);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(79, 62);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Tổng Tiền Giảm";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmount.Location = new System.Drawing.Point(6, 3);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(79, 62);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Tổng Tiền";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTotalAmount
            // 
            this.txbTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalAmount.Location = new System.Drawing.Point(94, 19);
            this.txbTotalAmount.Name = "txbTotalAmount";
            this.txbTotalAmount.ReadOnly = true;
            this.txbTotalAmount.Size = new System.Drawing.Size(153, 30);
            this.txbTotalAmount.TabIndex = 9;
            // 
            // pnlEvaluation
            // 
            this.pnlEvaluation.ColumnCount = 1;
            this.pnlEvaluation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEvaluation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlEvaluation.Controls.Add(this.pnlCommentPoint, 0, 0);
            this.pnlEvaluation.Controls.Add(this.pnlComment, 0, 1);
            this.pnlEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvaluation.Location = new System.Drawing.Point(262, 3);
            this.pnlEvaluation.Name = "pnlEvaluation";
            this.pnlEvaluation.RowCount = 2;
            this.pnlEvaluation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlEvaluation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlEvaluation.Size = new System.Drawing.Size(601, 264);
            this.pnlEvaluation.TabIndex = 1;
            // 
            // pnlCommentPoint
            // 
            this.pnlCommentPoint.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlCommentPoint.ColumnCount = 2;
            this.pnlCommentPoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlCommentPoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlCommentPoint.Controls.Add(this.nudServicePoint, 1, 4);
            this.pnlCommentPoint.Controls.Add(this.nudSpacePoint, 1, 3);
            this.pnlCommentPoint.Controls.Add(this.nudPricePoint, 1, 2);
            this.pnlCommentPoint.Controls.Add(this.nudDishPoint, 1, 1);
            this.pnlCommentPoint.Controls.Add(this.label6, 0, 4);
            this.pnlCommentPoint.Controls.Add(this.lblSpacePoint, 0, 3);
            this.pnlCommentPoint.Controls.Add(this.lblPricePoint, 0, 2);
            this.pnlCommentPoint.Controls.Add(this.lblDishPoint, 0, 1);
            this.pnlCommentPoint.Controls.Add(this.lblLocationPoint, 0, 0);
            this.pnlCommentPoint.Controls.Add(this.nudLocationPoint, 1, 0);
            this.pnlCommentPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommentPoint.Location = new System.Drawing.Point(3, 3);
            this.pnlCommentPoint.Name = "pnlCommentPoint";
            this.pnlCommentPoint.RowCount = 5;
            this.pnlCommentPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlCommentPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlCommentPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlCommentPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlCommentPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlCommentPoint.Size = new System.Drawing.Size(595, 152);
            this.pnlCommentPoint.TabIndex = 0;
            // 
            // nudServicePoint
            // 
            this.nudServicePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudServicePoint.Location = new System.Drawing.Point(419, 122);
            this.nudServicePoint.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudServicePoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudServicePoint.Name = "nudServicePoint";
            this.nudServicePoint.Size = new System.Drawing.Size(170, 30);
            this.nudServicePoint.TabIndex = 23;
            this.nudServicePoint.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudSpacePoint
            // 
            this.nudSpacePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSpacePoint.Location = new System.Drawing.Point(419, 93);
            this.nudSpacePoint.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpacePoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpacePoint.Name = "nudSpacePoint";
            this.nudSpacePoint.Size = new System.Drawing.Size(170, 30);
            this.nudSpacePoint.TabIndex = 22;
            this.nudSpacePoint.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudPricePoint
            // 
            this.nudPricePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPricePoint.Location = new System.Drawing.Point(419, 64);
            this.nudPricePoint.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPricePoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPricePoint.Name = "nudPricePoint";
            this.nudPricePoint.Size = new System.Drawing.Size(170, 30);
            this.nudPricePoint.TabIndex = 21;
            this.nudPricePoint.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudDishPoint
            // 
            this.nudDishPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDishPoint.Location = new System.Drawing.Point(419, 35);
            this.nudDishPoint.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDishPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDishPoint.Name = "nudDishPoint";
            this.nudDishPoint.Size = new System.Drawing.Size(170, 30);
            this.nudDishPoint.TabIndex = 20;
            this.nudDishPoint.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Điểm Phục Vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpacePoint
            // 
            this.lblSpacePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSpacePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpacePoint.Location = new System.Drawing.Point(6, 90);
            this.lblSpacePoint.Name = "lblSpacePoint";
            this.lblSpacePoint.Size = new System.Drawing.Size(404, 26);
            this.lblSpacePoint.TabIndex = 8;
            this.lblSpacePoint.Text = "Điểm Không Gian";
            this.lblSpacePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPricePoint
            // 
            this.lblPricePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPricePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPricePoint.Location = new System.Drawing.Point(6, 61);
            this.lblPricePoint.Name = "lblPricePoint";
            this.lblPricePoint.Size = new System.Drawing.Size(404, 26);
            this.lblPricePoint.TabIndex = 6;
            this.lblPricePoint.Text = "Điểm Giá Cả";
            this.lblPricePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDishPoint
            // 
            this.lblDishPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDishPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDishPoint.Location = new System.Drawing.Point(6, 32);
            this.lblDishPoint.Name = "lblDishPoint";
            this.lblDishPoint.Size = new System.Drawing.Size(404, 26);
            this.lblDishPoint.TabIndex = 4;
            this.lblDishPoint.Text = "Điểm Món Ăn";
            this.lblDishPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocationPoint
            // 
            this.lblLocationPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLocationPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocationPoint.Location = new System.Drawing.Point(6, 3);
            this.lblLocationPoint.Name = "lblLocationPoint";
            this.lblLocationPoint.Size = new System.Drawing.Size(404, 26);
            this.lblLocationPoint.TabIndex = 2;
            this.lblLocationPoint.Text = "Điểm Vị Trí";
            this.lblLocationPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudLocationPoint
            // 
            this.nudLocationPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLocationPoint.Location = new System.Drawing.Point(419, 6);
            this.nudLocationPoint.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLocationPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLocationPoint.Name = "nudLocationPoint";
            this.nudLocationPoint.Size = new System.Drawing.Size(170, 30);
            this.nudLocationPoint.TabIndex = 19;
            this.nudLocationPoint.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pnlComment
            // 
            this.pnlComment.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlComment.ColumnCount = 2;
            this.pnlComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlComment.Controls.Add(this.txbComment, 1, 0);
            this.pnlComment.Controls.Add(this.lblComment, 0, 0);
            this.pnlComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComment.Location = new System.Drawing.Point(3, 161);
            this.pnlComment.Name = "pnlComment";
            this.pnlComment.RowCount = 1;
            this.pnlComment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlComment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.pnlComment.Size = new System.Drawing.Size(595, 100);
            this.pnlComment.TabIndex = 1;
            // 
            // txbComment
            // 
            this.txbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbComment.Location = new System.Drawing.Point(126, 6);
            this.txbComment.Multiline = true;
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(463, 88);
            this.txbComment.TabIndex = 18;
            // 
            // lblComment
            // 
            this.lblComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComment.Location = new System.Drawing.Point(6, 3);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(111, 94);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Bình Luận";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.pnlRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlOrderInfo.ResumeLayout(false);
            this.pnlGeneralOrderInfo.ResumeLayout(false);
            this.pnlGeneralOrderInfo.PerformLayout();
            this.pnlInvoiceInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.pnlInvoiceAndComment.ResumeLayout(false);
            this.pnlInvoicePoint.ResumeLayout(false);
            this.pnlInvoicePoint.PerformLayout();
            this.pnlEvaluation.ResumeLayout(false);
            this.pnlCommentPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDishPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocationPoint)).EndInit();
            this.pnlComment.ResumeLayout(false);
            this.pnlComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel pnlOrderInfo;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Panel pnlGeneralOrderInfo;
        private System.Windows.Forms.ComboBox cbbOrderList;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.TextBox txbTelephoneNum;
        private System.Windows.Forms.ComboBox cbbOrderType;
        private System.Windows.Forms.Label lblTelephoneNum;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.TextBox txbCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pnlInvoiceInfo;
        private System.Windows.Forms.TableLayoutPanel pnlInvoiceAndComment;
        private System.Windows.Forms.TableLayoutPanel pnlInvoicePoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txbTotalAmount;
        private System.Windows.Forms.TextBox txbPoint;
        private System.Windows.Forms.TextBox txbGross;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.TableLayoutPanel pnlEvaluation;
        private System.Windows.Forms.TableLayoutPanel pnlCommentPoint;
        private System.Windows.Forms.Label lblSpacePoint;
        private System.Windows.Forms.Label lblPricePoint;
        private System.Windows.Forms.Label lblDishPoint;
        private System.Windows.Forms.Label lblLocationPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel pnlComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.TableLayoutPanel pnlButton;
        private System.Windows.Forms.Button btnInvoiceCreation;
        private System.Windows.Forms.NumericUpDown nudLocationPoint;
        private System.Windows.Forms.NumericUpDown nudServicePoint;
        private System.Windows.Forms.NumericUpDown nudSpacePoint;
        private System.Windows.Forms.NumericUpDown nudPricePoint;
        private System.Windows.Forms.NumericUpDown nudDishPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnExit;
    }
}