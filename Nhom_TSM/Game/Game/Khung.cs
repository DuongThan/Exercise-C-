using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Khung:Diem
    {
        private Diem minPoint;
        private Diem maxPoint;

        internal Diem MaxPoint
        {
            get
            {
                return maxPoint;
            }

            set
            {
                maxPoint = value;
            }
        }

        internal Diem MinPoint
        {
            get
            {
                return minPoint;
            }

            set
            {
                minPoint = value;
            }
        }

        public Khung()
        {
            minPoint = new Diem(2, 5);
            maxPoint = new Diem(77, 20);
        }

        public override void Show()
        {
            int i;
            // ve khung theo chieu ngang
            for (i = minPoint.X; i < maxPoint.X; i++)
            {
                Console.SetCursorPosition(i, minPoint.Y);
                Console.Write("-");

                Console.SetCursorPosition(i, maxPoint.Y);
                Console.Write("-");
            }
            // ve khung theo chieu doc
            for (i = minPoint.Y+1; i < maxPoint.Y; i++)
            {
                Console.SetCursorPosition(minPoint.X, i);
                Console.Write("|");

                Console.SetCursorPosition(maxPoint.X-1, i);
                Console.Write("|");
            }
        }
    }
}
