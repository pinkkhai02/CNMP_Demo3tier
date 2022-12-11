using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebar_Menu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ktraDangNhap(txtUserName.Text, txtPassword.Text))  //(4)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
                main.DangXuat += Main_DangXuat; //+= tab tab (8)
                ResetDN();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông Báo");
                ResetDN();
                txtUserName.Focus();
            }
        }

        private void Main_DangXuat(object sender, EventArgs e)
        {
            (sender as Main).isThoat = false;
            (sender as Main).Close();
            this.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        bool ktraDangNhap(string taikhoan, string matkhau) //(3)
        {
            //if(tenTaiKhoan == taikhoan && MatKhau == matkhau)
            //{
            //    return true;
            //}

            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (taikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                {
                    Const.LoaiTaiKhoan = listTaiKhoan[i].LoaiMatKhau;
                    Const.username = listTaiKhoan[i].TenTaiKhoan;

                    return true;
                }
            }

            return false;
        }

        private void ResetDN()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";

        }
    }
}
