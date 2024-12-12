namespace SuShiX
{
    partial class FrmUpdateOrders
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
            this.lblReceiverAddress = new System.Windows.Forms.Label();
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
            this.lblReceiverPhoneNumber = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.Choice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrderDetails = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOrder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGeneralInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.pnlGeneralOrderInfo = new System.Windows.Forms.Panel();
            this.cbbOrderList = new System.Windows.Forms.ComboBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.txbTelephoneNum = new System.Windows.Forms.TextBox();
            this.txbGeneralNote = new System.Windows.Forms.TextBox();
            this.txbBranchName = new System.Windows.Forms.TextBox();
            this.cbbOrderType = new System.Windows.Forms.ComboBox();
            this.lblGeneralNote = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblTelephoneNum = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlShipping = new System.Windows.Forms.Panel();
            this.pbLogoCusOrder = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBookingOnline.SuspendLayout();
            this.pnlCusNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCusNumber)).BeginInit();
            this.pnlArrivalTime.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.pnlOrderDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlRoot.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlGeneralInfo.SuspendLayout();
            this.pnlGeneralOrderInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCusOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceiverAddress
            // 
            this.lblReceiverAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverAddress.Location = new System.Drawing.Point(6, 3);
            this.lblReceiverAddress.Name = "lblReceiverAddress";
            this.lblReceiverAddress.Size = new System.Drawing.Size(137, 36);
            this.lblReceiverAddress.TabIndex = 0;
            this.lblReceiverAddress.Text = "Địa Chỉ Nhận";
            this.lblReceiverAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbReceiverPhoneNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(152, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 31);
            this.panel1.TabIndex = 3;
            // 
            // txbReceiverPhoneNumber
            // 
            this.txbReceiverPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbReceiverPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.txbReceiverPhoneNumber.Name = "txbReceiverPhoneNumber";
            this.txbReceiverPhoneNumber.Size = new System.Drawing.Size(261, 30);
            this.txbReceiverPhoneNumber.TabIndex = 0;
            this.txbReceiverPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbReceiverAddress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(152, 6);
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
            this.pnlBookingOnline.Size = new System.Drawing.Size(419, 82);
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
            this.lblCusNumber.Size = new System.Drawing.Size(115, 37);
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
            this.pnlCusNumber.Size = new System.Drawing.Size(283, 31);
            this.pnlCusNumber.TabIndex = 3;
            // 
            // nudCusNumber
            // 
            this.nudCusNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCusNumber.Location = new System.Drawing.Point(0, 0);
            this.nudCusNumber.Name = "nudCusNumber";
            this.nudCusNumber.Size = new System.Drawing.Size(283, 30);
            this.nudCusNumber.TabIndex = 0;
            // 
            // pnlArrivalTime
            // 
            this.pnlArrivalTime.Controls.Add(this.dtpArrivalTime);
            this.pnlArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArrivalTime.Location = new System.Drawing.Point(130, 6);
            this.pnlArrivalTime.Name = "pnlArrivalTime";
            this.pnlArrivalTime.Size = new System.Drawing.Size(283, 30);
            this.pnlArrivalTime.TabIndex = 4;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpArrivalTime.Location = new System.Drawing.Point(0, 0);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(283, 30);
            this.dtpArrivalTime.TabIndex = 3;
            // 
            // lblReceiverPhoneNumber
            // 
            this.lblReceiverPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverPhoneNumber.Location = new System.Drawing.Point(6, 42);
            this.lblReceiverPhoneNumber.Name = "lblReceiverPhoneNumber";
            this.lblReceiverPhoneNumber.Size = new System.Drawing.Size(137, 37);
            this.lblReceiverPhoneNumber.TabIndex = 1;
            this.lblReceiverPhoneNumber.Text = "Số Điện Thoại Nhận";
            this.lblReceiverPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButton
            // 
            this.pnlButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlButton.ColumnCount = 1;
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButton.Controls.Add(this.btnUpdateOrder, 0, 0);
            this.pnlButton.Controls.Add(this.btnExit, 0, 1);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(766, 3);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.RowCount = 2;
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButton.Size = new System.Drawing.Size(90, 368);
            this.pnlButton.TabIndex = 1;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnUpdateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateOrder.Location = new System.Drawing.Point(6, 6);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(78, 173);
            this.btnUpdateOrder.TabIndex = 0;
            this.btnUpdateOrder.Text = "Cập Nhật";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(9)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(6, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 174);
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
            this.dgvOrderDetails.Size = new System.Drawing.Size(757, 368);
            this.dgvOrderDetails.TabIndex = 0;
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            this.dgvOrderDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellValueChanged);
            // 
            // Choice
            // 
            this.Choice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Choice.HeaderText = "Cập nhật";
            this.Choice.MinimumWidth = 6;
            this.Choice.Name = "Choice";
            this.Choice.Width = 85;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.DishType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DishType.DataPropertyName = "DishType";
            this.DishType.FillWeight = 32.40876F;
            this.DishType.HeaderText = "Tên Mục";
            this.DishType.MinimumWidth = 6;
            this.DishType.Name = "DishType";
            this.DishType.ReadOnly = true;
            this.DishType.Width = 109;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.FillWeight = 437.9562F;
            this.Amount.HeaderText = "SL";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 61;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 32.40876F;
            this.Price.HeaderText = "Đơn Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 107;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.FillWeight = 32.40876F;
            this.TotalAmount.HeaderText = "Thành Tiền";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 127;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 32.40876F;
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            // 
            // pnlOrderDetails
            // 
            this.pnlOrderDetails.ColumnCount = 2;
            this.pnlOrderDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.9369F));
            this.pnlOrderDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.06309F));
            this.pnlOrderDetails.Controls.Add(this.pnlButton, 1, 0);
            this.pnlOrderDetails.Controls.Add(this.dgvOrderDetails, 0, 0);
            this.pnlOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderDetails.Location = new System.Drawing.Point(6, 367);
            this.pnlOrderDetails.Name = "pnlOrderDetails";
            this.pnlOrderDetails.RowCount = 1;
            this.pnlOrderDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOrderDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.pnlOrderDetails.Size = new System.Drawing.Size(859, 374);
            this.pnlOrderDetails.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 82);
            this.tableLayoutPanel2.TabIndex = 3;
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
            this.pnlRoot.Size = new System.Drawing.Size(1264, 761);
            this.pnlRoot.TabIndex = 1;
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
            this.pnlOrder.Location = new System.Drawing.Point(386, 7);
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
            this.pnlOrder.Size = new System.Drawing.Size(871, 747);
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
            this.pnlGeneralInfo.Size = new System.Drawing.Size(857, 247);
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
            this.lblGeneralInfo.Size = new System.Drawing.Size(849, 37);
            this.lblGeneralInfo.TabIndex = 0;
            this.lblGeneralInfo.Text = "Thông Tin Phiếu Đặt";
            this.lblGeneralInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGeneralOrderInfo
            // 
            this.pnlGeneralOrderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlGeneralOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbOrderList);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblOrderList);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbTelephoneNum);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbGeneralNote);
            this.pnlGeneralOrderInfo.Controls.Add(this.txbBranchName);
            this.pnlGeneralOrderInfo.Controls.Add(this.cbbOrderType);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblGeneralNote);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblBranchName);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblTelephoneNum);
            this.pnlGeneralOrderInfo.Controls.Add(this.lblOrderType);
            this.pnlGeneralOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralOrderInfo.Location = new System.Drawing.Point(3, 40);
            this.pnlGeneralOrderInfo.Name = "pnlGeneralOrderInfo";
            this.pnlGeneralOrderInfo.Size = new System.Drawing.Size(851, 204);
            this.pnlGeneralOrderInfo.TabIndex = 1;
            // 
            // cbbOrderList
            // 
            this.cbbOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbOrderList.FormattingEnabled = true;
            this.cbbOrderList.Location = new System.Drawing.Point(601, 72);
            this.cbbOrderList.Name = "cbbOrderList";
            this.cbbOrderList.Size = new System.Drawing.Size(186, 30);
            this.cbbOrderList.TabIndex = 20;
            this.cbbOrderList.SelectedIndexChanged += new System.EventHandler(this.cbbOrderList_SelectedIndexChanged);
            // 
            // lblOrderList
            // 
            this.lblOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(405, 75);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(176, 22);
            this.lblOrderList.TabIndex = 19;
            this.lblOrderList.Text = "Danh Sách Phiếu Đặt";
            // 
            // txbTelephoneNum
            // 
            this.txbTelephoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTelephoneNum.Location = new System.Drawing.Point(197, 72);
            this.txbTelephoneNum.Name = "txbTelephoneNum";
            this.txbTelephoneNum.Size = new System.Drawing.Size(186, 30);
            this.txbTelephoneNum.TabIndex = 18;
            this.txbTelephoneNum.Leave += new System.EventHandler(this.txbTelephoneNum_Leave);
            // 
            // txbGeneralNote
            // 
            this.txbGeneralNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbGeneralNote.Location = new System.Drawing.Point(197, 141);
            this.txbGeneralNote.Multiline = true;
            this.txbGeneralNote.Name = "txbGeneralNote";
            this.txbGeneralNote.Size = new System.Drawing.Size(626, 50);
            this.txbGeneralNote.TabIndex = 17;
            // 
            // txbBranchName
            // 
            this.txbBranchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBranchName.Location = new System.Drawing.Point(197, 10);
            this.txbBranchName.Name = "txbBranchName";
            this.txbBranchName.ReadOnly = true;
            this.txbBranchName.Size = new System.Drawing.Size(186, 30);
            this.txbBranchName.TabIndex = 12;
            // 
            // cbbOrderType
            // 
            this.cbbOrderType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbOrderType.FormattingEnabled = true;
            this.cbbOrderType.Items.AddRange(new object[] {
            "Đặt Bàn Trực Tuyến",
            "Giao Hàng Tận Nơi",
            "Đặt Bàn Trực Tiếp"});
            this.cbbOrderType.Location = new System.Drawing.Point(601, 10);
            this.cbbOrderType.Name = "cbbOrderType";
            this.cbbOrderType.Size = new System.Drawing.Size(186, 30);
            this.cbbOrderType.TabIndex = 9;
            this.cbbOrderType.SelectedIndexChanged += new System.EventHandler(this.cbbOrderType_SelectedIndexChanged);
            // 
            // lblGeneralNote
            // 
            this.lblGeneralNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneralNote.AutoSize = true;
            this.lblGeneralNote.Location = new System.Drawing.Point(16, 156);
            this.lblGeneralNote.Name = "lblGeneralNote";
            this.lblGeneralNote.Size = new System.Drawing.Size(76, 22);
            this.lblGeneralNote.TabIndex = 8;
            this.lblGeneralNote.Text = "Ghi Chú";
            // 
            // lblBranchName
            // 
            this.lblBranchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(16, 13);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(128, 22);
            this.lblBranchName.TabIndex = 4;
            this.lblBranchName.Text = "Tên Chi Nhánh";
            // 
            // lblTelephoneNum
            // 
            this.lblTelephoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelephoneNum.AutoSize = true;
            this.lblTelephoneNum.Location = new System.Drawing.Point(16, 75);
            this.lblTelephoneNum.Name = "lblTelephoneNum";
            this.lblTelephoneNum.Size = new System.Drawing.Size(158, 22);
            this.lblTelephoneNum.TabIndex = 1;
            this.lblTelephoneNum.Text = "Số Điện Thoại Đặt";
            // 
            // lblOrderType
            // 
            this.lblOrderType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(405, 13);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(128, 22);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 94);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlShipping
            // 
            this.pnlShipping.Controls.Add(this.tableLayoutPanel2);
            this.pnlShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShipping.Location = new System.Drawing.Point(434, 6);
            this.pnlShipping.Name = "pnlShipping";
            this.pnlShipping.Size = new System.Drawing.Size(419, 82);
            this.pnlShipping.TabIndex = 1;
            // 
            // pbLogoCusOrder
            // 
            this.pbLogoCusOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogoCusOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoCusOrder.Image = global::SuShiX.Properties.Resources.logo_cus_order;
            this.pbLogoCusOrder.Location = new System.Drawing.Point(7, 7);
            this.pbLogoCusOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogoCusOrder.Name = "pbLogoCusOrder";
            this.pbLogoCusOrder.Size = new System.Drawing.Size(368, 747);
            this.pbLogoCusOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoCusOrder.TabIndex = 0;
            this.pbLogoCusOrder.TabStop = false;
            // 
            // FrmUpdateOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUpdateOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBookingOnline.ResumeLayout(false);
            this.pnlCusNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCusNumber)).EndInit();
            this.pnlArrivalTime.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.pnlOrderDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlGeneralInfo.ResumeLayout(false);
            this.pnlGeneralOrderInfo.ResumeLayout(false);
            this.pnlGeneralOrderInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlShipping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCusOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReceiverAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbReceiverPhoneNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbReceiverAddress;
        private System.Windows.Forms.TableLayoutPanel pnlBookingOnline;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblCusNumber;
        private System.Windows.Forms.Panel pnlCusNumber;
        private System.Windows.Forms.NumericUpDown nudCusNumber;
        private System.Windows.Forms.Panel pnlArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.Label lblReceiverPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel pnlButton;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.TableLayoutPanel pnlOrderDetails;
        private System.Windows.Forms.PictureBox pbLogoCusOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.TableLayoutPanel pnlOrder;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralInfo;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Panel pnlGeneralOrderInfo;
        private System.Windows.Forms.TextBox txbGeneralNote;
        private System.Windows.Forms.TextBox txbBranchName;
        private System.Windows.Forms.ComboBox cbbOrderType;
        private System.Windows.Forms.Label lblGeneralNote;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlShipping;
        private System.Windows.Forms.Label lblTelephoneNum;
        private System.Windows.Forms.TextBox txbTelephoneNum;
        private System.Windows.Forms.ComboBox cbbOrderList;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}