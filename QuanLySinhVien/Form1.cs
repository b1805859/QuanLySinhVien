using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        SinhVienBLL bllSV;
        public Form1()
        {
            InitializeComponent();
            bllSV = new SinhVienBLL();
        }

        public void ShowAllSinhVien()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dtgvSinhVien.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public bool checkData()
        {
            if(string.IsNullOrEmpty(txbMaSV.Text))
            {
                MessageBox.Show("Chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaSV.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txbTenSV.Text))
            {
                MessageBox.Show("Chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbDiem.Text))
            {
                MessageBox.Show("Chưa nhập điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDiem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbLop.Text))
            {
                MessageBox.Show("Chưa nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbLop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDiaChi.Focus();
                return false;
            }

            return true;
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                    SinhVien sv = new SinhVien();
                    sv.MaSV = txbMaSV.Text;
                    sv.DiaChi = txbDiaChi.Text;
                    sv.Diem = double.Parse(txbDiem.Text);
                    sv.Lop = txbLop.Text;
                    sv.TenSV= txbTenSV.Text;

                if(bllSV.InsertSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }    
            }    
           
        }
        int ID;
        private void dtgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0)
            {
                ID = Int32.Parse(dtgvSinhVien.Rows[index].Cells["Id"].Value.ToString());
                txbMaSV.Text = dtgvSinhVien.Rows[index].Cells["MaSV"].Value.ToString();
                txbTenSV.Text = dtgvSinhVien.Rows[index].Cells["TenSV"].Value.ToString();
                txbDiem.Text = dtgvSinhVien.Rows[index].Cells["Diem"].Value.ToString();
                txbLop.Text = dtgvSinhVien.Rows[index].Cells["Lop"].Value.ToString();
                txbDiaChi.Text = dtgvSinhVien.Rows[index].Cells["DiaChi"].Value.ToString();
            }
            
        }

        private void btnEditSinhVien_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                SinhVien sv = new SinhVien();
                sv.ID = ID;
                sv.MaSV = txbMaSV.Text;
                sv.DiaChi = txbDiaChi.Text;
                sv.Diem = double.Parse(txbDiem.Text);
                sv.Lop = txbLop.Text;
                sv.TenSV = txbTenSV.Text;

                if (bllSV.UpdateSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnDeleteSinhVien_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn xóa ?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.Yes)
            {
                SinhVien sv = new SinhVien();
                sv.ID = ID;
                if (bllSV.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    
        }

        private void txbFindSinhVien_TextChanged(object sender, EventArgs e)
        {
            string value = txbFindSinhVien.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllSV.FindSinhVien(value);
                dtgvSinhVien.DataSource = dt;
            }
            else
                ShowAllSinhVien();
        }
    }
}
