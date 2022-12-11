using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DTO
{
    public class MonAn
    {
        private MonAn(string mamon, string tenmon, decimal giatien, string dvt)
        {
            this.Mamon = mamon;
            this.Tenmon = tenmon;
            this.Giatien = giatien;
            this.Dvt = dvt;
        }

        public MonAn(DataRow row)
        {
            this.Mamon = (string)row["mamon"];
            this.Tenmon = (string)row["tenmon"];
            this.Giatien = (decimal)row["giatien"];
            this.Dvt = (string)row["dvt"];
        }

        private string dvt;

        public string Dvt { get => dvt; set => dvt = value; }

        private decimal giatien;

        public decimal Giatien { get => giatien; set => giatien = value; }

        private string tenmon;

        public string Tenmon { get => tenmon; set => tenmon = value; }

        private string mamon;

        public string Mamon { get => mamon; set => mamon = value; }
        
        
        
        
    }
}
