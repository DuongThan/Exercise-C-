using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Program
    {
        static string choose;
        static QuanLy quanLy = new QuanLy();
        static SinhVien sinhVien;
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("CHUONG TRINH QUAN LI SINH VIEN");
            Console.WriteLine(" 1. Them moi sinh vien");
            Console.WriteLine(" 2. Danh sach sinh vien");
            Console.WriteLine(" 3. Sap xep danh sach");
            Console.WriteLine(" 4. Sinh vien co diem trung binh cao nhat");
        }

        static void ThemMoi()
        {
            Console.Clear();
            sinhVien = new SinhVien();
            quanLy.Nhap(sinhVien);
        }

        static void DanhSach()
        {
            Console.Clear();
            quanLy.XuatDSLop();
        }

        static void SapXep()
        {
            quanLy.SapXepDiem();
            Console.WriteLine("Sap xep thanh cong");
        }

        static void MaxDTB()
        {
            Console.Clear();
            quanLy.Xuat(quanLy.MaxDTB());
        }
        static void Main(string[] args)
        {
            while(true)
            {
                MainMenu();
                Console.WriteLine(" Choose ");
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
                        MaxDTB();
                        break;

                    default:
                        return;

                }
                Console.ReadLine();
            }
        }
    }
}
