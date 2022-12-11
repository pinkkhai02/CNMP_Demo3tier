using sidebar_Menu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sidebar_Menu.Forms
{
    public partial class FormNhanVien : Form
    {
        // form chính
        public FormNhanVien()
        {
            InitializeComponent();
            
        }

        private void MaIDTuTangNhanVien()
        {
            string sql = "select manv from nhanvien";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            int i = 1;
            int dem = 0;
            int j = 0;
            foreach (DataRow dr in dt.Rows)
            {
                j++;
                if (j < 10)
                {
                    string text = "NV00";
                    text = text + i;
                    if (text == dr.Field<String>(0))
                    {
                        dem++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    string text = "NV0";
                    text = text + i;
                    if (text == dr.Field<String>(0))
                    {
                        dem++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            if (dem <= dt.Rows.Count)
            {
                if (i < 10)
                {
                    txtMaNV.Text = "NV00" + i;
                }
                else
                {
                    txtMaNV.Text = "NV0" + i;
                }
            }

        }
        private void LoadDataNhanVien()
        {
            dgvTTNVien.Rows.Clear();
            string sql = "select * from nhanvien";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                dgvTTNVien.Rows.Add();
                dgvTTNVien.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvTTNVien.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvTTNVien.Rows[i].Cells[2].Value = dr.Field<string>(1);
                dgvTTNVien.Rows[i].Cells[3].Value = dr.Field<DateTime>(2);
                dgvTTNVien.Rows[i].Cells[4].Value = dr.Field<string>(3);
                dgvTTNVien.Rows[i].Cells[5].Value = dr.Field<string>(4);
                dgvTTNVien.Rows[i].Cells[6].Value = dr.Field<int>(5);
                dgvTTNVien.Rows[i].Cells[7].Value = dr.Field<string>(6);
                dgvTTNVien.Rows[i].Cells[8].Value = dr.Field<string>(7);
                i++;
            }
        }
        private void ReSetNV()
        {
            MaIDTuTangNhanVien();
            txtName.Text = "";
            dtDate.Text = "";
            rbtnMale.Checked = true;
            txtAddress.Text = "";
            txtPhone.Text = "";
            cbPosition.Text = "";
            txtMKhau.Text = "";
        }
        private void ThemTaiKhoan(string IDNhanVien, string MKhau, string chucvu)
        {
            string type = "true";
            if(chucvu == "Quản Lý")
            {
                type = "true";
            }else if(chucvu == "Nhân Viên")
            {
                type = "false";
            }
            string sql = @"insert into taikhoan (name, IDNhanVien, pass, Type)"+
                " values ('"+ IDNhanVien +"', '"+ IDNhanVien +"','"+ MKhau +"','"+ type +"')";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
        }

        private void CapNhatTaiKhoan(string IDNhanVien, string MKhau, string chucvu)
        {
            string type = "true";
            if (chucvu == "Quản Lý")
            {
                type = "true";
            }
            else if (chucvu == "Nhân Viên")
            {
                type = "false";
            }
            string sql = @"update taikhoan set name = '" + IDNhanVien + "', pass = '" + MKhau + "' , Type = N'" + type + "' Where IDNhanVien = '" + IDNhanVien + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string TenNV = txtName.Text;
            string Date = dtDate.Text;
            string GioiTinh = "";
            if (rbtnFemale.Checked == true)
            {
                GioiTinh = "Nữ";
            }
            else if (rbtnMale.Checked == true)
            {
                GioiTinh = "Nam";
            }
            string DiaChi = txtAddress.Text;
            int sdt = Convert.ToInt32(txtPhone.Text);
            string ChucVu = cbPosition.Text;
            string MatKhau = txtMKhau.Text;
            
            
            string sql = @"INSERT INTO nhanvien ([manv], [tennv], [ngaysinh], [gioitinh], [diachi], [sdt], [chucvu], [matkhau]) " +
                            "values ('" + MaNV + "',N'" + TenNV + "','" + Date + "',N'" + GioiTinh + "',N'" + DiaChi + "','" + sdt + "',N'" + ChucVu + "','" + MatKhau + "')";

            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);

            MessageBox.Show("Thêm Thành Công", "Thông Báo");

            ThemTaiKhoan(MaNV, MatKhau, ChucVu);
            LoadDataNhanVien();
            ReSetNV();

            
        }

        private void TTNVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvTTNVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                dtDate.Text = row.Cells[3].Value.ToString();
                if (rbtnFemale.Text == row.Cells[4].Value.ToString())
                {
                    rbtnFemale.Checked = true;

                }
                else if (rbtnMale.Text == row.Cells[4].Value.ToString())
                {
                    rbtnMale.Checked = true;
                }

                txtAddress.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[6].Value.ToString();
                cbPosition.Text = row.Cells[7].Value.ToString();
                txtMKhau.Text = row.Cells[8].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string TenNV = txtName.Text;
            string Date = dtDate.Text;
            string GioiTinh = "";
            if (rbtnFemale.Checked == true)
            {
                GioiTinh = "Nữ";
            }
            else if (rbtnMale.Checked == true)
            {
                GioiTinh = "Nam";
            }
            string DiaChi = txtAddress.Text;
            int sdt = Convert.ToInt32(txtPhone.Text);
            string ChucVu = cbPosition.Text;
            string MatKhau = txtMKhau.Text;
            string sqlUpdate = @" update nhanvien set tennv = N'" + TenNV + "', ngaysinh = '" + Date + "', gioitinh = N'" + GioiTinh + "', diachi = N'" + DiaChi + "', sdt = '" + sdt + "', chucvu = N'" + ChucVu + "', matkhau = '" + MatKhau + "' where manv = '" + MaNV + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sqlUpdate);

            CapNhatTaiKhoan(MaNV, MatKhau, ChucVu);
            LoadDataNhanVien();
            MessageBox.Show("Cập Nhật Thành Công.");
            ReSetNV();
        }

        private void XoaTaiKhoan(string IDNV)
        {

            string sqlDelete = @"Delete taikhoan Where IDNhanVien = '" + IDNV + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            int rowindex = dgvTTNVien.CurrentCell.RowIndex;
            string MaNV = dgvTTNVien.Rows[rowindex].Cells[1].Value.ToString();
            XoaTaiKhoan(MaNV);
            string sqlDelete = @"Delete nhanvien Where manv = '" + MaNV + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
            MessageBox.Show("Xóa thành công!");
            LoadDataNhanVien();
            ReSetNV();
        }

        private void TTNVien_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
            MaIDTuTangNhanVien();
            LoadtxtTimKiem();
        }
        private void LoadtxtTimKiem()
        {
            AutoCompleteStringCollection timkiem = new AutoCompleteStringCollection();

            string sql = "Select tennv From nhanvien ";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                timkiem.Add(dr.Field<string>(0));
            }
            txtTimKiem.AutoCompleteCustomSource = timkiem;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách cần tìm !");
            }
            else
            {
                dgvTTNVien.Rows.Clear();
                string sql = "Select * From nhanvien Where tennv like N'" + txtTimKiem.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery(sql);
                dgvTTNVien.Rows.Add();
                dgvTTNVien.Rows[0].Cells[0].Value = 1.ToString();
                dgvTTNVien.Rows[0].Cells[1].Value = dt.Rows[0].Field<string>(0);
                dgvTTNVien.Rows[0].Cells[2].Value = dt.Rows[0].Field<string>(1);
                dgvTTNVien.Rows[0].Cells[3].Value = dt.Rows[0].Field<DateTime>(2);
                dgvTTNVien.Rows[0].Cells[4].Value = dt.Rows[0].Field<string>(3);
                dgvTTNVien.Rows[0].Cells[5].Value = dt.Rows[0].Field<string>(4);
                dgvTTNVien.Rows[0].Cells[6].Value = dt.Rows[0].Field<int>(5);
                dgvTTNVien.Rows[0].Cells[7].Value = dt.Rows[0].Field<string>(6);
                dgvTTNVien.Rows[0].Cells[8].Value = dt.Rows[0].Field<string>(7);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvTTNVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
