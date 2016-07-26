using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class QuanLy
    {
        private List<SinhVien> list_SinhVien;

        internal List<SinhVien> List_SinhVien
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

        public void ThemMoi(SinhVien sinhVien)
        {
            Console.WriteLine("Ma sinh vien : ");
            sinhVien.MaSV = Console.ReadLine();
            Console.WriteLine("Ho ten       : ");
            sinhVien.HoTen = Console.ReadLine();
            Console.WriteLine("Lop          : ");
            sinhVien.Lop = Console.ReadLine();
            Console.WriteLine("Ngay sinh    : ");

            DateTime dt;
            while(!DateTime.TryParse(Console.ReadLine(),out dt))
            {
                Console.WriteLine("Nhap du lieu dang dd/m/yy");
            }
            sinhVien.NgaySinh = dt;

            //sinhVien.NgaySinh = DateTime.Parse(Console.ReadLine()); // dd/mm/yy;

            Console.WriteLine("Diem toan    : ");
            sinhVien.DiemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem van     : ");
            sinhVien.DiemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem anh     : ");
            sinhVien.DiemAnh = float.Parse(Console.ReadLine());

            list_SinhVien.Add(sinhVien);
        }

        public void Xuat(SinhVien sinhVien)
        {
            Console.WriteLine("Ma sinh vien : " + sinhVien.MaSV);
            Console.WriteLine("Ho ten       : "+ sinhVien.HoTen);
            Console.WriteLine("Lop          : "+sinhVien.Lop);
            Console.WriteLine("Ngay sinh    : "+sinhVien.NgaySinh.ToShortDateString());
            Console.WriteLine("Diem toan    : "+sinhVien.DiemToan);
            Console.WriteLine("Diem van     : "+sinhVien.DiemVan);
            Console.WriteLine("Diem anh     : "+sinhVien.DiemAnh);
        }

        public int SoLuongSV()
        {
            return list_SinhVien.Count();
        }

        public void DSSV()
        {
            if(SoLuongSV()==0)
            {
                Console.WriteLine("Lop trong ! ");
                return;
            }
            int i = 1;

            //for (int j = 0; j < SoLuongSV(); j++) 
            //{
            //    Console.WriteLine("Thong tin sinh vien thu " + i);
            //    i++;
            //    Xuat(list_SinhVien[j]);
            //    Console.WriteLine();
            //}

            foreach (SinhVien temp in list_SinhVien)
            {
                Console.WriteLine("Thong tin sinh vien thu " + i);
                i++;
                Xuat(temp);
                Console.WriteLine();
            }
        }

        public void SapXepDiem()
        {
            int i, j;
            SinhVien sv = new SinhVien();
            for (i = 0; i < SoLuongSV() - 1; i++)
            {
                for (j = 1; j < SoLuongSV(); j++)
                {
                    if (list_SinhVien[i].DiemTB() < list_SinhVien[j].DiemTB()) 
                    {
                        sv = list_SinhVien[i];
                        list_SinhVien[i] = list_SinhVien[j];
                        list_SinhVien[j] = sv;
                    }
                }
            }
        }

        public SinhVien DiemTBMax()
        {
            if (SoLuongSV() == 0)
            {
                return null;
            }

            SinhVien sv = new SinhVien();
            sv = list_SinhVien[0];
            for (int i = 1; i < SoLuongSV(); i++)
            {
                if(sv.DiemTB() < list_SinhVien[i].DiemTB())
                {
                    sv = list_SinhVien[i];
                }
            }

            return sv;
        }

    }
}
