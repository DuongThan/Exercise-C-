using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static XuLyChuoi xuly = new XuLyChuoi();
        static string chuoi = null;

        static void SoKyTu()
        {
            Console.WriteLine("So ki tu trong van ban la : " + xuly.SoKyTu(chuoi));
        }
        static void SoChuCai()
        {
            Console.WriteLine("So ki tu trong van ban la : " + xuly.SoChuCai(chuoi));
        }
        static void SoChuSo()
        {
            Console.WriteLine("So ki tu trong van ban la : " + xuly.SoChuSo(chuoi));
        }
        static void ChuanHoa()
        {
            chuoi = xuly.ChuanHoa(chuoi);
            Console.WriteLine("Chuoi sua khi chuan hoa  : " + chuoi);
        }
        static void MenuMain()
        {
            Console.WriteLine("\n\n\t   Chuong trinh Xu ly van ban ");
            Console.WriteLine("\t 1. Dem so ki tu ");
            Console.WriteLine("\t 2. Dem so chu cai ");
            Console.WriteLine("\t 3. Dem so chu so ");
            Console.WriteLine("\t 4. Chuan hoa ");
        }

        static void NhapChuoi()
        {
            Console.WriteLine("\nNhap chuoi van ban : ");
            chuoi = Console.ReadLine();
        }
        static void ShowChuoi()
        {
            Console.WriteLine("\nChuoi van ban : " + chuoi);
        }
        static void Main(string[] args)
        {
            NhapChuoi();
            while(true)
            {
                Console.Clear();
                ShowChuoi();
                MenuMain();
                ConsoleKeyInfo keyinf = Console.ReadKey();
                switch(keyinf.Key)
                {
                    case ConsoleKey.NumPad1:
                        SoKyTu();
                        break;

                    case ConsoleKey.NumPad2:
                        SoChuCai();
                        break;

                    case ConsoleKey.NumPad3:
                        SoChuSo();
                        break;

                    case ConsoleKey.NumPad4:
                        ChuanHoa();
                        break;

                    default:
                        return;
                }
                Console.ReadLine();

            }
            
        }
    }
}
