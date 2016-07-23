using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chim_Tim_Moi
{
    class App
    {
        private int Point_Game;

        public int Point_Game1
        {
            get { return Point_Game; }
            set { Point_Game = value; }
        }
        public App()
        {
            this.Point_Game = 0;
        }

        public void RunGame()
        {
            int rd = 1; // 1-4 chuyen huong cho icoin
            int rd1 = 0; // dieu kien chuyn huong ? ( 1-4)
            Random rand = new Random();
            Point pointBird = new Point(8, 8);
            Point pointCoin = new Point(12, 17);
            KhungHinh khung = new KhungHinh(new Point(3, 6), new Point(75, 20));
            Bird bird = new Bird();
            Coin coin = new Coin();
            TimeRun time = new TimeRun();
            bird.ShowBird(pointBird);
            Console.SetCursorPosition(35, 2);
            Console.Write("Diem : " + Point_Game);
            int Time_deminished = 0;

            coin.ShowCoin(pointCoin);
            time.ShowTime();

            khung.ShowKhung();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo conif = Console.ReadKey();
                    bird.MoveBird(conif.Key);
                }

                Console.SetCursorPosition(0,0);
                Console.Write(" ");
                Thread.Sleep(10);

                rd1 = rand.Next(1, 100);
                if (rd1 % 3 == 0)
                {
                    rd = rand.Next(0, 5);
                }

                if (coin.CurrentCoin1.X >= bird.CurrentPoint.X
                && coin.CurrentCoin1.X < bird.CurrentPoint.X + bird.HightBird
                && coin.CurrentCoin1.Y < bird.CurrentPoint.Y + bird.Width
                && coin.CurrentCoin1.Y >= bird.CurrentPoint.Y)
                {
                    ++Point_Game;
                    Console.SetCursorPosition(35, 2);
                    Console.Write("Diem : " + Point_Game);
                    Console.SetCursorPosition(coin.CurrentCoin1.X, coin.CurrentCoin1.Y);
                    Console.Write("=");
                    coin.CurrentCoin1 = new Point(rand.Next(7, 70), rand.Next(7, 20));
                    time = new TimeRun();
                    if (Point_Game % 5 == 0)
                    {
                        Time_deminished++;
                    }
                    time.Time_end1 -= Time_deminished;
                }
                if(time.GetTime())
                {
                    time.ShowTime();
                    break;
                }
                Thread.Sleep(1);
                time.ShowTime();
                coin.MoveCoin(rd);

            }
        }
    }
}
