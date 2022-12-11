using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(int id, string sohd, string mamon, int soluong)
        {
            this.Id = id;
            this.Sohd = sohd;
            this.Mamon = mamon;
            this.Soluong = soluong;
        }

        public ChiTietHoaDon(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Sohd = (string)row["sohd"];
            this.Mamon = (string)row["mamon"];
            this.Soluong = (int)row["soluong"];
        }

        private int soluong;

        public int Soluong { get => soluong; set => soluong = value; }

        private string mamon;

        public string Mamon { get => mamon; set => mamon = value; }

        private string sohd;

        public string Sohd { get => sohd; set => sohd = value; }

        private int id;

        public int Id { get => id; set => id = value; }
        
    }
}
