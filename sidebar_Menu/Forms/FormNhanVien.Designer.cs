
namespace sidebar_Menu.Forms
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTTNVien = new System.Windows.Forms.DataGridView();
            this.txtMKhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNVien)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(696, 170);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm Kiếm Tên Nhân Viên";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(227, 45);
            this.txtTimKiem.TabIndex = 27;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvTTNVien
            // 
            this.dgvTTNVien.AllowUserToAddRows = false;
            this.dgvTTNVien.AllowUserToDeleteRows = false;
            this.dgvTTNVien.AllowUserToResizeColumns = false;
            this.dgvTTNVien.AllowUserToResizeRows = false;
            this.dgvTTNVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTTNVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTNVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTTNVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvTTNVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTNVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTTNVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(158)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTNVien.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTTNVien.EnableHeadersVisualStyles = false;
            this.dgvTTNVien.GridColor = System.Drawing.Color.Black;
            this.dgvTTNVien.Location = new System.Drawing.Point(23, 321);
            this.dgvTTNVien.Name = "dgvTTNVien";
            this.dgvTTNVien.RowHeadersVisible = false;
            this.dgvTTNVien.RowHeadersWidth = 51;
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTTNVien.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTNVien.RowTemplate.Height = 24;
            this.dgvTTNVien.RowTemplate.ReadOnly = true;
            this.dgvTTNVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTNVien.Size = new System.Drawing.Size(1321, 370);
            this.dgvTTNVien.TabIndex = 50;
            this.dgvTTNVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TTNVien_CellClick);
            this.dgvTTNVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTNVien_CellContentClick);
            // 
            // txtMKhau
            // 
            this.txtMKhau.Location = new System.Drawing.Point(424, 183);
            this.txtMKhau.Name = "txtMKhau";
            this.txtMKhau.Size = new System.Drawing.Size(219, 30);
            this.txtMKhau.TabIndex = 26;
            this.txtMKhau.TextChanged += new System.EventHandler(this.txtMKhau_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(320, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 36);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mật Khẩu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(424, 102);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 30);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(424, 60);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(219, 30);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 22;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.ForeColor = System.Drawing.Color.Black;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.IntegralHeight = false;
            this.cbPosition.ItemHeight = 23;
            this.cbPosition.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cbPosition.Location = new System.Drawing.Point(424, 144);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(219, 31);
            this.cbPosition.TabIndex = 19;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.BackColor = System.Drawing.Color.White;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(202, 183);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(83, 36);
            this.rbtnFemale.TabIndex = 18;
            this.rbtnFemale.Text = "Nữ";
            this.rbtnFemale.UseVisualStyleBackColor = false;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // rbtnMale
            // 
            this.rbtnMale.BackColor = System.Drawing.Color.White;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(125, 182);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(71, 36);
            this.rbtnMale.TabIndex = 17;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Nam";
            this.rbtnMale.UseVisualStyleBackColor = false;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.DisabledState.Parent = this.btnTimKiem;
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimKiem.Location = new System.Drawing.Point(933, 170);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(141, 45);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(320, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chức Vụ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.Location = new System.Drawing.Point(952, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(122, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.txtTimKiem);
            this.guna2GroupBox1.Controls.Add(this.txtMKhau);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.txtPhone);
            this.guna2GroupBox1.Controls.Add(this.txtAddress);
            this.guna2GroupBox1.Controls.Add(this.txtName);
            this.guna2GroupBox1.Controls.Add(this.dtDate);
            this.guna2GroupBox1.Controls.Add(this.cbPosition);
            this.guna2GroupBox1.Controls.Add(this.rbtnFemale);
            this.guna2GroupBox1.Controls.Add(this.rbtnMale);
            this.guna2GroupBox1.Controls.Add(this.btnTimKiem);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.btnXoa);
            this.guna2GroupBox1.Controls.Add(this.btnSua);
            this.guna2GroupBox1.Controls.Add(this.btnThem);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(23, 35);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1321, 261);
            this.guna2GroupBox1.TabIndex = 51;
            this.guna2GroupBox1.Text = "Thông Tin Nhân Viên";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(125, 60);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(160, 30);
            this.txtMaNV.TabIndex = 28;
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "yyyy/MM/dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(125, 141);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(160, 30);
            this.dtDate.TabIndex = 20;
            this.dtDate.Value = new System.DateTime(2000, 12, 7, 19, 22, 0, 0);
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.DisabledState.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.Location = new System.Drawing.Point(824, 60);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(122, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.Location = new System.Drawing.Point(696, 60);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(122, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(320, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "SĐT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(320, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa Chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới Tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã NV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Column9
            // 
            this.Column9.FillWeight = 79.01917F;
            this.Column9.HeaderText = "STT";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 96.25666F;
            this.Column4.HeaderText = "Mã Nhân Viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 78.34853F;
            this.Column6.HeaderText = "Họ Tên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 63.65818F;
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 63.65818F;
            this.Column7.HeaderText = "Giới Tính";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 269.3232F;
            this.Column1.HeaderText = "Địa Chỉ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 58.76141F;
            this.Column2.HeaderText = "SĐT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 93.03889F;
            this.Column3.HeaderText = "Chức Vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 97.93568F;
            this.Column8.HeaderText = "Mật Khẩu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 727);
            this.Controls.Add(this.dgvTTNVien);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.TTNVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNVien)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvTTNVien;
        private System.Windows.Forms.TextBox txtMKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}