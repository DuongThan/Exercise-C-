using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chim_Tim_Moi
{
    class Coin
    {
        private Point CurrentCoin;
        private string StrCoin;
        private KhungHinh khung;

        public string StrCoin1
        {
            get { return StrCoin; }
            set { StrCoin = value; }
        }

        internal Point CurrentCoin1
        {
            get { return CurrentCoin; }
            set { CurrentCoin = value; }
        }

        public Coin()
        {
            this.StrCoin = "@";
            khung = new KhungHinh(new Point(3, 6), new Point(75, 20));
        }

        public void ShowCoin(Point point)
        {
            CurrentPointer cu = new CurrentPointer(new Point(0,0));
            CurrentCoin = new Point(point);
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write(StrCoin);
            cu.SetCursorPostionPointer();
        }

        public void MoveCoin(int move)
        {
            ClearCoin();
            switch(move)
            {
                case 1:
                    if (CurrentCoin.X + 1 < khung.MaxPoint.X-2)
                    {
                        CurrentCoin.X++;
                    }
                    else
                    {

                    }
                    break;

                case 2:
                    if (CurrentCoin.Y + 1 < khung.MaxPoint.Y-2)
                    {
                        CurrentCoin.Y++;
                    }
                    else
                    {

                    }
                    break;

                case 3:
                    if (CurrentCoin.X - 1 > khung.MinPoint.X)
                    {
                        CurrentCoin.X--;
                    }
                    else
                    {

                    }

                    break;

                case 4:
                    if (CurrentCoin.Y - 1 > khung.MinPoint.Y)
                    {
                        CurrentCoin.Y--;
                    }
                    else
                    {

                    }
                    break;
            }
            ShowCoin(CurrentCoin);

        }


        public void ClearCoin()
        {

            Console.SetCursorPosition(CurrentCoin.X, CurrentCoin.Y);
            Console.Write(" ");
        }

    }
}
