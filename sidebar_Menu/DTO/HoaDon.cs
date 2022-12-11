using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DTO
{
    public class HoaDon
    {
        private HoaDon(string sohd, DateTime giovao, DateTime giora, int trangthai)
        {
            this.Sohd = sohd;
            this.Giovao = giovao;
            this.Giora = giora;
            this.Trangthai = trangthai;
        }

        public HoaDon(DataRow row)
        {
            this.Sohd = (string)row["sohd"];
            this.Giovao = (DateTime?)row["giovao"];

            var gioraTemp = row["giora"];
            if (gioraTemp.ToString() != "")
                this.Giora = (DateTime?)gioraTemp;

            this.Trangthai = (int)row["trangthai"];
        }

        private int trangthai;

        public int Trangthai { get => trangthai; set => trangthai = value; }

        private DateTime? giora;

        public DateTime? Giora { get => giora; set => giora = value; }

        private DateTime? giovao;

        public DateTime? Giovao { get => giovao; set => giovao = value; }
        

        private string sohd;

        public string Sohd { get => sohd; set => sohd = value; }


    }
}
