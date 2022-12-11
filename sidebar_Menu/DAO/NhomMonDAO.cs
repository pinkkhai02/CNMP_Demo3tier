using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DAO
{
    public class NhomMonDAO
    {
        private static NhomMonDAO instance;

        public static NhomMonDAO Instance 
        {
            get { if (instance == null) instance = new NhomMonDAO();return NhomMonDAO.instance; }
            set { NhomMonDAO.instance = value; }
        }
        private NhomMonDAO() { }

        public List<NhomMon> LayDanhSachNhomMon()
        {
            List<NhomMon> dsnhommon = new List<NhomMon>();

            string query = "Select * from nhommon";

            DataTable data = new DataTable();

            data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhomMon nhommon = new NhomMon(item);
                dsnhommon.Add(nhommon);
            }

            return dsnhommon;
        }
    }
}
