using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    public class MainMenu
    {
        private FarmingAnimal TraiGa;

        public FarmingAnimal TraiGa1
        {
            get { return TraiGa; }
            set { TraiGa = value; }
        }
        private FarmingAnimal TraiCho;

        public FarmingAnimal TraiCho1
        {
            get { return TraiCho; }
            set { TraiCho = value; }
        }
        private FarmingAnimal TraiLon;

        public FarmingAnimal TraiLon1
        {
            get { return TraiLon; }
            set { TraiLon = value; }
        }
        public MainMenu()
        {
            TraiCho = new FarmingAnimal();
            TraiGa = new FarmingAnimal();
            TraiLon = new FarmingAnimal();
        }
        private Animal animal;
        private int choose;

        public void Show_Menu()
        {
            Console.WriteLine("Quan Ly Trang Trai");
            Console.WriteLine();
            Console.WriteLine("1. Them vat nuoi");
            Console.WriteLine("2. Ban vat nuoi");
            Console.WriteLine("3. Thong tin trang trai");
            Console.WriteLine("4. Thoat");
        }

        public void Menu_add()
        {
            Console.WriteLine("Them vat nuoi");
            Console.WriteLine();
            Console.WriteLine("1. Them Cho");
            Console.WriteLine("2. Them Lon");
            Console.WriteLine("3. Them ga");
            Console.WriteLine("4. Thoat");
        }

        public void Add_Cho()
        {
            Console.WriteLine("Nhap so luong : ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new Cho();
                TraiCho.Add(animal);
            }
        }
        public void Add_Ga()
        {
            Console.WriteLine("Nhap so luong : ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new Ga();
                TraiGa.Add(animal);
            }
        }
        public void Add_Lon()
        {
            Console.WriteLine("Nhap so luong : ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new Lon();
                TraiLon.Add(animal);
            }
        }

        public void Add_()
        {
            Console.Clear();
            Menu_add();
            Console.WriteLine("Choose : ");
            ConsoleKeyInfo infokey = Console.ReadKey();
            switch (infokey.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                   Add_Cho();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Add_Lon();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Add_Ga();
                    Console.ReadLine();
                    break;


                default:
                    return;
            }
        }

        public void Menu_Remove()
        {
            Console.WriteLine("Ban vat nuoi");
            Console.WriteLine();
            Console.WriteLine("1. Ban Cho");
            Console.WriteLine("2. Ban Lon");
            Console.WriteLine("3. Ban ga");
            Console.WriteLine("4. Thoat");
        }

        public void Remove_Cho()
        {
            Console.WriteLine("Nhap so luong Ban : ");
            int n = int.Parse(Console.ReadLine());
            if (n > TraiCho.SoLuong())
            {
                Console.WriteLine("So luong con lai chi co : " + TraiCho.SoLuong() + " con");
                Console.ReadLine();
                return;
            }
            int i;
            for (i = 0; i < n; i++)
            {
                TraiCho.Remove(TraiCho.List_animal1[0]);
            }
        }
        public void Remove_Lon()
        {
            Console.WriteLine("Nhap so luong Ban : ");
            int n = int.Parse(Console.ReadLine());
            int i;
            if (n > TraiLon.SoLuong())
            {
                Console.WriteLine("So luong con lai chi co : " + TraiLon.SoLuong() + " con");
                Console.ReadLine();
                return;
            }
            for (i = 0; i < n; i++)
            {
                TraiLon.Remove(TraiLon.List_animal1[0]);
            }
        }
        public void Remove_Ga()
        {
            Console.WriteLine("Nhap so luong Ban : ");
            int n = int.Parse(Console.ReadLine());
            if (n > TraiGa.SoLuong())
            {
                Console.WriteLine("So luong con lai chi co : " + TraiGa.SoLuong() + " con");
                Console.ReadLine();
                return;
            }
            int i;
            for (i = 0; i < n; i++)
            {
                TraiGa.Remove(TraiGa.List_animal1[0]);
            }
        }

        public void Remove_()
        {
            Console.Clear();
            Menu_Remove();
            Console.WriteLine("Choose : ");
          
            ConsoleKeyInfo infokey = Console.ReadKey();
            switch (infokey.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Remove_Cho();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Remove_Lon();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Remove_Ga();
                    Console.ReadLine();
                    break;


                default:
                    return;
            }
        }

        public void Infomation()
        {
            Console.WriteLine("Trai Cho : So Luong : {0}  con. Luong thuc an : {1} kg. Tien nuoi : {2}", TraiCho.SoLuong(), TraiCho.LuongThucAn(), TraiCho.TienNuoi());
            Console.WriteLine("Trai Lon : So Luong : {0}  con. Luong thuc an : {1} kg. Tien nuoi : {2}", TraiLon.SoLuong(), TraiLon.LuongThucAn(), TraiLon.TienNuoi());
            Console.WriteLine("Trai Ga : So Luong : {0}  con. Luong thuc an : {1} kg. Tien nuoi : {2}", TraiGa.SoLuong(), TraiGa.LuongThucAn(), TraiGa.TienNuoi());
        }

       

       
    }
}
