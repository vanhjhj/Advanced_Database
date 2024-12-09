using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmCreateAndReissueCard : Form
    {

        public string userName { get; set; }
        FrmEmployee FrmEmployee;

        public FrmCreateAndReissueCard(FrmEmployee parentForm)
        {
            InitializeComponent();
            this.FrmEmployee = parentForm;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userName = txbUserName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {

            FrmCusRegister registerForm = new FrmCusRegister();
            this.Hide();
            registerForm.ShowDialog();

            if (FrmEmployee != null)
            {
                FrmEmployee.Close();
            }

            this.Close();
        }
    }
}
