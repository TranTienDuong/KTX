namespace BTL_QuanLiKTX
{
	partial class FormMainQLSV
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tìmKiếmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.qLKyTucXa = new BTL_QuanLiKTX.QLKyTucXa();
			this.sinhVienTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.SinhVienTableAdapter();
			this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvDSSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnLivingKTX = new System.Windows.Forms.Button();
			this.sinhViênĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sinhViênTrảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmSinhViênToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.sinhViênĐặtPhòngToolStripMenuItem,
            this.sinhViênTrảPhòngToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tìmKiếmSinhViênToolStripMenuItem
			// 
			this.tìmKiếmSinhViênToolStripMenuItem.Name = "tìmKiếmSinhViênToolStripMenuItem";
			this.tìmKiếmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.tìmKiếmSinhViênToolStripMenuItem.Text = "Tìm Kiếm Sinh Viên";
			this.tìmKiếmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmSinhViênToolStripMenuItem_Click);
			// 
			// thêmToolStripMenuItem
			// 
			this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
			this.thêmToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.thêmToolStripMenuItem.Text = "Thêm Sinh Viên";
			this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
			// 
			// sửaToolStripMenuItem
			// 
			this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
			this.sửaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.sửaToolStripMenuItem.Text = "Sửa Thông Tin Sinh Viên";
			this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
			// 
			// xuấtExcelToolStripMenuItem
			// 
			this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
			this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel DS Sinh Viên";
			this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
			// 
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.qLKyTucXa;
			// 
			// qLKyTucXa
			// 
			this.qLKyTucXa.DataSetName = "QLKyTucXa";
			this.qLKyTucXa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// malopDataGridViewTextBoxColumn
			// 
			this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
			this.malopDataGridViewTextBoxColumn.HeaderText = "Malop";
			this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
			// 
			// makhoaDataGridViewTextBoxColumn
			// 
			this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.HeaderText = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
			// 
			// maqueDataGridViewTextBoxColumn
			// 
			this.maqueDataGridViewTextBoxColumn.DataPropertyName = "Maque";
			this.maqueDataGridViewTextBoxColumn.HeaderText = "Maque";
			this.maqueDataGridViewTextBoxColumn.Name = "maqueDataGridViewTextBoxColumn";
			// 
			// gioitinhDataGridViewTextBoxColumn
			// 
			this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
			// 
			// ngaysinhDataGridViewTextBoxColumn
			// 
			this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
			// 
			// tensinhvienDataGridViewTextBoxColumn
			// 
			this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
			// 
			// masinhvienDataGridViewTextBoxColumn
			// 
			this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
			// 
			// dgvDSSinhVien
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvDSSinhVien.AutoGenerateColumns = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle12;
			this.dgvDSSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.Location = new System.Drawing.Point(12, 27);
			this.dgvDSSinhVien.Name = "dgvDSSinhVien";
			this.dgvDSSinhVien.RowHeadersVisible = false;
			this.dgvDSSinhVien.Size = new System.Drawing.Size(776, 349);
			this.dgvDSSinhVien.TabIndex = 1;
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
			// 
			// btnAll
			// 
			this.btnAll.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAll.Location = new System.Drawing.Point(240, 397);
			this.btnAll.Margin = new System.Windows.Forms.Padding(2);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(128, 32);
			this.btnAll.TabIndex = 9;
			this.btnAll.Text = "Tất Cả";
			this.btnAll.UseVisualStyleBackColor = false;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// btnLivingKTX
			// 
			this.btnLivingKTX.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLivingKTX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLivingKTX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLivingKTX.Location = new System.Drawing.Point(410, 397);
			this.btnLivingKTX.Margin = new System.Windows.Forms.Padding(2);
			this.btnLivingKTX.Name = "btnLivingKTX";
			this.btnLivingKTX.Size = new System.Drawing.Size(128, 32);
			this.btnLivingKTX.TabIndex = 8;
			this.btnLivingKTX.Text = "Đang ở KTX";
			this.btnLivingKTX.UseVisualStyleBackColor = false;
			this.btnLivingKTX.Click += new System.EventHandler(this.btnLivingKTX_Click);
			// 
			// sinhViênĐặtPhòngToolStripMenuItem
			// 
			this.sinhViênĐặtPhòngToolStripMenuItem.Name = "sinhViênĐặtPhòngToolStripMenuItem";
			this.sinhViênĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.sinhViênĐặtPhòngToolStripMenuItem.Text = "Sinh Viên Đặt Phòng";
			this.sinhViênĐặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.sinhViênĐặtPhòngToolStripMenuItem_Click);
			// 
			// sinhViênTrảPhòngToolStripMenuItem
			// 
			this.sinhViênTrảPhòngToolStripMenuItem.Name = "sinhViênTrảPhòngToolStripMenuItem";
			this.sinhViênTrảPhòngToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.sinhViênTrảPhòngToolStripMenuItem.Text = "Sinh Viên Trả Phòng";
			this.sinhViênTrảPhòngToolStripMenuItem.Click += new System.EventHandler(this.sinhViênTrảPhòngToolStripMenuItem_Click);
			// 
			// FormMainQLSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnLivingKTX);
			this.Controls.Add(this.dgvDSSinhVien);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMainQLSV";
			this.Text = "FormMainQLSV";
			this.Load += new System.EventHandler(this.FormMainQLSV_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tìmKiếmSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
		private QLKyTucXa qLKyTucXa;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private QLKyTucXaTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maqueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
		private Guna.UI2.WinForms.Guna2DataGridView dgvDSSinhVien;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnLivingKTX;
		private System.Windows.Forms.ToolStripMenuItem sinhViênĐặtPhòngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sinhViênTrảPhòngToolStripMenuItem;
	}
}