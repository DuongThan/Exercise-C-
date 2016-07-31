using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class DiemSo
    {
        private int diem;

        public int Diem
        {
            get
            {
                return diem;
            }

            set
            {
                diem = value;
            }
        }

        public DiemSo()
        {
            diem = 0;
        }

        public void ShowDiem(int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("Diem cua ban : " +diem);
        }
    }
}
