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
    public partial class Loại_SP : Form
    {
        public Loại_SP()
        {
            InitializeComponent();
        }

        private void Loại_SP_Load(object sender, EventArgs e)
        {
            layDSLoaiSP_theoView();
        }

        //Hiện ds theo view
        private void layDSLoaiSP_theoView()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_layDSLoaiSP", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvDSLoaiSP.DataSource = tb;
                    }
                }
            }
        }

        private void dgvDSLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiSP.Text = dgvDSLoaiSP.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiSP.Text = dgvDSLoaiSP.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvDSLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSLoaiSP_CellContentClick(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        //Thêm Loại SP
        public static bool themLoaiSP(string constr, string sMaLoaiSP, string sTenLoai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_themLoaiSP";
                    cmd.Parameters.AddWithValue("@maLoaiSP", sMaLoaiSP);
                    cmd.Parameters.AddWithValue("@tenLoai", sTenLoai);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaLoaiSP, sTenLoai;

            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            sMaLoaiSP = txtMaLoaiSP.Text;
            if ((timKiem_MaLoaiSP(constr, sMaLoaiSP) == true))
            {
                DialogResult result = MessageBox.Show("Mã loại sản phẩm đã tồn tại! Mời bạn kiểm tra lại khóa chính", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            sTenLoai = txtTenLoaiSP.Text;
            bool i = themLoaiSP(constr, sMaLoaiSP, sTenLoai);
            if (i)
            {
                MessageBox.Show("Thêm loại sản phẩm thành công!!!");
                layDSLoaiSP_theoView();
            }
            else
            {
                MessageBox.Show("Thêm loại sản phẩm không thành công!!!");
            }
        }

        //Tìm kiếm mã loại SP
        static bool timKiem_MaLoaiSP(string constr, string sMaLoaiSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_timMaLoaiSP", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_timMaLoaiSP";
                    cmd.Parameters.AddWithValue("@maLoaiSP", sMaLoaiSP);

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

        //Sửa tên loại SP
        public static bool suaTenLoaiSP(string constr, string sMaLoaiSP, string sTenLoai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_suaTenLoaiSP";
                    cmd.Parameters.AddWithValue("@maLoaiSP", sMaLoaiSP);
                    cmd.Parameters.AddWithValue("@tenLoai", sTenLoai);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaLoaiSP, sTenLoai;
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            sMaLoaiSP = txtMaLoaiSP.Text;
            sTenLoai = txtTenLoaiSP.Text;
            bool i = suaTenLoaiSP(constr, sMaLoaiSP, sTenLoai);
            if (i)
            {
                MessageBox.Show("Sửa tên loại sản phẩm thành công!!!");
                layDSLoaiSP_theoView();
            }
            else
            {
                MessageBox.Show("Sửa tên loại sản phẩm không thành công!!!");
            }
        }

        //Xóa loại SP
        public static bool xoaLoaiSP_TheoMaLoai(string constr, string sMaLoaiSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_xoaLoaiSPTheoMaLoai";
                    cmd.Parameters.AddWithValue("@maLoaiSP", sMaLoaiSP);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sMaLoaiSP;
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            sMaLoaiSP = txtMaLoaiSP.Text;

            bool i = xoaLoaiSP_TheoMaLoai(constr, sMaLoaiSP);
            if (i)
            {
                MessageBox.Show("Xóa loại sản phẩm thành công!!!");
                layDSLoaiSP_theoView();
            }
            else
            {
                MessageBox.Show("Xóa loại sản phẩm không thành công!!!");
            }
        }

        //Tìm kiếm theo mã
        private int timKiemLoaiSP_theoMaLoai()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_timMaLoaiSP", cnn))
                {
                    string sMaLoaiSP = txtMaLoaiSP.Text;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maLoaiSP", sMaLoaiSP);

                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvDSLoaiSP.DataSource = tb;
                        int a = dgvDSLoaiSP.Rows.Count - 1;
                        return a;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLyBanTrangSuc_Nhom9"].ConnectionString;

            if(timKiemLoaiSP_theoMaLoai() > 0)
            {
                txtSL.Text = timKiemLoaiSP_theoMaLoai().ToString();
            }
            else
            {
                txtSL.Text = 0+"";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaLoaiSP.Text = "";
            txtTenLoaiSP.Text = "";
            txtSL.Text = "";
        }
    }
}
