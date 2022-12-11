using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sidebar_Menu.DAO
{
     public class BanDAO
     {
        private static BanDAO instance;

        public static BanDAO Instance 
        {
            get { if(instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; } 
        }

        public static int ChieuDaiBan = 135;
        public static int ChieuRongBan = 135;

        private BanDAO() { }

        public List<Ban> LoadDanhSachBan()
        {
            List<Ban> dsban = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_DANHSACHBAN");

            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                dsban.Add(ban);
            }

            return dsban;
        }

    }
}
