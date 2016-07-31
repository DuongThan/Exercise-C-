using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Moi:Diem
    {
        private Diem moi_Bird;

        internal Diem Moi_Bird
        {
            get
            {
                return moi_Bird;
            }

            set
            {
                moi_Bird = value;
            }
        }

        private Random rd;

        public Moi()
        {
            rd = new Random();
            moi_Bird = new Diem(rd.Next(3,76),rd.Next(6,20));
        }
        public override void Show()
        {
            Console.SetCursorPosition(moi_Bird.X, moi_Bird.Y);
            Console.Write("*");
        }

        public void XoaMoi()
        {
            Console.SetCursorPosition(moi_Bird.X, moi_Bird.Y);
            Console.Write(" ");
        }
    }
}
