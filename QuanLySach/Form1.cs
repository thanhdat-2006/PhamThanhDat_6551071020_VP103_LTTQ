using System;
using Microsoft.EntityFrameworkCore;
using QuanLySach.Models;

namespace QuanLySach
{
    public partial class Form1 : Form
    {
        private int maDangChon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            txtGiaTien = new TextBox();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                using var db = new DuLieuContext();
                var ds = await db.CongViecs.ToListAsync();
                dgvDanhSachSach.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDanhSachSach.Rows[e.RowIndex];
                maDangChon = Convert.ToInt32(row.Cells["MaSach"].Value);
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtGiaTien.Text = row.Cells["GiaTien"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private bool KiemTra()
        { 
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Tên sách không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return false;
            }
            if ( string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Giá tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTien.Focus();
                return false;
            }
            return true;
        }

        private async void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTra()) return;
            try
            {
                using var db = new DuLieuContext();
                db.CongViecs.Add(new CongViec
                {
                    MaSach = txtMaSach.Text.Trim(),
                    TenSach = txtTenSach.Text.Trim(),
                    GiaTien = txtGiaTien.Text.Trim()
                });
                await db.SaveChangesAsync();
                MessageBox.Show("Thêm sách thành công!");
                await LoadDataAsync();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Không lưu được: " + (ex.InnerException?.Message ??ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaTien.Clear();
            btnThem.Enabled = false;
        }

        private async void btnSua_Click(object? sender, EventArgs e)
        {
            if (maDangChon == 0 || !KiemTra()) return;
            try
            {
                using var db = new DuLieuContext();
                var s = await db.CongViecs.FindAsync(maDangChon);
                if (s == null)
                {
                    MessageBox.Show("Sách này không có trong CSDL!");
                    return;
                }
                s.MaSach = txtMaSach.Text.Trim();
                s.TenSach = txtTenSach.Text.Trim();
                s.GiaTien = txtGiaTien.Text.Trim();
                await db.SaveChangesAsync();
                MessageBox.Show("Sửa thành công!");
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
