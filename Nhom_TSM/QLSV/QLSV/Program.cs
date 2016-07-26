using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program
    {
        static QuanLy ql = new QuanLy();
        static SinhVien sinhVien;
        static string choose;

        static void Menumain()
        {
            Console.Clear();
            Console.WriteLine("Chuong trinh quan li sihn vien ");
            Console.WriteLine(" 1. Them moi");
            Console.WriteLine(" 2. Danh sach sinh vien");
            Console.WriteLine(" 3. Sap xep");
            Console.WriteLine(" 4. Sinh vien co diem trung binh cao nhat");
        }

        static void ThemMoi()
        {
            Console.Clear();
            sinhVien = new SinhVien();
            ql.ThemMoi(sinhVien);
        }

        static void DanhSach()
        {
            Console.Clear();
            ql.DSSV();
        }

        static void SapXep()
        {
            ql.SapXepDiem();
            Console.WriteLine("Sap xep thanh cong");
        }

        static void SinhVienQuaiVat()
        {
            Console.Clear();
            sinhVien = new SinhVien();
            sinhVien = ql.DiemTBMax();
            ql.Xuat(sinhVien);
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Menumain();
                Console.Write(" Choose : ");
                choose = Console.ReadLine();
                switch(choose)
                {
                    case "1":
                        ThemMoi();
                        break;

                    case "2":
                        DanhSach();
                        break;

                    case "3":
                        SapXep();
                        break;

                    case "4":
                        SinhVienQuaiVat();
                        break;

                    default:
                        return;
                }
                Console.ReadLine();
            }
        }
    }
}
