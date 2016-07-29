using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    class QuanLyTrangTrai
    {
        private QuanLy traiCho;
        private QuanLy traiGa;
        private QuanLy traiLon;
        private string choose;
        


        public QuanLyTrangTrai()
        {
            traiGa = new QuanLy();
            TraiLon = new QuanLy();
            traiCho = new QuanLy();
        }

        internal QuanLy TraiCho
        {
            get
            {
                return traiCho;
            }

            set
            {
                traiCho = value;
            }
        }

        internal QuanLy TraiGa
        {
            get
            {
                return traiGa;
            }

            set
            {
                traiGa = value;
            }
        }

        internal QuanLy TraiLon
        {
            get
            {
                return traiLon;
            }

            set
            {
                traiLon = value;
            }
        }

        private DongVat dongVat;

        public void MuaCho(int n)
        {
            for (int i = 0; i < n; i++)
            {
                dongVat = new Cho();
                traiCho.ThemMoi(dongVat);
            }
        }

        public void MuaLon(int n)
        {
            for (int i = 0; i < n; i++)
            {
                dongVat = new Lon();
                traiLon.List_DongVat.Add(dongVat);
            }
        }

        public void MuaGa(int n)
        {
            for (int i = 0; i < n; i++)
            {
                dongVat = new Ga();
                TraiGa.List_DongVat.Add(dongVat);
            }
        }

        public void Mua()
        {
            Console.Clear();
            Console.WriteLine("1. Mua cho");
            Console.WriteLine("2. Mua lon");
            Console.WriteLine("3. Mua ga");
            Console.Write(" Mua gi : ");
            choose = Console.ReadLine();
            Console.WriteLine("So luong mua");
            int n = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case "1":
                    MuaCho(n);
                    break;

                case "2":
                    MuaLon(n);
                    break;

                case "3":
                    MuaGa(n);
                    break;

            }

        }

        public void BanCho(int n)
        {
            // kiểm tra số lượng bán có hợp lí không
            for (int i = 0; i < n; i++)
            {
                traiCho.Ban(traiCho.List_DongVat[0]);
            }
        }

        public void BanLon(int n)
        {
            for (int i = 0; i < n; i++)
            {
                traiLon.Ban(traiLon.List_DongVat[0]);
            }
        }

        public void BanGa(int n)
        {
            for (int i = 0; i < n; i++)
            {
                traiGa.Ban(traiGa.List_DongVat[0]);
            }
        }

        public void Ban()
        {
            Console.WriteLine("1. Ban cho");
            Console.WriteLine("2. Ban lon");
            Console.WriteLine("3. Ban ga");
            Console.Write(" Ban gi : ");
            choose = Console.ReadLine();
            Console.WriteLine("So luong Ban");
            int n = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case "1":
                    BanCho(n);
                    break;

                case "2":
                    BanLon(n);
                    break;

                case "3":
                    BanGa(n);
                    break;

            }

        }



        public void XuatThongTin()
        {
            Console.Clear();
            Console.WriteLine("So luong con trong trai ga : " + traiGa.soluong());
            Console.WriteLine("So luong con trong trai lon : " + traiLon.soluong());
            Console.WriteLine("So luong con trong trai cho : " + traiCho.soluong());
        }


        public void MenuMain()
        {
            Console.Clear();
            Console.WriteLine("1. Mua them ");
            Console.WriteLine("2. Ban di ");
            Console.WriteLine("3. Thong tin  ");
            Console.Write("Choose : ");
            choose = Console.ReadLine();
            switch(choose)
            {
                case "1":
                    Mua();
                    break;

                case "2":
                    Ban();
                    break;
                case "3":
                    XuatThongTin();
                    break;

            }

        }

    }
}
