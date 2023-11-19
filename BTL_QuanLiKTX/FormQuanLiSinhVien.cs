using ConnectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL_QuanLiKTX
{
    public partial class FormQuanLiSinhVien : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        string SqlConnection;
        public FormQuanLiSinhVien()
        {
            InitializeComponent();
        }

        private void FormQuanLiSinhVien_Load(object sender, EventArgs e)
        {
			
			
			btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
			cbbGioiTinh.Items.Add("Nam");
			cbbGioiTinh.Items.Add("Nữ");
			HienChiTiet(false);
            dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
			this.queTableAdapter.Fill(this.qLKyTucXa.Que);
			//this.lopTableAdapter.Fill(this.qLKyTucXa.Lop);
			this.khoaTableAdapter.Fill(this.qLKyTucXa.Khoa);
			this.phongTableAdapter.Fill(this.qLKyTucXa.Phong);
			this.thuephongTableAdapter.Fill(this.qLKyTucXa.Thuephong);
			this.phongTableAdapter.Fill(this.qLKyTucXa.Phong);
			cbbMakhoaTK.SelectedIndex = -1;
			cbbMalopTK.Enabled = false;
			cbbMaphongTK.SelectedIndex = -1;
			XoaTrangChiTiet();
		}
		private void HienChiTiet(Boolean hien)
		{
			txtMaSV.Enabled = hien;
			txtTenSV.Enabled = hien;
			dtpNgaySinh.Enabled = hien;
			cbbGioiTinh.Enabled = hien;
			cbbMaQue.Enabled = hien;
			cbbKhoa.Enabled = hien;
			cbbMaLop.Enabled = hien;
			//Ẩn hiện 2 nút Lưu và Hủy
			btnLuu.Enabled = hien;
			btnHuy.Enabled = hien;
		}

		private void XoaTrangChiTiet()
		{
			txtMaSV.Text = "";
			txtTenSV.Text = "";
			dtpNgaySinh.Value = DateTime.Now;
			cbbGioiTinh.SelectedIndex = -1;
			cbbMaQue.SelectedIndex = -1;
			cbbKhoa.SelectedIndex = -1;
			cbbMaLop.SelectedIndex = -1;
		}
		private void dataGridViewDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
			try
			{
				txtMaSV.Text = dgvDSSinhVien[0, e.RowIndex].Value.ToString();
				txtTenSV.Text = dgvDSSinhVien[1, e.RowIndex].Value.ToString();
				dtpNgaySinh.Value = (DateTime)dgvDSSinhVien[2, e.RowIndex].Value;
                cbbGioiTinh.Text = dgvDSSinhVien[3, e.RowIndex].Value.ToString();
				cbbMaQue.Text = dgvDSSinhVien[4, e.RowIndex].Value.ToString();
				cbbKhoa.Text = dgvDSSinhVien[5, e.RowIndex].Value.ToString();
				cbbMaLop.Text = dgvDSSinhVien[6, e.RowIndex].Value.ToString();
			}
			catch (Exception ex)
			{
			}
			HienChiTiet(false);
			btnThem.Enabled = false;
			btnHuy.Enabled = true;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			XoaTrangChiTiet();
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			//Hiện GroupBox Chi tiết
			HienChiTiet(true);
			cbbMaLop.Enabled = false;
		}
		private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{		
			string sql = "";
			pd.KetNoi();
			sql = @"Select Khoa.Makhoa, Lop.Malop
				    From Khoa inner join Lop on Khoa.Makhoa = Lop.Makhoa
				    Where (Khoa.Makhoa = N'" + cbbKhoa.Text + @"')";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cbbMaLop.DataSource = table;
			cbbMaLop.DisplayMember = "Malop"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cbbMaLop.ValueMember = "Malop"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cbbMaLop.Enabled = true;
			cbbMaLop.SelectedIndex = -1;
		}
		private void cbbMakhoaTK_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Khoa.Makhoa, Lop.Malop
				    From Khoa inner join Lop on Khoa.Makhoa = Lop.Makhoa
				    Where (Khoa.Makhoa = N'" + cbbMakhoaTK.Text + @"')";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cbbMalopTK.DataSource = table;
			cbbMalopTK.DisplayMember = "Malop"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cbbMalopTK.ValueMember = "Malop"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cbbMalopTK.Enabled = true;
			cbbMalopTK.SelectedIndex = -1;
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();

			if (txtMaSV.Text.Trim() == "") { errChiTiet.SetError(txtMaSV, "Bạn không được để trống mã sinh viên!"); return; } else { errChiTiet.Clear(); }
			if (txtTenSV.Text.Trim() == "") { errChiTiet.SetError(txtTenSV, "Bạn không được để trống tên sinh viên!"); return; } else { errChiTiet.Clear(); }
			if (dtpNgaySinh.Value > DateTime.Now) { errChiTiet.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!"); return; } else { errChiTiet.Clear(); }
			if (cbbGioiTinh.SelectedIndex == -1) { errChiTiet.SetError(cbbGioiTinh, "Bạn phải chọn một lựa chọn!"); return; } else { errChiTiet.Clear(); }
			if (cbbMaQue.SelectedIndex == -1) { errChiTiet.SetError(cbbGioiTinh, "Bạn phải chọn một lựa chọn!"); return; } else { errChiTiet.Clear(); }
			if (cbbKhoa.SelectedIndex == -1) { errChiTiet.SetError(cbbGioiTinh, "Bạn phải chọn một lựa chọn!"); return; } else { errChiTiet.Clear(); }
			if (cbbMaLop.SelectedIndex == -1) { errChiTiet.SetError(cbbGioiTinh, "Bạn phải chọn một lựa chọn!"); return; } else { errChiTiet.Clear(); }

			if (btnThem.Enabled == true)
			{
				if (txtMaSV.Text.Trim() == "") { errChiTiet.SetError(txtMaSV, "Bạn không được để trống mã sinh viên!"); return; }
				
				else
				{
					sql = "Select Masinhvien From SinhVien Where Masinhvien =N'" + txtMaSV.Text + "'";
					pd.DocBang(sql);
					if (pd.DocBang(sql).Rows.Count > 0)
					{
						errChiTiet.SetError(txtMaSV, "Mã sinh viên trùng trong cơ sở dữ liệu");
						return;
					}
					errChiTiet.Clear();
				}
				sql = "INSERT INTO SinhVien(Masinhvien,Tensinhvien,Ngaysinh,Gioitinh,Maque,Makhoa,Malop)VALUES (";
				sql += "N'" + txtMaSV.Text.Trim()
					+ "',N'" + txtTenSV.Text.Trim()
					+ "','" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy")
					+ "',N'" + cbbGioiTinh.Text
					+ "',N'" + cbbMaQue.Text
					+ "',N'" + cbbKhoa.Text
					+ "',N'" + cbbMaLop.Text + "')";
			}
			if (btnSua.Enabled == true)
			{
				sql = "Update SinhVien SET ";
				sql += "Tensinhvien = N'" + txtTenSV.Text.Trim() + "',";
				sql += "Ngaysinh = '" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy") + "',";
				sql += "Gioitinh = N'" + cbbGioiTinh.Text + "',";
				sql += "Maque = N'" + cbbMaQue.Text + "',";
				sql += "Makhoa = '" + cbbKhoa.Text + "',";
				sql += "Malop = N'" + cbbMaLop.Text + "' ";
				sql += "Where Masinhvien = N'" + txtMaSV.Text.Trim() + "'";
			}
			pd.CapNhat(sql);
			dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
			HienChiTiet(false);
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			btnThem.Enabled = true;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			btnThem.Enabled = true;
			cbbMakhoaTK.SelectedIndex = -1;
			cbbMaphongTK.SelectedIndex = -1;
			cbbMalopTK.Text = "";
			cbbMalopTK.Enabled = false;
			dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
			//xoa trang
			XoaTrangChiTiet();
			//Cam nhap
			HienChiTiet(false);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			//Ẩn hai nút Thêm và Sửa
			btnThem.Enabled = false;
			btnXoa.Enabled = false;
			//Hiện gropbox chi tiết
			HienChiTiet(true);
			txtMaSV.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (txtMaSV.Text.Trim() != "")
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa sinh viên có mã " + txtMaSV.Text.Trim() + " không?",
					"Xóa sinh viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					pd.KetNoi();
					btnThem.Enabled = false;
					btnSua.Enabled = false;
					string sql = "Delete From Thuephong Where Masv =N'" + txtMaSV.Text.Trim() + "'";
					pd.CapNhat(sql);
					sql = "Delete From SinhVien Where Masinhvien =N'" + txtMaSV.Text.Trim() + "'";
					pd.CapNhat(sql);
					dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
					btnThem.Enabled = true;
					XoaTrangChiTiet();
					HienChiTiet(false);
				}
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (cbbMalopTK.SelectedIndex == -1 && cbbMaphongTK.SelectedIndex == -1) { errChiTiet.SetError(cbbMalopTK, "Bạn phải chọn 1 trong 2 mã!"); return; } else { errChiTiet.Clear(); }
			string sql = "";
			pd.KetNoi();
			sql += @"Select SinhVien.*";			    
			String dk = "";
			//Tim theo Malop khac rong
			if (cbbMalopTK.SelectedIndex != -1 && cbbMaphongTK.SelectedIndex == -1)
			{
				sql += @"From SinhVien ";
				dk += @" Malop like N'%" + cbbMalopTK.Text + @"%'";
			}
			//kiem tra Malop va Maphong khac rong
			if (cbbMaphongTK.SelectedIndex != -1 && cbbMalopTK.SelectedIndex != -1)
			{
				sql += @"From SinhVien join Thuephong on SinhVien.Masinhvien = Thuephong.Masv
									   join Phong on Thuephong.Maphong = Phong.Maphong";
				dk += @" SinhVien.Malop like N'%" + cbbMalopTK.Text + @"%'";
				dk += @" AND Phong.Maphong like N'%" + cbbMaphongTK.Text + @"%'";
			}
			//Tim kiem theo Maphong khi Malop la rong
			if (cbbMaphongTK.SelectedIndex != -1 && cbbMalopTK.SelectedIndex == -1)
			{
				sql += @"From SinhVien join Thuephong on SinhVien.Masinhvien = Thuephong.Masv
									   join Phong on Thuephong.Maphong = Phong.Maphong";
				dk += @" Phong.Maphong like N'%" + cbbMaphongTK.Text + @"%'";
			}
			//Ket hoi dk
			if (dk != "")
			{
				sql += @" WHERE" + dk;
			}
			//Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm
			dgvDSSinhVien.DataSource = pd.DocBang(sql);
			cbbMakhoaTK.SelectedIndex = -1;
			cbbMalopTK.Text = "";
			cbbMalopTK.Enabled = false;
			cbbMaphongTK.SelectedIndex = -1;
			btnHuy.Enabled = true;
		}

		private void btnXuat_Click(object sender, EventArgs e)
		{
			// Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook =
			exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet =
				(Excel.Worksheet)exBook.Worksheets[1];
			Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
			tenvung.Font.Name = "Arial"; tenvung.Font.Size = 16;
			tenvung.Font.Color = Color.Blue;
			tenvung.Value = "Danh sách sinh viên";
			exSheet.get_Range("A1: H1").Merge(true);
			exSheet.get_Range("A2:H2").Font.Size = 15;
			exSheet.get_Range("A2:H2").ColumnWidth = 16;
			exSheet.get_Range("D2").ColumnWidth = 20;
			exSheet.get_Range("A2:H2").Font.Bold = true;
			exSheet.get_Range("A:H").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
			exSheet.get_Range("A2").Value = "STT";
			exSheet.get_Range("B2").Value = "Mã sinh viên";
			exSheet.get_Range("C2").Value = "Tên sinh viên";
			exSheet.get_Range("D2").Value = "Ngày sinh";
			exSheet.get_Range("E2").Value = "Giới tính";
			exSheet.get_Range("F2").Value = "Mã quê";
			exSheet.get_Range("G2").Value = "Mã khoa";
			exSheet.get_Range("H2").Value = "Mã lớp";
			int k = dgvDSSinhVien.Rows.Count - 1;
			exSheet.get_Range("A2:H" + (k + 2).ToString()).
				Borders.LineStyle
				= Excel.XlLineStyle.xlDouble;//.Borders( true);
			for (int i = 0; i < dgvDSSinhVien.Rows.Count - 1; i++)
			{
				exSheet.get_Range("A" + (3 + i).ToString()).Value =
					(i + 1).ToString();
				exSheet.get_Range("B" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[0].Value.ToString();
				exSheet.get_Range("C" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[1].Value.ToString();
				exSheet.get_Range("D" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[2].Value.ToString();
				exSheet.get_Range("E" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[3].Value.ToString();
				exSheet.get_Range("F" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[4].Value.ToString();
				exSheet.get_Range("G" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[5].Value.ToString();
				exSheet.get_Range("H" + (3 + i).ToString()).Value =
					dgvDSSinhVien.Rows[i].Cells[6].Value.ToString();
			}
			exBook.Activate();
			SaveFileDialog svf = new SaveFileDialog();
			svf.Title = "Chọn đường dẫn và đặt tên tệp lưu dl ";
			svf.ShowDialog();
			string filename = svf.FileName;
			if (filename == "")
			{
				MessageBox.Show("Bạn chưa đặt tên file");
			}
			exBook.SaveAs(filename);
			exApp.Quit();
		}

		//Chung
		private void btnHomeClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnQuanLiThietBi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiThietBi Obj = new FormQuanLiThietBi();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe Obj = new FormThongKe();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnQanLiPhong_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                FormQuanLiPhong Obj = new FormQuanLiPhong();
                Obj.ShowDialog();
                this.Close();
        }

        private void btnQuanLiHoaDon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiHoaDon Obj = new FormQuanLiHoaDon();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnQanLiPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiPhong Obj = new FormQuanLiPhong();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnQuanLiThietBi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiThietBi Obj = new FormQuanLiThietBi();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe Obj = new FormThongKe();
            Obj.ShowDialog();
            this.Close();
        }

		private void btnCloseForm_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Ban co muon thoat khong", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		
	}
}
