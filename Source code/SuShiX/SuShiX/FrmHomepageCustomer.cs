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
    public partial class FrmHomepageCustomer : Form
    {
        private string userID;
        public FrmHomepageCustomer(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void FrmHomepageCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnUpdateIn4_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer(userID);
            this.Hide();
            frmCustomer.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmCusOrder frmCusOrder = new FrmCusOrder(userID);
            this.Hide();
            frmCusOrder.ShowDialog();
            this.Close();
        }
    }
}
