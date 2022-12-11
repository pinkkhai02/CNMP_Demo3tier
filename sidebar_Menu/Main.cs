using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebar_Menu
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int temIndex;
        private Form activeForm;

        public Main()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (temIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            temIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                }
            }
            
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 174, 0);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBanHang(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNhanVien(), sender);
        }

        private void btnKhanhHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNhomThucPham(), sender);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMonAn(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBan(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ThongKe(), sender);
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Trang Chủ"; 
            currentButton = null;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hệ thống quản lý?", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //code Dang Nhap

        public bool isThoat = true; //(6)

        public event EventHandler DangXuat; //(5)

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        void PhanQuyen()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-C45AB4E\SQLEXPRESS;Initial Catalog=Max_QueryQLMICAYCAY;Persist Security Info=True;User ID=sa; Password = 123");
            lbUser.Text = "";
            string user = "";
            string nameUser = Const.username;
            cnn.Open();
            string sqlA = @"select IDNhanVien from taikhoan where name = '" + nameUser + "' ";
            SqlCommand cmdA = new SqlCommand(sqlA, cnn);
            SqlDataReader reader = cmdA.ExecuteReader();
            while (reader.Read())
            {
                user = reader[0].ToString();

            }
            cnn.Close();
            cnn.Open();
            string sql = @"select tennv, chucvu from nhanvien where manv = '" + user + "' ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader readerr = cmd.ExecuteReader();
            while (readerr.Read())
            {
                lbUser.Text = readerr[0].ToString() + Environment.NewLine + readerr[1].ToString();

            }
            cnn.Close();


            if (Const.LoaiTaiKhoan == false)
            {
                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }
    }
}
