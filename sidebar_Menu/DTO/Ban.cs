using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DTO
{
    public class Ban
    {
        public Ban(int id, string tenban, string trangthai)
        {
            this.Id = id;
            this.Tenban = tenban;
            this.Trangthai = trangthai;
        }

        public Ban(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenban = row["tenban"].ToString();
            this.Trangthai = row["trangthai"].ToString();
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        private string tenban;

        public string Tenban
        {
            get { return tenban; }
            set { tenban = value; }
        }


        private string trangthai;

        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
