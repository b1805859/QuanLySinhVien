using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class SinhVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SinhVienDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllSinhVien()
        {
            //Tạo câu lệnh SQL để lấy toàn bộ sinh viên
            string sql = "Select * from SinhVien";
            
            //Tạo một kết nối đến SQL
            SqlConnection con = dc.GetConnection();
            
            //Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            
            //Mở kết nối
            con.Open();
            
            //Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public bool InsertSinhVien(SinhVien sv )
        {
            string sql = "Insert into SinhVien(MaSV, TenSV, Diem, Lop, DiaChi)" +
                "Values(@MaSV, @Lop, @Diem, @Lop, @DiaChi)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@Diem", SqlDbType.Float).Value = sv.Diem;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = sv.Lop;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch( Exception ex )
            {
                return false;
            }
            return true;
        }



        public bool UpdateSinhVien(SinhVien sv)
        {
            string sql = "Update SinhVien set MaSV = @MaSV, TenLop = @TenLop, Diem = @Diem, Lop = @Lop, DiaChi = @DiaChi" +
                "where Id = @Id";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sv.ID;
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@Diem", SqlDbType.Float).Value = sv.Diem;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = sv.Lop;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteSinhVien(SinhVien sv)
        {
            string sql = "Delete SinhVien Where Id = @Id";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sv.ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public DataTable FindSinhVien(string sv)
        {
            //Tạo câu lệnh SQL để lấy toàn bộ sinh viên
            string sql = "Select * from SinhVien where TenSV like N'%"+ sv +"%' or Lop like N'%" + sv + "%'";

            //Tạo một kết nối đến SQL
            SqlConnection con = dc.GetConnection();

            //Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);

            //Mở kết nối
            con.Open();

            //Đổ dữ liệu từ SqlDataAdapter và DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }


}
