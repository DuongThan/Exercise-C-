using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlapyBird
{
    class Bird
    {
        private Point CurrentBird;
        private Point oldBird;
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        internal Point OldBird
        {
            get { return oldBird; }
            set { oldBird = value; }
        }

        internal Point CurrentBird1
        {
            get { return CurrentBird; }
            set { CurrentBird = value; }
        }


        public Bird()
        {
            oldBird = new Point();
        }


        public void Show(Point point)
        {
            DeleteOldBird(oldBird);
            CurrentBird = new Point(point);
            oldBird = new Point(CurrentBird);
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("*");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("");
        }

        public void DeleteOldBird(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("   ");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("   ");
            point.Y++;
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("   ");
        }

        public void DiChuyen(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.UpArrow:
                    CurrentBird.Y--;
                    Show(CurrentBird);
                    break;

                case ConsoleKey.DownArrow:
                    CurrentBird.Y++;
                    Show(CurrentBird);
                    break;

                case ConsoleKey.LeftArrow:
                    CurrentBird.X--;
                    Show(CurrentBird);
                    break;

                case ConsoleKey.RightArrow:
                    CurrentBird.X++;
                    Show(CurrentBird);
                    break;
            }
        }
    }
}
