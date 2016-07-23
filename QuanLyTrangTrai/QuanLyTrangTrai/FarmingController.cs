using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    class FarmingController
    {
        private FarmingAnimal TraiBoSua;

        public FarmingAnimal TraiBoSua1
        {
            get { return TraiBoSua; }
            set { TraiBoSua = value; }
        }
        private FarmingAnimal TraiGa;

        public FarmingAnimal TraiGa1
        {
            get { return TraiGa; }
            set { TraiGa = value; }
        }
        private FarmingAnimal TraiHeo;

        public FarmingAnimal TraiHeo1
        {
            get { return TraiHeo; }
            set { TraiHeo = value; }
        }
        private FarmingAnimal TraiCho;

        public FarmingAnimal TraiCho1
        {
            get { return TraiCho; }
            set { TraiCho = value; }
        }

        public FarmingController()
        {
            TraiBoSua = new FarmingAnimal();
            TraiGa = new FarmingAnimal();
            TraiCho = new FarmingAnimal();
            TraiHeo = new FarmingAnimal();
        }

        private Animal animal;
        public int choose;
        public void Menu()
        {
            Console.WriteLine("1. Them vat nuoi");
            Console.WriteLine("2. Ban vat nuoi");
            Console.WriteLine("3. Thong tin chan nuoi");
        }

        public void MainMenu()
        {
            Console.Clear();
            Menu();
            Console.Write(" Lua chon : ");
            choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    ThemVatNuoi();
                    break;

                case 2:
                    BanVatNuoi();
                    break;

                case 3:
                    ThongTinChanNuoi();
                    Console.ReadLine();
                    break;

            }
        }
        public void MenuThemVatNuoi()
        {
            Console.WriteLine("1. Them bo sua");
            Console.WriteLine("2. Them ga mai de"); 
            Console.WriteLine("3. Them heo thit");
            Console.WriteLine("4. Them Cho");
        }

        public void ThemBoSua(int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new BoSua();
                TraiBoSua.Add(animal);
            }
        }
        public void ThemGaMaiDe(int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new Chicken();
                TraiGa.Add(animal);
            }
        }

        public void ThemHeoThit(int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new Heo();
                TraiHeo.Add(animal);
            }
        }

        public void ThemCho(int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                animal = new Cho();
                TraiCho.Add(animal);
            }
        }

        public void ThemVatNuoi()
        {
            Console.Clear();
            MenuThemVatNuoi();
            int soluong = 0;
            Console.Write(" Lua chon : ");
            choose = int.Parse(Console.ReadLine());
            Console.Write(" Nhap so luong can them : ");
            soluong = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    ThemBoSua(soluong);
                    break;

                case 2:
                    ThemGaMaiDe(soluong);
                    break;

                case 3:
                    ThemHeoThit(soluong);
                    break;

                case 4:
                    ThemCho(soluong);
                    break;
            }
        }

        public void MenuBanVatNuoi()
        {
            Console.WriteLine("1. Ban bo sua");
            Console.WriteLine("2. Ban ga mai de");
            Console.WriteLine("3. Ban heo thit");
            Console.WriteLine("4. Ban Cho");
        }
        public void BanBoSua(int n)
        {
            int i;
            if (n > TraiBoSua.AnimalList.Count) return;
            for (i = 0; i < n; i++)
            {
                TraiBoSua.Remove(TraiBoSua.AnimalList[0]);
            }
        }
        public void BanGaMaiDe(int n)
        {
            int i;
            if (n > TraiGa.AnimalList.Count) return;
            for (i = 0; i < n; i++)
            {
                TraiGa.Remove(TraiGa.AnimalList[0]);
            }
        }

        public void BanHeoThit(int n)
        {
            int i;
            if (n > TraiHeo.AnimalList.Count) return;
            for (i = 0; i < n; i++)
            {
                TraiHeo.Remove(TraiHeo.AnimalList[0]);
            }
        }

        public void BanCho(int n)
        {
            int i;
            if (n > TraiCho.AnimalList.Count) return;
            for (i = 0; i < n; i++)
            {
                TraiCho.Remove(TraiCho.AnimalList[0]);
            }
        }

        public void BanVatNuoi()
        {
            Console.Clear();
            MenuBanVatNuoi();
            int soluong = 0;
            Console.Write(" Lua chon : ");
            choose = int.Parse(Console.ReadLine());
            Console.Write(" Nhap so luong can Ban : ");
            soluong = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    BanBoSua(soluong);
                    break;

                case 2:
                    BanGaMaiDe(soluong);
                    break;

                case 3:
                    BanHeoThit(soluong);
                    break;

                case 4:
                    BanCho(soluong);
                    break;
            }
        }

        public double TongTienNuoi()
        {
            return TraiBoSua.TienNuoi() + TraiCho.TienNuoi() + TraiGa.TienNuoi() + TraiHeo.TienNuoi();
        }
        public void ThongTinChanNuoi()
        {
            Console.Clear();
            Console.WriteLine("{0,2} So Luong: {1,2} con. Luong thuc an : {2,2} Kg.  Tien Nuoi : {3} VND", "Bo Sua      ", TraiBoSua.Soluong(), TraiBoSua.LuongThucAn(), TraiBoSua.TienNuoi());
            Console.WriteLine("{0,2} So Luong: {1,2} con. Luong thuc an : {2,2} Kg.  Tien Nuoi : {3} VND", "Ga Lay Thit ", TraiGa.Soluong(), TraiGa.LuongThucAn(), TraiGa.TienNuoi());
            Console.WriteLine("{0,2} So Luong: {1,2} con. Luong thuc an : {2,2} Kg.  Tien Nuoi : {3} VND", "Heo         ", TraiHeo.Soluong(), TraiHeo.LuongThucAn(), TraiHeo.TienNuoi());
            Console.WriteLine("{0,2} So Luong: {1,2} con. Luong thuc an : {2,2} Kg.  Tien Nuoi : {3} VND", "Cho         ", TraiCho.Soluong(), TraiCho.LuongThucAn(), TraiCho.TienNuoi());
            Console.WriteLine();
            Console.WriteLine("Tong So Tien CHan Nuoi : " + TongTienNuoi());
        }

    }
}
