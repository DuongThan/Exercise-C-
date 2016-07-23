using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Point
{
    class HinhVuong
    {
        private Point currentPoint;
        private int Huong;
        private List<Point> list_point;

        internal List<Point> List_point
        {
            get { return list_point; }
            set { list_point = value; }
        }

        public int Huong1
        {
            get { return Huong; }
            set { Huong = value; }
        }

        public HinhVuong()
        {
            this.Huong = 2;
            list_point = new List<Point>();
        }

       public void Show(ref Point point)
        {
            Console.Clear();
            currentPoint = new Point(point);
            list_point.Add(currentPoint);
            switch (Huong)
            {
                case 0:
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("@**");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y -= 2;
                    break;
                case 1:
                    DieuKien(ref point);
                    point.X++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("@**");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y -= 2;
                    break;

                case 2:
                    DieuKien(ref point);
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("@**");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                   point.Y -= 2;
                    break;

                case 3:
                    DieuKien(ref point);
                    point.X--;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("@**");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                   point.Y -= 2;
                    break;

                case 4:
                    DieuKien(ref point);
                    point.Y--;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("@**");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y++;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.WriteLine("***");
                    point.Y -= 2;
                    break;
            }
            currentPoint = new Point(point);
        }

        public void ShowList()
       {
            foreach(Point item in list_point)
            {
                Console.WriteLine(item.X + "  " + item.Y);
            }
       }

        public void DieuKien(ref Point point)
       {
            if(point.X<3)
            {
                point.X  = 70;
                Huong = 3;
            }
            if(point.X>70)
            {
                point.X =  3;
                Huong = 1;
            }
            if (point.Y < 3)
            {
                point.Y = 30;
                Huong = 4;
            }
            if (point.Y> 30)
            {
                point.Y =3;
                Huong = 2;
            }
       }

        public void Moverment(ConsoleKey key,ref Point point)
       {
           point = currentPoint;
            switch(key)
            {
                case ConsoleKey.UpArrow:
                    currentPoint.Y--;
                    Huong = 4;
                    Show(ref currentPoint);
                    break;

                case ConsoleKey.DownArrow:
                    currentPoint.Y++;
                    Huong = 2;
                    Show(ref currentPoint);
                    break;

                case ConsoleKey.LeftArrow:
                    currentPoint.X--;
                    Huong = 3;
                    Show(ref currentPoint);
                    break;

                case ConsoleKey.RightArrow:
                    currentPoint.X++;
                    Huong = 1;
                    Show(ref currentPoint);
                    break;

                case ConsoleKey.Spacebar:
                    break;
            }
       }
    }
}
