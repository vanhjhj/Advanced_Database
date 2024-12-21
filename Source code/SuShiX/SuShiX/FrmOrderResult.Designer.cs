namespace SuShiX
{
    partial class FrmOrderResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderResult));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txbTotalAmount = new System.Windows.Forms.TextBox();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.txbGross = new System.Windows.Forms.TextBox();
            this.txbPoint = new System.Windows.Forms.TextBox();
            this.lbOrderType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(7)))), ((int)(((byte)(1)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(414, 516);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 43);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 101);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(366, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin phiếu đặt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26789F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73211F));
            this.tableLayoutPanel3.Controls.Add(this.dgvOrderDetails, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 401);
            this.tableLayoutPanel3.TabIndex = 3;
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
            this.DishName,
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
            this.dgvOrderDetails.Size = new System.Drawing.Size(691, 395);
            this.dgvOrderDetails.TabIndex = 1;
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.FillWeight = 32.40876F;
            this.DishName.HeaderText = "Tên Món";
            this.DishName.MinimumWidth = 6;
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            this.DishName.Width = 90;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "Amount";
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
            this.TotalAmount.DataPropertyName = "TotalAmount";
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
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 32.40876F;
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbOrderType, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(700, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.52854F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.47147F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(271, 395);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.43426F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.56574F));
            this.tableLayoutPanel5.Controls.Add(this.lblPoint, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblGross, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblDiscount, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblTotalAmount, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txbTotalAmount, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txbDiscount, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txbGross, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.txbPoint, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 119);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(265, 273);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoint.Location = new System.Drawing.Point(0, 204);
            this.lblPoint.Margin = new System.Windows.Forms.Padding(0);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(109, 69);
            this.lblPoint.TabIndex = 11;
            this.lblPoint.Text = "Điểm Cộng";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGross
            // 
            this.lblGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGross.Location = new System.Drawing.Point(0, 136);
            this.lblGross.Margin = new System.Windows.Forms.Padding(0);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(109, 68);
            this.lblGross.TabIndex = 10;
            this.lblGross.Text = "Thành Tiền";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Location = new System.Drawing.Point(0, 68);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(109, 68);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Tổng Tiền Giảm";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmount.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(109, 68);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Tổng Tiền";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTotalAmount
            // 
            this.txbTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalAmount.Location = new System.Drawing.Point(112, 21);
            this.txbTotalAmount.Name = "txbTotalAmount";
            this.txbTotalAmount.ReadOnly = true;
            this.txbTotalAmount.Size = new System.Drawing.Size(150, 26);
            this.txbTotalAmount.TabIndex = 12;
            // 
            // txbDiscount
            // 
            this.txbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDiscount.Location = new System.Drawing.Point(112, 89);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.ReadOnly = true;
            this.txbDiscount.Size = new System.Drawing.Size(150, 26);
            this.txbDiscount.TabIndex = 13;
            // 
            // txbGross
            // 
            this.txbGross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbGross.Location = new System.Drawing.Point(112, 157);
            this.txbGross.Name = "txbGross";
            this.txbGross.ReadOnly = true;
            this.txbGross.Size = new System.Drawing.Size(150, 26);
            this.txbGross.TabIndex = 14;
            // 
            // txbPoint
            // 
            this.txbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPoint.Location = new System.Drawing.Point(112, 225);
            this.txbPoint.Name = "txbPoint";
            this.txbPoint.ReadOnly = true;
            this.txbPoint.Size = new System.Drawing.Size(150, 26);
            this.txbPoint.TabIndex = 15;
            // 
            // lbOrderType
            // 
            this.lbOrderType.AutoSize = true;
            this.lbOrderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrderType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderType.Location = new System.Drawing.Point(3, 0);
            this.lbOrderType.Name = "lbOrderType";
            this.lbOrderType.Size = new System.Drawing.Size(265, 116);
            this.lbOrderType.TabIndex = 2;
            this.lbOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmOrderResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrderResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderResult";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txbTotalAmount;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.TextBox txbGross;
        private System.Windows.Forms.TextBox txbPoint;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}