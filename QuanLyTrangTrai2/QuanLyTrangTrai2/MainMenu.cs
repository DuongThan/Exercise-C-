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
            choose = int.Parse(Console.ReadLine());
            if (choose != 1 && choose != 2 && choose != 3) return;
            switch (choose)
            {
                case 1:
                    Add_Cho();
                    break;

                case 2:
                    Add_Lon();
                    break;

                case 3:
                    Add_Ga();
                    break;

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
            if (n > TraiCho.SoLuong()) return;
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
            if (n > TraiLon.SoLuong()) return;
            for (i = 0; i < n; i++)
            {
                TraiLon.Remove(TraiLon.List_animal1[0]);
            }
        }
        public void Remove_Ga()
        {
            Console.WriteLine("Nhap so luong Ban : ");
            int n = int.Parse(Console.ReadLine());
            if (n > TraiGa.SoLuong()) return;
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
            choose = int.Parse(Console.ReadLine());
            if (choose != 1 && choose != 2 && choose != 3) return;
            switch (choose)
            {
                case 1:
                    Remove_Cho();
                    break;

                case 2:
                    Remove_Lon();
                    break;

                case 3:
                    Remove_Ga();
                    break;

            }
        }

        public void Infomation()
        {
            Console.WriteLine("Trai Cho : So Luong : {0}  con. Luong thuc an : {1} kg. Tien nuoi : {2}", TraiCho.SoLuong(), TraiCho.LuongThucAn(), TraiCho.TienNuoi());
            Console.WriteLine("Trai Lon : So Luong : {0}  con. Luong thuc an : {1} kg. Tien nuoi : {2}", TraiLon.SoLuong(), TraiLon.LuongThucAn(), TraiLon.TienNuoi());
            Console.WriteLine("Trai Ga : So Luong : {0}  con. Luong thuc an : {1} kg. Tien nuoi : {2}", TraiGa.SoLuong(), TraiGa.LuongThucAn(), TraiGa.TienNuoi());
        }

        public void Main_Menu()
        {
            Console.Clear();
            Show_Menu();
            Console.WriteLine("Choose : ");
            choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Add_();
                    break;

                case 2:
                    Remove_();
                    break;
                    
                case 3:
                    Infomation();
                    Console.ReadLine();
                    break;

                case 4:
                    break;

                default:
                    break;
            }
        }

       
    }
}
