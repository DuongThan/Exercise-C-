using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class SinhVien
    {
        //Mã lớp, Họ tên, tuổi, lớp , điểm 3 môn toán, văn anh.
        private string maSV;
        private string hoTen;
        private string lop;
        private DateTime ngaySinh;
        private float diemToan;
        private float diemVan;
        private float diemAnh;

        public float DiemAnh
        {
            get
            {
                return diemAnh;
            }

            set
            {
                diemAnh = value;
            }
        }

        public float DiemVan
        {
            get
            {
                return diemVan;
            }

            set
            {
                diemVan = value;
            }
        }

        public float DiemToan
        {
            get
            {
                return diemToan;
            }

            set
            {
                diemToan = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string Lop
        {
            get
            {
                return lop;
            }

            set
            {
                lop = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }
        public SinhVien()
        {

        }

        public float diemTB()
        {
            return (diemAnh + diemToan + diemVan) / 3;
        }

    }
}
