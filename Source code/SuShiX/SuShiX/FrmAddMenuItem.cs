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
    public partial class FrmAddMenuItem : Form
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
        public FrmAddMenuItem(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManageMenu frmManageMenu = new FrmManageMenu(userID);
            this.Hide();
            frmManageMenu.ShowDialog();
            this.Close();
        }

        private void FrmAddMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
