using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Chim_Tim_Moi
{
    class KhungHinh
    {
        private Point minPoint;
        private CurrentPointer cur;

        internal Point MinPoint
        {
            get { return minPoint; }
            set { minPoint = value; }
        }
        private Point maxPoint;

        internal Point MaxPoint
        {
            get { return maxPoint; }
            set { maxPoint = value; }
        }

        public KhungHinh(Point min,Point max)
        {
            this.minPoint = min;
            this.maxPoint = max;
            cur = new CurrentPointer(new Point(0, 0));
        }


        public void ShowKhung()
        {
            int i;
            Thread.Sleep(10);
            for (i = minPoint.X; i <= maxPoint.X; i++)
            {
                Console.SetCursorPosition(i, minPoint.Y);
                Console.Write("-");
                Console.SetCursorPosition(i, maxPoint.Y);
                Console.Write("-");
                cur.SetCursorPostionPointer();
            }
            cur.SetCursorPostionPointer();

            for (i = minPoint.Y+1; i < maxPoint.Y; i++)
            {
                Console.SetCursorPosition(minPoint.X,i);
                Console.Write("|");
                Console.SetCursorPosition(maxPoint.X,i);
                Console.Write("|");
                cur.SetCursorPostionPointer();
            }
            cur.SetCursorPostionPointer();
        }
    }
}
