using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private bool loaiMatKhau;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool LoaiMatKhau { get => loaiMatKhau; set => loaiMatKhau = value; }

        public TaiKhoan(string tenTaiKhoan, string matkhau, bool loaiMatKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matkhau;
            this.LoaiMatKhau = loaiMatKhau;
        }
    }
}
