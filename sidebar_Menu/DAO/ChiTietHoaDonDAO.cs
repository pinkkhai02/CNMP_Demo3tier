using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance 
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAO();return ChiTietHoaDonDAO.instance; }
            set { ChiTietHoaDonDAO.instance = value; }
        }

        private ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> LayDanhSachChiTietHoaDonTuSoHd(string sohd)
        {
            List<ChiTietHoaDon> dshoadon = new List<ChiTietHoaDon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM chitiethoadon WHERE sohd = '" + sohd + "' and trangthai = 0 ");

            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon cthoadon = new ChiTietHoaDon(item);
                dshoadon.Add(cthoadon);
            }

            return dshoadon;
        }

        public void ThemChiTietHoaDon(string sohd, string mamon, int soluong , decimal giatien, decimal thanhtien)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_ThemChiTietHoaDon @sohd , @mamon , @soluong , @giatien , @thanhtien", new object[] { sohd, mamon, soluong , giatien, thanhtien});
        }

    }
}
