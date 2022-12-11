using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance 
        { 
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }

        public void GioRa(string sohd)
        {
            string giora = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string query = "UPDATE hoadon SET trangthai = 1, tongtien = " + LuuTongTienVaThanhTien.tongtien + " , giora = '" + giora + "' WHERE sohd = '" + sohd +"' ";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public string LayIDHoaDonUncheckTuIDBan(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM hoadon Where soban =" + id + " AND trangthai = 0");
            if(data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    HoaDon hoadon = new HoaDon(item);
                    return hoadon.Sohd;

                }
            }
            return null;
        }

        public void ThemHoaDon(int id , string manv)
        {
            int i;
            i = LaySoLuongHoaDon();
            string sohd;
            if (i >= 99)
            {
                 sohd = "HD" + (i+1);
            }
            else
            {
                if (i >= 9)
                     sohd = "HD0" + (i+1);

                else
                     sohd = "HD00" + (i+1);
            }
            DataProvider.Instance.ExecuteQuery("EXEC USP_ThemHoaDon @soban , @sohd , @manv , @tongtien ", new object[] { id, sohd , manv , LuuTongTienVaThanhTien.tongtien });
        }
        public int LaySoLuongHoaDon()
        {
            return (int)DataProvider.Instance.ExecuteScalar("Select count(*) from hoadon");
        }
    }
}
