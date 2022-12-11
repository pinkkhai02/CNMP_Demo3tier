using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DTO
{
    public class Menu
    {
        public Menu(string tenmon, int soluong, decimal giatien, string dvt, decimal tongtien = 0)
        {
            this.Tenmon = tenmon;
            this.Soluong = soluong;
            this.Giatien = giatien;
            this.Dvt = dvt;
            this.Tongtien = tongtien;
        }

        public Menu(DataRow row)
        {
            this.Tenmon = (string)row["tenmon"];
            this.Soluong = (int)row["soluong"];
            this.Giatien = (decimal)row["giatien"];
            this.Dvt = (string)row["dvt"];
            this.Tongtien = (decimal)row["tongtien"];
        }

        private decimal tongtien;

        public decimal Tongtien { get => tongtien; set => tongtien = value; }

        private string dvt;

        public string Dvt { get => dvt; set => dvt = value; }

        private decimal giatien;

        public decimal Giatien { get => giatien; set => giatien = value; }

        private int soluong;

        public int Soluong { get => soluong; set => soluong = value; }

        private string tenmon;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        
        
        
    }
}
