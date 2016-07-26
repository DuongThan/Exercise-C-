using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class QuanLy
    {
        private List<SinhVien> list_SinhVien;

        public List<SinhVien> List_SinhVien
        {
            get
            {
                return list_SinhVien;
            }

            set
            {
                list_SinhVien = value;
            }
        }

        public QuanLy()
        {
            list_SinhVien = new List<SinhVien>();
        }
        /*Tạo 1 danh sách (list) các sinh viên
Chương trình cho phép nhập vào các sinh viên.
Xuất thông tin tất cả các sinh viên trong danh sách
Thống kê số lượng sinh viên, Điểm trung bình cao nhất, Sắp xếp thứ tự giảm dần theo điểm trung bình.*/
        public void Nhap(SinhVien sv)
        {
            Console.WriteLine(" Ma sinh vien : ");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine(" Ho ten       : ");
            sv.HoTen = Console.ReadLine();
            Console.WriteLine(" Lop          : ");
            sv.Lop = Console.ReadLine();
            Console.WriteLine(" Ngay sinh    : ");
            DateTime dt;
            while(!DateTime.TryParse(Console.ReadLine(),out dt))
            {
                Console.WriteLine(" Nhap ngay sinh duoi dang dd/mm/yy");
            }
            sv.NgaySinh = dt;
            float diem;
            Console.WriteLine(" Diem toan    : ");
            while(!float.TryParse(Console.ReadLine(),out diem) || diem <0 || diem >10)
            {

            }
            sv.DiemToan = diem;
            Console.WriteLine(" Diem van     : ");
            while (!float.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {

            }
            sv.DiemVan = diem;
            Console.WriteLine(" Diem anh     : ");
            while (!float.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {

            }
            sv.DiemAnh = diem;

            list_SinhVien.Add(sv);
        }

        public void Xuat(SinhVien sv)
        {
            Console.WriteLine(" Ma sinh vien : "+sv.MaSV);
            Console.WriteLine(" Ho ten       : "+sv.HoTen);
            Console.WriteLine(" Lop          : "+sv.Lop);
            Console.WriteLine(" Ngay sinh    : "+sv.NgaySinh.ToShortDateString());
            Console.WriteLine(" Diem toan    : "+sv.DiemToan);
            Console.WriteLine(" Diem van     : "+sv.DiemVan);
            Console.WriteLine(" Diem anh     : "+sv.DiemAnh);
        }

        public void XuatDSLop()
        {
            if(SoLuongSV()==0)
            {
                Console.WriteLine(" Danh sach trong !");
                return;
            }
            int i = 1;
            foreach(SinhVien temp in list_SinhVien)
            {
                Console.WriteLine(" Thong tin sinh vien thu " + i);
                i++;
                Xuat(temp);
                Console.WriteLine();
            }
        }

        public int SoLuongSV()
        {
            return list_SinhVien.Count();
        }

        public void SapXepDiem()
        {
            int i, j;
            SinhVien temp = new SinhVien();
            for (i = 0; i < SoLuongSV() - 1; i++) 
            {
                for (j = i + 1; j < SoLuongSV(); j++) 
                {
                    if(list_SinhVien[i].diemTB() < list_SinhVien[j].diemTB())
                    {
                        temp = list_SinhVien[i];
                        list_SinhVien[i] = list_SinhVien[j];
                        list_SinhVien[j] = temp;
                    }
                }
            }
        }

        public SinhVien MaxDTB()
        {
            if (SoLuongSV() == 0) return null;
            SinhVien sv = list_SinhVien[0];
            for (int i = 1; i < SoLuongSV(); i++) 
            {
                if (sv.diemTB() < list_SinhVien[i].diemTB())
                {
                    sv = list_SinhVien[i];
                }
            }
            return sv;
        }
    }
}
