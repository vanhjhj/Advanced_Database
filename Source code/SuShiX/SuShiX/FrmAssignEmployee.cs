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
    public partial class FrmAssignEmployee : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Connection string cho cơ sở dữ liệu
        private string connectionString = AppConfig.connectionString;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }
        public FrmAssignEmployee(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
        }

        private void FrmAssignEmployee_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManageEmployee frmManageEmployee = new FrmManageEmployee(userID);
            this.Hide();
            frmManageEmployee.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmManageEmployee frmManageEmployee = new FrmManageEmployee(userID);
            this.Hide();
            frmManageEmployee.ShowDialog();
            this.Close();
        }
    }
}
