using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SuShiX
{
    public partial class FrmOrderResult : Form
    {
        private string userID;
        private string connectionString = AppConfig.connectionString;

        public FrmOrderResult(DataTable data, string userID, string orderType)
        {
            InitializeComponent();
            this.userID = userID;
            this.Width = 1000;
            this.Height = 600;
            dgvOrderDetails.DataSource = data;
            dgvOrderDetails.RowHeadersVisible = false;
            lbOrderType.Text = orderType;
            accountingInvoice();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int LoadCustomerDiscount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_LayMucGiamCuaThe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaTK", userID);

                        // Thêm các tham số đầu ra
                        SqlParameter mucGiamParam = new SqlParameter
                        {
                            ParameterName = "@MucGiam",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mucGiamParam);

                        //trả về mức giảm của thẻ
                        cmd.ExecuteNonQuery();
                        return Convert.ToInt32(mucGiamParam.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        private void accountingInvoice()
        {
            int total = 0;
            int discountMoney = 0;
            int gross = 0;
            int point = 0;

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["TotalAmount"].Value);
                }
            }

            discountMoney = total * LoadCustomerDiscount() / 100;

            gross = total - discountMoney;
            point = gross / 100000;

            txbTotalAmount.Text = total.ToString() + " VNĐ";
            txbDiscount.Text = discountMoney.ToString() + " VNĐ";
            txbGross.Text = gross.ToString() + " VNĐ";
            txbPoint.Text = point.ToString() + " Điểm";
        }

    }
}
