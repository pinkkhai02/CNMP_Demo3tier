using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return  MenuDAO.instance; }
            set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> LayDanhSachMenuTuIDBan(int id)
        {
            List<Menu> dsmenu = new List<Menu>();

            DataTable data = new DataTable();

            string query = "SELECT ma.tenmon, ma.dvt, cthd.soluong, ma.giatien, ma.giatien * cthd.soluong as tongtien FROM chitiethoadon as cthd, hoadon as hd, monan as ma " +
                "WHERE cthd.sohd = hd.sohd AND cthd.mamon = ma.mamon AND hd.trangthai = 0 AND hd.soban = " + id;

            data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                dsmenu.Add(menu); 
            }

            return dsmenu;
        }
    }
}
