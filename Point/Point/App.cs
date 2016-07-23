using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Point
{
    class App
    {
        private int Mat;
        private Point MoiAn;

        internal Point MoiAn1
        {
            get { return MoiAn; }
            set { MoiAn = value; }
        }

        public int Mat1
        {
            get { return Mat; }
            set { Mat = value; }
        }
       public void Run()
        {
            Mat = 0;
            Random rand = new Random();
            Point point = new Point(4, 4);
            HinhVuong hv = new HinhVuong();
            int diem = 0;

            MoiAn = new Point(rand.Next(3, 8), rand.Next(3, 8));

            hv.Show(ref point);
            while (true)
            {
                Thread.Sleep(190);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    hv.Moverment(key.Key, ref point);
                }
                hv.Show(ref point);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(diem);
                if (Mat == 0)
                {
                    MoiAn.ShowPoint();
                }
                else
                {
                    MoiAn = new Point(rand.Next(3, 60), rand.Next(3, 29));
                    Mat = 0;
                }
                if ((MoiAn.X == point.X) && (MoiAn.Y == point.Y))
                {
                    diem++;
                    Mat = 1;
                }

            }
        }
    }
}
