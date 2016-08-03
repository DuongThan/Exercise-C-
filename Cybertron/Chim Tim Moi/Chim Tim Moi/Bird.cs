using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chim_Tim_Moi
{
    class Bird
    {
        private Point currentPoint;
        private CurrentPointer cur;
        private KhungHinh khung;
        private bool isRun;

        public bool IsRun
        {
            get { return isRun; }
            set { isRun = value; }
        }

        internal Point CurrentPoint
        {
            get { return currentPoint; }
            set { currentPoint = value; }
        }
        private int hightBird;

        public int HightBird
        {
            get { return hightBird; }
            set { hightBird = value; }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Bird()
        {
            this.hightBird = 3;
            this.width = 3;
            cur = new CurrentPointer(new Point(0, 0));
            isRun = true;
            khung = new KhungHinh(new Point(3, 6), new Point(75, 20));

        }

        public void ShowBird(Point point)
        {
            currentPoint = new Point(point);
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("===");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("===");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("===");
            cur.SetCursorPostionPointer();
        }

        public void MoveBird(ConsoleKey key)
        {

            DeleteBird(currentPoint);
            switch(key)
            {
                case ConsoleKey.W: case ConsoleKey.UpArrow:
                    if( currentPoint.Y-1> khung.MinPoint.Y)
                    {
                        currentPoint.Y--;
                        isRun = true;
                    }
                    else
                    {
                        isRun = false;
                    }
                    break;

                case ConsoleKey.S: case ConsoleKey.DownArrow:
                    if (currentPoint.Y+1 < khung.MaxPoint.Y-2 )
                    {
                        currentPoint.Y++;
                        isRun = true;
                    }
                    else
                    {
                        isRun = false;
                    }
                    break;

                case ConsoleKey.F:case ConsoleKey.RightArrow:
                    if (currentPoint.X+1 < khung.MaxPoint.X-2 )
                    {
                        currentPoint.X++;
                        isRun = true;
                    }
                    else
                    {
                        isRun = false;
                    }
                    break;

                case ConsoleKey.A:case ConsoleKey.LeftArrow:
                    if (currentPoint.X-1 > khung.MinPoint.X )
                    {
                        currentPoint.X--;
                        isRun = true;
                    }
                    else
                    {
                        isRun = false;
                    }
                    break;
            }
            ShowBird(currentPoint);
            
        }

        public void DeleteBird(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("   ");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("   ");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("   ");

            point.Y-=2;
            cur.SetCursorPostionPointer();
        }

        public bool DieuKien()
        {
            if (currentPoint.X > khung.MinPoint.X
                && currentPoint.X + hightBird < khung.MaxPoint.X
                && currentPoint.Y > khung.MinPoint.Y
                && currentPoint.Y + width < khung.MaxPoint.Y)
            {
                return true;
            }
            return false;
        }

    }
}
