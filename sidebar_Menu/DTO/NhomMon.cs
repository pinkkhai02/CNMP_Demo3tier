using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DTO
{
    public class NhomMon
    {
        private NhomMon(string manhom, string tennhom)
        {
            this.Manhom = manhom;
            this.Tennhom = tennhom;
        }

        public NhomMon(DataRow row)
        {
            this.Manhom = (string)row["manhom"];
            this.Tennhom = (string)row["tennhom"];
        }

        private string tennhom;

        public string Tennhom { get => tennhom; set => tennhom = value; }


        private string manhom;

        public string Manhom { get => manhom; set => manhom = value; }
        
    }
}
