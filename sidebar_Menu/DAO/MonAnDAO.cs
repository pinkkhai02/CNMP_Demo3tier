using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;

        public static MonAnDAO Instance
        {
            get { if (instance == null) instance = new MonAnDAO(); return MonAnDAO.instance; }
            set { MonAnDAO.instance = value; }
        }
        private MonAnDAO() { }

        public List<MonAn> LayDanhSachMonAnTuMaNhom(string manhom)
        {
            List<MonAn> dsmonan = new List<MonAn>();

            string query = "Select * from monan where manhom = '" + manhom +"' ";

            DataTable data = new DataTable();

            data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonAn monan = new MonAn(item);
                dsmonan.Add(monan);
            }

            return dsmonan;
        }
    }
}
