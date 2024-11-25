namespace SuShiX
{
    partial class FrmCusRegister
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
            this.pbLogoRegister = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCusRegister = new System.Windows.Forms.Label();
            this.pnlRegisterInfo = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txbIdNumber = new System.Windows.Forms.TextBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbDisplayPassword = new System.Windows.Forms.PictureBox();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRegister)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlRegisterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.ColumnCount = 2;
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.375F));
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.625F));
            this.pnlRoot.Controls.Add(this.pbLogoRegister, 0, 0);
            this.pnlRoot.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 1;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.Size = new System.Drawing.Size(800, 450);
            this.pnlRoot.TabIndex = 0;
            // 
            // pbLogoRegister
            // 
            this.pbLogoRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoRegister.Image = global::SuShiX.Properties.Resources.logo_register;
            this.pbLogoRegister.Location = new System.Drawing.Point(3, 3);
            this.pbLogoRegister.Name = "pbLogoRegister";
            this.pbLogoRegister.Size = new System.Drawing.Size(245, 444);
            this.pbLogoRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoRegister.TabIndex = 0;
            this.pbLogoRegister.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblCusRegister, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlRegisterInfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(254, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.24324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.75676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 444);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCusRegister
            // 
            this.lblCusRegister.AutoSize = true;
            this.lblCusRegister.BackColor = System.Drawing.Color.Yellow;
            this.lblCusRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCusRegister.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCusRegister.Location = new System.Drawing.Point(3, 0);
            this.lblCusRegister.Name = "lblCusRegister";
            this.lblCusRegister.Size = new System.Drawing.Size(537, 80);
            this.lblCusRegister.TabIndex = 1;
            this.lblCusRegister.Text = "Đăng Ký Tài Khoản";
            this.lblCusRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRegisterInfo
            // 
            this.pnlRegisterInfo.Controls.Add(this.pbDisplayPassword);
            this.pnlRegisterInfo.Controls.Add(this.btnRegister);
            this.pnlRegisterInfo.Controls.Add(this.txbEmail);
            this.pnlRegisterInfo.Controls.Add(this.cbbGender);
            this.pnlRegisterInfo.Controls.Add(this.txbIdNumber);
            this.pnlRegisterInfo.Controls.Add(this.txbTelephone);
            this.pnlRegisterInfo.Controls.Add(this.txbFullname);
            this.pnlRegisterInfo.Controls.Add(this.txbPassword);
            this.pnlRegisterInfo.Controls.Add(this.txbUsername);
            this.pnlRegisterInfo.Controls.Add(this.lblGender);
            this.pnlRegisterInfo.Controls.Add(this.lblIdNumber);
            this.pnlRegisterInfo.Controls.Add(this.lblEmail);
            this.pnlRegisterInfo.Controls.Add(this.lblTelephone);
            this.pnlRegisterInfo.Controls.Add(this.lblFullname);
            this.pnlRegisterInfo.Controls.Add(this.lblPassword);
            this.pnlRegisterInfo.Controls.Add(this.lblUsername);
            this.pnlRegisterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegisterInfo.Location = new System.Drawing.Point(3, 83);
            this.pnlRegisterInfo.Name = "pnlRegisterInfo";
            this.pnlRegisterInfo.Size = new System.Drawing.Size(537, 358);
            this.pnlRegisterInfo.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(198, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(152, 56);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Location = new System.Drawing.Point(146, 259);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(258, 30);
            this.txbEmail.TabIndex = 13;
            // 
            // cbbGender
            // 
            this.cbbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGender.Location = new System.Drawing.Point(410, 163);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(121, 31);
            this.cbbGender.TabIndex = 12;
            // 
            // txbIdNumber
            // 
            this.txbIdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbIdNumber.Location = new System.Drawing.Point(146, 215);
            this.txbIdNumber.Name = "txbIdNumber";
            this.txbIdNumber.Size = new System.Drawing.Size(258, 30);
            this.txbIdNumber.TabIndex = 11;
            // 
            // txbTelephone
            // 
            this.txbTelephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTelephone.Location = new System.Drawing.Point(146, 163);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(161, 30);
            this.txbTelephone.TabIndex = 10;
            // 
            // txbFullname
            // 
            this.txbFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFullname.Location = new System.Drawing.Point(146, 112);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(258, 30);
            this.txbFullname.TabIndex = 9;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Location = new System.Drawing.Point(146, 63);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(258, 30);
            this.txbPassword.TabIndex = 8;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUsername.Location = new System.Drawing.Point(146, 12);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(258, 30);
            this.txbUsername.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(313, 167);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(91, 23);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNumber.Location = new System.Drawing.Point(6, 218);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(66, 23);
            this.lblIdNumber.TabIndex = 5;
            this.lblIdNumber.Text = "CCCD";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(6, 167);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(128, 23);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Số Điện Thoại";
            // 
            // lblFullname
            // 
            this.lblFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(6, 115);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(72, 23);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "Họ Tên";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 66);
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
            this.lblUsername.Location = new System.Drawing.Point(6, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên Tài Khoản";
            // 
            // pbDisplayPassword
            // 
            this.pbDisplayPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDisplayPassword.Image = global::SuShiX.Properties.Resources.eye_open;
            this.pbDisplayPassword.Location = new System.Drawing.Point(374, 63);
            this.pbDisplayPassword.Name = "pbDisplayPassword";
            this.pbDisplayPassword.Size = new System.Drawing.Size(30, 30);
            this.pbDisplayPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisplayPassword.TabIndex = 15;
            this.pbDisplayPassword.TabStop = false;
            this.pbDisplayPassword.Click += new System.EventHandler(this.pbDisplayPassword_Click);
            // 
            // FrmCusRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRoot);
            this.Name = "FrmCusRegister";
            this.Text = "FrmCusRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRegister)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlRegisterInfo.ResumeLayout(false);
            this.pnlRegisterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.PictureBox pbLogoRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCusRegister;
        private System.Windows.Forms.Panel pnlRegisterInfo;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txbIdNumber;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pbDisplayPassword;
    }
}