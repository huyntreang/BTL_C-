using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BTL_HSK
{
    public partial class NCC : Form
    {
        public NCC()
        {
            InitializeComponent();
        }

        private void NCC_Load(object sender, EventArgs e)
        {
            layDSNCC_theoView();
        }

        //Lấy ds NCC theo View
        private void layDSNCC_theoView()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_layDSNCC", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvDSNCC.DataSource = tb;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        //Thêm NCC
        public static bool themNhaCC(string constr, string sMaNCC, string sTenNCC, string sSDT, string sDiaChi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_themNCC";
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);
                    cmd.Parameters.AddWithValue("@tenNCC", sTenNCC);
                    cmd.Parameters.AddWithValue("@SDT", sSDT);
                    cmd.Parameters.AddWithValue("@diaChi", sDiaChi);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaNCC, sTenNCC, sSDT, sDiaChi;

            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            sMaNCC = txtMaNCC.Text;
            if (timKiem_MaNCC(constr, sMaNCC) == true)
            {
                DialogResult result = MessageBox.Show("Mã NCC đã tồn tại. Mời bạn kiểm tra lại!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            sTenNCC = txtTenNCC.Text;
            sSDT = txtSDT.Text;
            sDiaChi = txtDiaChi.Text;

            bool i = themNhaCC(constr, sMaNCC, sTenNCC, sSDT, sDiaChi);
            if (i)
            {
                MessageBox.Show("Thêm NCC thành công!!!");
                layDSNCC_theoView();
            }
            else
            {
                MessageBox.Show("Thêm NCC không thành công!!!");
            }
        }

        //Tìm kiếm mã NCC
        static bool timKiem_MaNCC(string constr, string sMaNCC)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_timMaNCC";
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);

                    cnn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    cnn.Close();
                }
            }
        }

        private void dgvDSNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvDSNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvDSNCC.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvDSNCC.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDSNCC.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSNCC_CellContentClick(sender, e);
        }

        //Sửa NCC
        public static bool suaTenVaDiaChiNCC(string constr, string sMaNCC, string sTenNCC, string sDiaChi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_suaTenVaDiaChiNCC";
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);
                    cmd.Parameters.AddWithValue("@tenNCC", sTenNCC);
                    cmd.Parameters.AddWithValue("@diaChi", sDiaChi);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaNCC, sTenNCC, sDiaChi;
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            sMaNCC = txtMaNCC.Text;
            sTenNCC = txtTenNCC.Text;
            sDiaChi = txtDiaChi.Text;

            bool i = suaTenVaDiaChiNCC(constr, sMaNCC, sTenNCC, sDiaChi);
            if (i)
            {
                MessageBox.Show("Sửa NCC thành công!!!");
                layDSNCC_theoView();
            }
            else
            {
                MessageBox.Show("Sửa NCC không thành công!!!");
            }
        }

        //Xóa NCC
        public static bool xoaNCC(string constr, string sMaNCC)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_xoaNCCTheoMaNCC";
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sMaNCC;
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            sMaNCC = txtMaNCC.Text;

            bool i = xoaNCC(constr, sMaNCC);
            if (i)
            {
                MessageBox.Show("Xóa NCC thành công!!!");
                layDSNCC_theoView();
            }
            else
            {
                MessageBox.Show("Xóa NCC không thành công!!!");
            }
        }

        //Tìm kiếm NCC
        private int timKiemNCC_theoMaNCC()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_timNCCTheoMaNCC", cnn))
                {
                    string sMaNCC = txtMaNCC.Text;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);

                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvDSNCC.DataSource = tb;
                        int a = dgvDSNCC.Rows.Count - 1;
                        return a;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

           if(timKiemNCC_theoMaNCC() > 0)
            {
                txtSL.Text = timKiemNCC_theoMaNCC().ToString();
            }
            else
            {
                txtSL.Text = 0 + "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtSL.Text = "";
        }
    }
}
