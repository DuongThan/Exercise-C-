using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FlapyBird
{
    class OngNuoc
    {
        private Point CurrentOngNuoc;
        private int roll;
        private List<Point> list_toadoOn;
        private Point currentPoint;

        internal List<Point> List_toadoOn
        {
            get { return list_toadoOn; }
            set { list_toadoOn = value; }
        }

        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        private int colum;

        public int Colum
        {
            get { return colum; }
            set { colum = value; }
        }

        internal Point CurrentOngNuoc1
        {
            get { return CurrentOngNuoc; }
            set { CurrentOngNuoc = value; }
        }

        public OngNuoc()
        {
            this.colum = 6;
            this.roll = 4;
            list_toadoOn = new List<Point>();
        }
        public OngNuoc( int roll1)
        {
            this.roll = roll1;
            list_toadoOn = new List<Point>();
        }

        public void Show(Point point)
        {
            list_toadoOn.Clear();
            DieuKien(ref point);
            point.X--;
            int k = point.Y;
            int i = 0;
            for(i=0;i<roll;i++)
            {
                currentPoint = new Point(point);
                list_toadoOn.Add(currentPoint);
                Console.SetCursorPosition(point.X, point.Y);
                Console.WriteLine("******");
                point.Y++;
            }

            point.Y += 4;
            for (i = 0; i < 14-roll; i++)
            {
                currentPoint = new Point(point);
                list_toadoOn.Add(currentPoint);
                Console.SetCursorPosition(point.X, point.Y);
                Console.WriteLine("******");
                point.Y++;
            }
            point.Y = k;


            for (i = 0; i < roll; i++)
            {
                Console.SetCursorPosition(point.X+6, point.Y);
                Console.WriteLine(" ");
                point.Y++;
            }

            point.Y += 4;
            for (i = 0; i < 14 - roll; i++)
            {
                Console.SetCursorPosition(point.X+6, point.Y);
                Console.WriteLine(" ");
                point.Y++;
            }
            point.Y = k;

        }


        public void RunOngNuoc(Point point)
        {
            Show(point);
        }
        public void DieuKien(ref Point point)
        {
            
            if(point.X<2)
            {
                Random rand = new Random();
                point.X = 60;
                roll = rand.Next(3, 10);

                for(int i=3;i<24;i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("       ");
                }
            }
        }
    }
}
