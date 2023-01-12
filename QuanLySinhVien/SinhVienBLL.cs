using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{

    internal class SinhVienBLL
    {
        SinhVienDAL dalSV;

        public SinhVienBLL()
        {
            dalSV= new SinhVienDAL();
        }

        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }


        public bool InsertSinhVien(SinhVien sv)
        {
            return dalSV.InsertSinhVien(sv);
        }

        public bool UpdateSinhVien(SinhVien sv)
        {
            return dalSV.UpdateSinhVien(sv);

        }

        public bool DeleteSinhVien(SinhVien sv )
        {
            return dalSV.DeleteSinhVien(sv);
        }


        public DataTable FindSinhVien(string sv)
        {
            return dalSV.FindSinhVien(sv);
        }

    }
}
