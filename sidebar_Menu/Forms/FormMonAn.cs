using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using sidebar_Menu.DAO;

namespace sidebar_Menu.Forms
{
    public partial class FormMonAn : Form
    {
        public FormMonAn()
        {
            InitializeComponent();
        }

        private void MaIDTuTangMonAn()
        {
            string sql = "select mamon from monan";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);

            int i = 1;
            int dem = 0;
            int j = 0;
            foreach (DataRow dr in dt.Rows)
            {
                j++;
                if (j < 10)
                {
                    string text = "FD00";
                    text = text + i;
                    if (text == dr.Field<String>(0))
                    {
                        dem++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    string text = "FD0";
                    text = text + i;
                    if (text == dr.Field<String>(0))
                    {
                        dem++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            if (dem <= dt.Rows.Count)
            {
                if (i < 10)
                {
                    txtMaMonAn.Text = "FD00" + i;
                }
                else
                {
                    txtMaMonAn.Text = "FD0" + i;
                }
            }

        }

        private void LoadDataMonAn()
        {
            cbbNhomTDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dgvTTMonAn.Rows.Clear();
            string sql = "select [manhom],  [mamon], [tenmon],[dvt] , [giatien]  from monan";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                dgvTTMonAn.Rows.Add();
                dgvTTMonAn.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvTTMonAn.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvTTMonAn.Rows[i].Cells[2].Value = dr.Field<string>(1);
                dgvTTMonAn.Rows[i].Cells[3].Value = dr.Field<string>(2);
                dgvTTMonAn.Rows[i].Cells[4].Value = dr.Field<string>(3);
                dgvTTMonAn.Rows[i].Cells[5].Value = dr.Field<decimal>(4);
                i++;
            }
        }

        private void ResetMonAN()
        {
            MaIDTuTangMonAn();
            cbbNhomTDon.Text = "";
            txtTenMonAn.Text = "";
            txtGiaTien.Text = "";
            cbbDVT.Text = "";
        }

        private void TimMaNhom(string tennhom)
        {
            string MaNhomMon = "";
            string a = tennhom;
            string sql = @"select manhom from nhommon where tennhom = N'" + a + "' ";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            MaNhomMon = dt.Rows[0].Field<string>(0);
            //while (reader.Read())
            //{
            //    MaNhomMon = reader[0].ToString();
            //}
            //cnn.Close();

        }

        private void dgvTTMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTTMonAn.Rows[e.RowIndex];

                string MaNhomTD = row.Cells[1].Value.ToString();

                string sqlA = @"select tennhom from nhommon where manhom = N'" + MaNhomTD + "' ";
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery(sqlA);
                cbbNhomTDon.Text = dt.Rows[0].Field<string>(0);
                //SqlCommand cmdA = new SqlCommand(sqlA, cnn);
                //SqlDataReader reader = cmdA.ExecuteReader();
                //while (reader.Read())
                //{
                //    cbbNhomTDon.Text = reader[0].ToString();
                //}

                txtMaMonAn.Text = row.Cells[2].Value.ToString();
                txtTenMonAn.Text = row.Cells[3].Value.ToString();
                cbbDVT.Text = row.Cells[4].Value.ToString();
                txtGiaTien.Text = row.Cells[5].Value.ToString();

            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string MaNhomTD = "";
            string sqlA = @"select manhom from nhommon where tennhom = N'" + cbbNhomTDon.Text + "' ";
            //SqlCommand cmdA = new SqlCommand(sqlA, cnn);
            //SqlDataReader reader = cmdA.ExecuteReader();
            //while (reader.Read())
            //{
            //    MaNhomTD = reader[0].ToString();
            //}
            //cnn.Close();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sqlA);
            MaNhomTD = dt.Rows[0].Field<string>(0);

            string MaMonAn = txtMaMonAn.Text;
            string TenMonAn = txtTenMonAn.Text;
            string DVTinh = cbbDVT.Text;
            int GiaTien = Convert.ToInt32(txtGiaTien.Text);

            string sql = @"INSERT INTO [dbo].[monan] ([mamon], [tenmon], [giatien], [dvt], [manhom]) VALUES ( N'" + MaMonAn + "',N'" + TenMonAn + "','" + GiaTien + "',N'" + DVTinh + "','" + MaNhomTD + "')";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
            MessageBox.Show("Thêm Thành Công", "Thông báo");
            LoadDataMonAn();
            ResetMonAN();
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            string MaNhomTDD = "";
            string sqlA = @"select manhom from nhommon where tennhom = N'" + cbbNhomTDon.Text + "' ";
            //SqlCommand cmdA = new SqlCommand(sqlA, cnn);
            //SqlDataReader reader = cmdA.ExecuteReader();
            //while (reader.Read())
            //{
            //    MaNhomTDD = reader[0].ToString();
            //}
            //cnn.Close();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sqlA);
            MaNhomTDD = dt.Rows[0].Field<string>(0);

            string MaMonAn = txtMaMonAn.Text;
            string TenMonAn = txtTenMonAn.Text;
            string DVTinh = cbbDVT.Text;
            int GiaTien = Convert.ToInt32(txtGiaTien.Text);
            string sql = @"update monan set tenmon = N'" + TenMonAn + "', giatien = '" + GiaTien + "', dvt = N'" + DVTinh + "', manhom = '" + MaNhomTDD + "' where mamon = '" + MaMonAn + "' ";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.ExecuteNonQuery();
            //cnn.Close();
            MessageBox.Show("Cập Nhật Thành Công", "Thông báo");
            LoadDataMonAn();
            ResetMonAN();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {

            int rowindex = dgvTTMonAn.CurrentCell.RowIndex;
            string MaMonAn = dgvTTMonAn.Rows[rowindex].Cells[2].Value.ToString();
            string sqlDelete = @"Delete monan Where mamon = '" + MaMonAn + "'";
            //SqlCommand cmdDelete = new SqlCommand(sqlDelete, cnn);
            //cmdDelete.ExecuteNonQuery();
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
            MessageBox.Show("Xóa thành công!");
            
            LoadDataMonAn();
            ResetMonAN();
        }

        private void TTMonAn_Load(object sender, EventArgs e)
        {
            string sql = @"select tennhom from nhommon";
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //SqlDataReader reader;
            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    cbbNhomTDon.Items.Add(reader[0].ToString());
            //}

            //cnn.Close();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                cbbNhomTDon.Items.Add(dr.Field<string>(0));
            }
            

            LoadDataMonAn();
            MaIDTuTangMonAn();
            LoadtxtTimKiem();
        }
        private void LoadtxtTimKiem()
        {
            AutoCompleteStringCollection timkiem = new AutoCompleteStringCollection();
            string sql = "Select tenmon From monan";
            //SqlDataAdapter da = new SqlDataAdapter("Select tenmon From monan ", cnn);
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                timkiem.Add(dr.Field<string>(0));
            }
            txtTimKiem.AutoCompleteCustomSource = timkiem;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách cần tìm !");
            }
            else
            {
                dgvTTMonAn.Rows.Clear();
                string sql = "Select * From monan Where tenmon like N'" + txtTimKiem.Text + "%'";
                //SqlDataAdapter da = new SqlDataAdapter("Select * From monan Where tenmon like N'" + txtTimKiem.Text + "%'", cnn);
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery(sql);
                dgvTTMonAn.Rows.Add();
                dgvTTMonAn.Rows[0].Cells[0].Value = 1.ToString();
                dgvTTMonAn.Rows[0].Cells[1].Value = dt.Rows[0].Field<string>(0);
                dgvTTMonAn.Rows[0].Cells[2].Value = dt.Rows[0].Field<string>(1);
                dgvTTMonAn.Rows[0].Cells[3].Value = dt.Rows[0].Field<int>(2);
                dgvTTMonAn.Rows[0].Cells[4].Value = dt.Rows[0].Field<string>(3);
                dgvTTMonAn.Rows[0].Cells[5].Value = dt.Rows[0].Field<string>(4);
               
            }
            
        }

        private void cbbNhomTDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhomTDon.Text == "Mì Cay" || cbbNhomTDon.Text == "Đồ Ăn Nhanh" || cbbNhomTDon.Text == "Đồ Ăn Hàn Quốc")
            {
                cbbDVT.Text = "Phần";
            }
            else
            {
                if (cbbNhomTDon.Text == "Trà Sữa")
                {
                    cbbDVT.Text = "Ly";
                }
                else
                    cbbDVT.Text = "Lon";
            }
        }
    }
}
