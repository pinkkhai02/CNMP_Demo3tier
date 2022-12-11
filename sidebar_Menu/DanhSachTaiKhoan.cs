using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidebar_Menu
{
    public class DanhSachTaiKhoan
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-C45AB4E\SQLEXPRESS;Initial Catalog=Max_QueryQLMICAYCAY;Persist Security Info=True;User ID=sa; Password = 123");
        private static DanhSachTaiKhoan instance;

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }

        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }

            set => instance = value;
        }

        public DanhSachTaiKhoan()
        {
            string Name = "";
            string Pass = "";
            bool Type;

            listTaiKhoan = new List<TaiKhoan>();
            cnn.Open();
            string sqlA = @"select name, pass, Type from taikhoan ";
            SqlCommand cmdA = new SqlCommand(sqlA, cnn);
            SqlDataReader reader = cmdA.ExecuteReader();
            while (reader.Read())
            {
                Name = reader[0].ToString();
                Pass = reader[1].ToString();
                Type = Convert.ToBoolean(reader[2].ToString());

                listTaiKhoan.Add(new TaiKhoan(Name, Pass, Type));
            }
            cnn.Close();

            //listTaiKhoan = new List<TaiKhoan>();
            //listTaiKhoan.Add(new TaiKhoan("abc", "123"));
            //listTaiKhoan.Add(new TaiKhoan("khanh", "111"));
            //listTaiKhoan.Add(new TaiKhoan("robot", "101"));
        }
    }
}
