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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            layMaLoaiSP();
            layMaNCC();
            layDSSP_theoView();
        }

        //Lấy mã loại SP theo comboBox
        private void layMaLoaiSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblLoaiSanPham", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tblLoaiSanPham");
                        ad.Fill(tb);
                        cbMaLoaiSP.DataSource = tb;
                        cbMaLoaiSP.DisplayMember = "sTenLoai";
                        cbMaLoaiSP.ValueMember = "sMaLoaiSP";
                    }
                }
            }
        }

        //Lấy mã NCC theo ComboBox
        private void layMaNCC()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblNCC", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tblNCC");
                        ad.Fill(tb);
                        cbMaNCC.DataSource = tb;
                        cbMaNCC.DisplayMember = "sTenNCC";
                        cbMaNCC.ValueMember = "sMaNCC";
                    }
                }
            }
        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {

        }

        private void lblMaLoaiSP_Click(object sender, EventArgs e)
        {

        }

        private void lblMaNCC_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }


        //Thêm SP
        public static bool themSP(string constr, string sMaSP, string sMaLoaiSP, string sTenSP, int iSoLuong, string sMauSac, string sChatLieu, string sNguyenLieuChinh, string fDoDai, string sMaNCC)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_themSP";
                    cmd.Parameters.AddWithValue("@maSP", sMaSP);
                    cmd.Parameters.AddWithValue("@maLoaiSP", sMaLoaiSP);
                    cmd.Parameters.AddWithValue("@tenSP", sTenSP);
                    cmd.Parameters.AddWithValue("@soLuong", iSoLuong);
                    cmd.Parameters.AddWithValue("@mauSac", sMauSac);
                    cmd.Parameters.AddWithValue("@chatLieu", sChatLieu);
                    cmd.Parameters.AddWithValue("@nguyenLieuChinh", sNguyenLieuChinh);
                    cmd.Parameters.AddWithValue("@doDai", fDoDai);
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaSP, sMaLoaiSP, sTenSP;
            int iSoLuong;
            string sMauSac, sChatLieu, sNguyenLieuChinh, fDoDai, sMaNCC;

            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            sMaSP = txtMaSP.Text;
            if ((timKiem_MaSP(constr, sMaSP) == true))
            {
                DialogResult result = MessageBox.Show("Mã sản phẩm đã tồn tại! Mời bạn kiểm tra lại khóa chính", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            sMaLoaiSP = cbMaLoaiSP.SelectedValue.ToString();
            sTenSP = txtTenSP.Text;
            iSoLuong = int.Parse(txtSoLuong.Text);
            sMauSac = txtMauSac.Text;
            sChatLieu = txtChatLieu.Text;
            sNguyenLieuChinh = txtNguyenLieuChinh.Text;
            fDoDai = txtDoDai.Text;
            sMaNCC = cbMaNCC.SelectedValue.ToString();

            bool i = themSP(constr, sMaSP, sMaLoaiSP, sTenSP, iSoLuong, sMauSac, sChatLieu, sNguyenLieuChinh, fDoDai, sMaNCC);
            if (i)
            {
                MessageBox.Show("Thêm sản phẩm thành công!!!");
                layDSSP_theoView();
            }
        }


        //Lấy ds Sản phẩm theo View
        private void layDSSP_theoView()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_layDSSP", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvHienThiDSSP.DataSource = tb;
                    }
                }
            }
        }

        //Tìm kiếm mã sp
        static bool timKiem_MaSP(string constr, string sMaSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_timKiemMaSP";
                    cmd.Parameters.AddWithValue("@maSP", sMaSP);

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

        private void dgvHienThiDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvHienThiDSSP.CurrentRow.Cells[0].Value.ToString();
            cbMaLoaiSP.Text = dgvHienThiDSSP.CurrentRow.Cells[1].Value.ToString();
            txtTenSP.Text = dgvHienThiDSSP.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHienThiDSSP.CurrentRow.Cells[3].Value.ToString();
            txtMauSac.Text = dgvHienThiDSSP.CurrentRow.Cells[4].Value.ToString();
            txtChatLieu.Text = dgvHienThiDSSP.CurrentRow.Cells[5].Value.ToString();
            txtNguyenLieuChinh.Text = dgvHienThiDSSP.CurrentRow.Cells[6].Value.ToString();
            txtDoDai.Text = dgvHienThiDSSP.CurrentRow.Cells[7].Value.ToString();
            cbMaNCC.Text = dgvHienThiDSSP.CurrentRow.Cells[8].Value.ToString();
        }

        private void dgvHienThiDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHienThiDSSP_CellContentClick(sender, e);
        }
        //Tìm kiếm theo NCC
        //static bool timKiem_MaNCC(string constr, string sMaNCC)
        //{
        //    using (SqlConnection cnn = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = cnn.CreateCommand())
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "sp_TimKiemTheoMaNCC";
        //            cmd.Parameters.AddWithValue("@maNCC", sMaNCC);

        //            cnn.Open();
        //            SqlDataReader rd = cmd.ExecuteReader();
        //            if (rd.Read())
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //            cnn.Close();
        //        }
        //    }
        //}

        private int timKiem_MaNCC()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TimKiemTheoNCC", cnn))
                {
                    string sMaNCC = cbMaNCC.SelectedValue.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNCC", sMaNCC);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvHienThiDSSP.DataSource = tb;
                        int a = dgvHienThiDSSP.Rows.Count - 1;
                        return a;
                    }
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            if (timKiem_MaNCC() > 0)
            {
                txtSL.Text = timKiem_MaNCC().ToString();
            }
            else
            {
                txtSL.Text = 0+"";
            }
        }

        //Sửa SP
        public static bool suaSP(string constr, string sMaSP, string sTenSP, string fDoDai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_suaSP";
                    cmd.Parameters.AddWithValue("@maSP", sMaSP);
                    cmd.Parameters.AddWithValue("@tenSP", sTenSP);
                    cmd.Parameters.AddWithValue("@doDai", fDoDai);
                    //change code
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaSP, sTenSP, fDoDai;

            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            sMaSP = txtMaSP.Text;
            sTenSP = txtTenSP.Text;
            fDoDai = txtDoDai.Text;

            bool i = suaSP(constr, sMaSP, sTenSP, fDoDai);
            if (i)
            {
                MessageBox.Show("Sửa sản phẩm thành công!!!");
                layDSSP_theoView();
            }
            else
            {
                MessageBox.Show("Sửa sp KHÔNG thành công!");
            }
        }
        //Xóa sản phẩm
        public static bool xoaSP(string constr, string sMaSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_xoaSP";
                    cmd.Parameters.AddWithValue("@maSP", sMaSP);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sMaSP;

            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            sMaSP = txtMaSP.Text;

            bool i = xoaSP(constr, sMaSP);
            if (i)
            {
                MessageBox.Show("Xóa sản phẩm thành công!!!");
                layDSSP_theoView();
            }
            else
            {
                MessageBox.Show("Xóa sp KHÔNG thành công!");
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            cbMaLoaiSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtMauSac.Text = "";
            txtMauSac.Text = "";
            txtChatLieu.Text = "";
            txtNguyenLieuChinh.Text = "";
            txtDoDai.Text = "";
            cbMaNCC.Text = "";
            txtSL.Text = "";
        }
    }
}
