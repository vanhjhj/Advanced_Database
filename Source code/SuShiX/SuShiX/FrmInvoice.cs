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

namespace SuShiX
{
    public partial class FrmInvoice : Form
    {
        // Biến private lưu trữ userID
        private string userID;
        private string connectionString = AppConfig.connectionString;
        private int discount = 0;
        private string cardID = string.Empty;
        private string invoiceID = string.Empty;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }
        public FrmInvoice(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            DisableAllControls();
            LoadBranchName();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmployee frmEmployee = new FrmEmployee(userID);
            frmEmployee.ShowDialog();
            this.Close();
        }

        private void DisableAllControls()
        {
            txbTelephoneNum.Enabled = false;
            cbbOrderList.Enabled = false;
            txbCard.Enabled = false;

            dgvInvoiceDetails.Enabled = false;
            btnInvoiceCreation.Enabled = false;

            pnlInvoiceAndComment.Enabled = false;
        }

        private void LoadBranchName()
        {
            string query = @"SELECT CN.TenCN 
                             FROM NhanVien NV 
                             JOIN ChiNhanh CN ON NV.MaCN = CN.MaCN
                             WHERE NV.MaTK = @MaTK";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaTK", userID);  // Truyền tên khu vực vào tham số

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra xem có dữ liệu trả về không
                    if (reader.HasRows)
                    {
                        // Lấy ra tên chi nhánh duy nhất
                        reader.Read();
                        string branchName = reader.GetString(0);
                        lblBranchName.Text = branchName + " - Hóa Đơn";
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi nhánh nào trong khu vực này hoặc nhân viên không thuộc chi nhánh mà khách hàng đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu địa chỉ chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrderType = cbbOrderType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOrderType))
            {
                // Nếu chưa chọn loại phiếu đặt, tắt tất cả các điều khiển
                DisableAllControls();
            }
            else
            {
                cbbOrderList.Enabled = true;
                txbTelephoneNum.Text = string.Empty;
                txbCard.Text = string.Empty;
                txbTelephoneNum.Enabled = true;
                txbCard.Enabled = true;
                txbCard.ReadOnly = true;
                cbbOrderList.DataSource = null;

                dgvInvoiceDetails.Enabled = true;
                dgvInvoiceDetails.DataSource = null;

                pnlInvoiceAndComment.Enabled = true;
                pnlCommentPoint.Enabled = false;
                pnlComment.Enabled = false;
                txbTotalAmount.Text = string.Empty;
                txbComment.Text = string.Empty;
                txbDiscount.Text = string.Empty;
                txbGross.Text = string.Empty;
                txbPoint.Text = string.Empty;

                if (selectedOrderType == "Đặt Bàn Trực Tiếp")
                {
                    LoadOrderList();
                }
            }
        }

        private void LoadOrderList()
        {
            // Lấy giá trị từ các điều kiện cần thiết
            string phoneNumber = txbTelephoneNum.Text;
            string orderType = cbbOrderType.SelectedItem?.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_DanhSachDatHoaDon", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LoaiPhieuDat", orderType);
                        cmd.Parameters.AddWithValue("@MaTKNhanVien", userID);
                        cmd.Parameters.AddWithValue("@SDTKhachHang", phoneNumber);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra xem có dữ liệu trả về không
                            if (reader.HasRows)
                            {
                                // Khởi tạo một danh sách các địa chỉ chi nhánh
                                List<string> orderList = new List<string>();

                                while (reader.Read())
                                {
                                    // Đọc địa chỉ của từng chi nhánh
                                    string order = reader["MaPhieu"].ToString();
                                    orderList.Add(order);
                                }

                                // Gán dữ liệu vào ComboBox hoặc điều khiển thích hợp
                                cbbOrderList.DataSource = orderList;  // Cập nhật ComboBox với danh sách địa chỉ chi nhánh
                            }
                            else
                            {
                                MessageBox.Show("Khách hàng không đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phiếu đặt của khách hàng: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTelephoneNum_Leave(object sender, EventArgs e)
        {
            string selectedOrderType = cbbOrderType.SelectedItem?.ToString();

            // Kiểm tra loại phiếu đặt và thay đổi trạng thái các điều khiển tương ứng
            if (selectedOrderType == "Đặt Bàn Trực Tuyến" && txbTelephoneNum.Text != null)
            {
                LoadCustomerCard();
                
            }
            else if (selectedOrderType == "Giao Hàng Tận Nơi" && txbTelephoneNum.Text != null)
            {
                LoadCustomerCard();
            }
            else if (selectedOrderType == "Đặt Bàn Trực Tiếp" && txbTelephoneNum.Text != null)
            {
                LoadCustomerCard();
                accountingInvoice();
            }
        }

        private void LoadCustomerCard()
        {
            // Lấy giá trị từ các điều kiện cần thiết
            string phoneNumber = txbTelephoneNum.Text;
            string orderType = cbbOrderType.SelectedItem?.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_LayRaTheCuaKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SDTKhachHang", phoneNumber);

                        // Thêm các tham số đầu ra
                        SqlParameter maTheParam = new SqlParameter
                        {
                            ParameterName = "@MaThe",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(maTheParam);

                        // Thêm các tham số đầu ra
                        SqlParameter mucGiamParam = new SqlParameter
                        {
                            ParameterName = "@GiamGia",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mucGiamParam);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra xem có dữ liệu trả về không
                            if (maTheParam.Value != DBNull.Value)
                            {
                                cardID = maTheParam.Value.ToString();
                                txbCard.Text = cardID;
                                discount = int.Parse(mucGiamParam.Value.ToString());
                                accountingInvoice();
                            }
                            else
                            {
                                txbCard.Text = string.Empty;
                                discount = 0;
                            }
                        }

                        string selectedOrderType = cbbOrderType.SelectedItem?.ToString();
                        if (selectedOrderType == "Giao Hàng Tận Nơi" && txbTelephoneNum.Text != null)
                        {
                            LoadOrderList();
                        }
                        else if (selectedOrderType == "Đặt Bàn Trực Tuyến" && txbTelephoneNum.Text != null)
                        {
                            LoadOrderList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phiếu đặt của khách hàng: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoiceDetails()
        {
            // Lấy giá trị phiếu đặt từ ComboBox cbbOrderList
            string selectedOrderID = cbbOrderList.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOrderID))
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_CTHD", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        cmd.Parameters.AddWithValue("@MaPhieu", selectedOrderID);

                        // Đọc dữ liệu chi tiết phiếu đặt
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dtInvoiceDetails = new DataTable();
                                dtInvoiceDetails.Load(reader);

                                dgvInvoiceDetails.AutoGenerateColumns = false;


                                dgvInvoiceDetails.DataSource = dtInvoiceDetails;
                            }
                            else
                            {
                                dgvInvoiceDetails.DataSource = null; // Xóa dữ liệu nếu không có kết quả
                                MessageBox.Show("Không tìm thấy chi tiết nào cho phiếu đặt này hoặc nhân viên không thuộc chi nhánh mà khách hàng đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết phiếu đặt: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInvoiceDetails();
            accountingInvoice();
            string selectedOrderList = cbbOrderList.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedOrderList))
            {
                btnInvoiceCreation.Enabled = false;
            }
            else
            {
                btnInvoiceCreation.Enabled = true;
            }
        }

        private void accountingInvoice()
        {
            // Lấy ra tổng của tất cả các dòng trong dgvInvoiceDetails["TotalAmount"]
            int total = 0;
            int discountMoney = 0;
            int gross = 0;
            int point = 0;

            foreach (DataGridViewRow row in dgvInvoiceDetails.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["TotalAmount"].Value);
                }
            }

            if (txbCard.Text != string.Empty)
            {
                discountMoney = total * discount / 100;
            }

            gross = total - discountMoney;
            point = gross / 100000;

            txbTotalAmount.Text = total.ToString() + " VNĐ";
            txbDiscount.Text = discountMoney.ToString() + " VNĐ";
            txbGross.Text = gross.ToString() + " VNĐ";
            txbPoint.Text = point.ToString();
        }

        private void btnInvoiceCreation_Click(object sender, EventArgs e)
        {
            pnlCommentPoint.Enabled = true;
            pnlComment.Enabled = true;

            CreateInvoice();
        }

        private void CreateInvoice()
        {
            // Loại bỏ 4 ký tự cuối " VNĐ" và chuyển thành số
            int totalAmount = int.Parse(txbTotalAmount.Text.Substring(0, txbTotalAmount.Text.Length - 4));
            int discount = int.Parse(txbDiscount.Text.Substring(0, txbDiscount.Text.Length - 4));
            int gross = int.Parse(txbGross.Text.Substring(0, txbGross.Text.Length - 4));
            int points = int.Parse(txbPoint.Text);
            string selectedOrderID = cbbOrderList.SelectedItem?.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_Xuat_Hoa_Don", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số đầu ra
                        SqlParameter maHDParam = new SqlParameter
                        {
                            ParameterName = "@MaHD",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(maHDParam);

                        // Gán tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@TongTien", totalAmount);
                        cmd.Parameters.AddWithValue("@TongTienDuocGiam", discount);
                        cmd.Parameters.AddWithValue("@ThanhTien", gross);
                        cmd.Parameters.AddWithValue("@DiemCong", points);
                        cmd.Parameters.AddWithValue("@MaPhieu", selectedOrderID);

                        // Xử lý cardID
                        if (string.IsNullOrEmpty(cardID))
                        {
                            cmd.Parameters.AddWithValue("@MaThe", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@MaThe", cardID);
                        }

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Lấy ra mã hóa đơn
                        invoiceID = maHDParam.Value.ToString();

                        MessageBox.Show("Hóa đơn đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phiếu đặt của khách hàng: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateComment()
        {

            int locationPoint = int.Parse(nudLocationPoint.Value.ToString());
            int dishPoint = int.Parse(nudDishPoint.Value.ToString());
            int pricePoint = int.Parse(nudPricePoint.Value.ToString());
            int spacePoint = int.Parse(nudSpacePoint.Value.ToString());
            int servicePoint = int.Parse(nudServicePoint.Value.ToString());
            string comment = txbComment.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("USP_Them_Danh_Gia", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Gán tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaHD", invoiceID);
                        cmd.Parameters.AddWithValue("@DiemViTriCN", locationPoint);
                        cmd.Parameters.AddWithValue("@DiemChatLuongMonAn", dishPoint);
                        cmd.Parameters.AddWithValue("@DiemGiaCa", pricePoint);
                        cmd.Parameters.AddWithValue("@DiemKhongGianNhaHang", spacePoint);
                        cmd.Parameters.AddWithValue("@DiemPhucVu", servicePoint);
                        cmd.Parameters.AddWithValue("@BinhLuan", comment);
                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đánh giá đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đánh giá: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            CreateComment();
            this.Hide();
            FrmEmployee frmEmployee = new FrmEmployee(userID);
            frmEmployee.ShowDialog();
            this.Close();
        }
    }
}
