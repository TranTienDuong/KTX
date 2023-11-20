namespace BTL_QuanLiKTX
{
	partial class FormEditSV
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvDSSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.qLKyTucXa = new BTL_QuanLiKTX.QLKyTucXa();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.cmbMaLop = new System.Windows.Forms.ComboBox();
			this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbMaQue = new System.Windows.Forms.ComboBox();
			this.queBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtTensv = new System.Windows.Forms.TextBox();
			this.txtMasv = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.khoaTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.KhoaTableAdapter();
			this.queTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.QueTableAdapter();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sinhVienTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.SinhVienTableAdapter();
			this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXa)).BeginInit();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.queBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDSSinhVien
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDSSinhVien.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDSSinhVien.ColumnHeadersHeight = 15;
			this.dgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDSSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.maqueDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
			this.dgvDSSinhVien.DataSource = this.sinhVienBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDSSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.Location = new System.Drawing.Point(12, 12);
			this.dgvDSSinhVien.Name = "dgvDSSinhVien";
			this.dgvDSSinhVien.RowHeadersVisible = false;
			this.dgvDSSinhVien.Size = new System.Drawing.Size(776, 116);
			this.dgvDSSinhVien.TabIndex = 2;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.Height = 15;
			this.dgvDSSinhVien.ThemeStyle.ReadOnly = false;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.Height = 22;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvDSSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSinhVien_CellContentClick);
			// 
			// qLKyTucXa
			// 
			this.qLKyTucXa.DataSetName = "QLKyTucXa";
			this.qLKyTucXa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHuy.Location = new System.Drawing.Point(417, 429);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(128, 32);
			this.btnHuy.TabIndex = 10;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSua.Location = new System.Drawing.Point(254, 429);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(128, 32);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa thông tin";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.cmbMaLop);
			this.guna2GroupBox1.Controls.Add(this.cmbMaKhoa);
			this.guna2GroupBox1.Controls.Add(this.cmbMaQue);
			this.guna2GroupBox1.Controls.Add(this.cmbGioiTinh);
			this.guna2GroupBox1.Controls.Add(this.dtpNgaySinh);
			this.guna2GroupBox1.Controls.Add(this.txtTensv);
			this.guna2GroupBox1.Controls.Add(this.txtMasv);
			this.guna2GroupBox1.Controls.Add(this.label7);
			this.guna2GroupBox1.Controls.Add(this.label6);
			this.guna2GroupBox1.Controls.Add(this.label5);
			this.guna2GroupBox1.Controls.Add(this.label4);
			this.guna2GroupBox1.Controls.Add(this.label3);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.Controls.Add(this.label1);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(12, 145);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(776, 263);
			this.guna2GroupBox1.TabIndex = 7;
			this.guna2GroupBox1.Text = "Thông Tin Sinh Viên";
			// 
			// cmbMaLop
			// 
			this.cmbMaLop.FormattingEnabled = true;
			this.cmbMaLop.Location = new System.Drawing.Point(529, 155);
			this.cmbMaLop.Name = "cmbMaLop";
			this.cmbMaLop.Size = new System.Drawing.Size(224, 30);
			this.cmbMaLop.TabIndex = 13;
			// 
			// cmbMaKhoa
			// 
			this.cmbMaKhoa.DataSource = this.khoaBindingSource;
			this.cmbMaKhoa.DisplayMember = "Makhoa";
			this.cmbMaKhoa.FormattingEnabled = true;
			this.cmbMaKhoa.Location = new System.Drawing.Point(532, 105);
			this.cmbMaKhoa.Name = "cmbMaKhoa";
			this.cmbMaKhoa.Size = new System.Drawing.Size(224, 30);
			this.cmbMaKhoa.TabIndex = 12;
			this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged);
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.qLKyTucXa;
			// 
			// cmbMaQue
			// 
			this.cmbMaQue.DataSource = this.queBindingSource;
			this.cmbMaQue.DisplayMember = "Maque";
			this.cmbMaQue.FormattingEnabled = true;
			this.cmbMaQue.Location = new System.Drawing.Point(532, 57);
			this.cmbMaQue.Name = "cmbMaQue";
			this.cmbMaQue.Size = new System.Drawing.Size(224, 30);
			this.cmbMaQue.TabIndex = 11;
			// 
			// queBindingSource
			// 
			this.queBindingSource.DataMember = "Que";
			this.queBindingSource.DataSource = this.qLKyTucXa;
			// 
			// cmbGioiTinh
			// 
			this.cmbGioiTinh.FormattingEnabled = true;
			this.cmbGioiTinh.Location = new System.Drawing.Point(146, 201);
			this.cmbGioiTinh.Name = "cmbGioiTinh";
			this.cmbGioiTinh.Size = new System.Drawing.Size(224, 30);
			this.cmbGioiTinh.TabIndex = 10;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(146, 153);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(224, 29);
			this.dtpNgaySinh.TabIndex = 9;
			// 
			// txtTensv
			// 
			this.txtTensv.Location = new System.Drawing.Point(146, 105);
			this.txtTensv.Name = "txtTensv";
			this.txtTensv.Size = new System.Drawing.Size(224, 29);
			this.txtTensv.TabIndex = 8;
			// 
			// txtMasv
			// 
			this.txtMasv.Location = new System.Drawing.Point(146, 57);
			this.txtMasv.Name = "txtMasv";
			this.txtMasv.Size = new System.Drawing.Size(224, 29);
			this.txtMasv.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(401, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 22);
			this.label7.TabIndex = 6;
			this.label7.Text = "Mã khoa :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(401, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mã lớp :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(401, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mã quê :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(15, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giới tính :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(15, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(15, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên sinh viên :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(15, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sinh viên :";
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// queTableAdapter
			// 
			this.queTableAdapter.ClearBeforeFill = true;
			// 
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.qLKyTucXa;
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// masinhvienDataGridViewTextBoxColumn
			// 
			this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
			// 
			// tensinhvienDataGridViewTextBoxColumn
			// 
			this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
			// 
			// ngaysinhDataGridViewTextBoxColumn
			// 
			this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
			// 
			// gioitinhDataGridViewTextBoxColumn
			// 
			this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
			// 
			// maqueDataGridViewTextBoxColumn
			// 
			this.maqueDataGridViewTextBoxColumn.DataPropertyName = "Maque";
			this.maqueDataGridViewTextBoxColumn.HeaderText = "Maque";
			this.maqueDataGridViewTextBoxColumn.Name = "maqueDataGridViewTextBoxColumn";
			// 
			// makhoaDataGridViewTextBoxColumn
			// 
			this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.HeaderText = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
			// 
			// malopDataGridViewTextBoxColumn
			// 
			this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
			this.malopDataGridViewTextBoxColumn.HeaderText = "Malop";
			this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
			// 
			// FormEditSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 480);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.dgvDSSinhVien);
			this.Name = "FormEditSV";
			this.Text = "FormEditSV";
			this.Load += new System.EventHandler(this.FormEditSV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXa)).EndInit();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.queBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView dgvDSSinhVien;
		private QLKyTucXa qLKyTucXa;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnSua;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.ComboBox cmbMaLop;
		private System.Windows.Forms.ComboBox cmbMaKhoa;
		private System.Windows.Forms.ComboBox cmbMaQue;
		private System.Windows.Forms.ComboBox cmbGioiTinh;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.TextBox txtTensv;
		private System.Windows.Forms.TextBox txtMasv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private QLKyTucXaTableAdapters.KhoaTableAdapter khoaTableAdapter;
		private System.Windows.Forms.BindingSource queBindingSource;
		private QLKyTucXaTableAdapters.QueTableAdapter queTableAdapter;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private QLKyTucXaTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maqueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
	}
}