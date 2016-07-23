using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FlapyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                List<OngNuoc> list_ongNc = new List<OngNuoc>();
                Core core = new Core();
                Random rand = new Random();
                Bird bird = new Bird();
                Point point = new Point(10, 10);
                Point ogn = new Point(28, 3);
                Point ogn1 = new Point(43, 3);
                Point ogn2 = new Point(58, 3);
                Point ogn3 = new Point(73, 3);
                bird.Show(point);
                OngNuoc ong = new OngNuoc(rand.Next(3, 10));
                OngNuoc ong1 = new OngNuoc(rand.Next(3, 10));
                OngNuoc ong2 = new OngNuoc(rand.Next(3, 10));
                OngNuoc ong3 = new OngNuoc(rand.Next(3, 10));
                list_ongNc.Add(ong);
                list_ongNc.Add(ong1);
                list_ongNc.Add(ong2);
                list_ongNc.Add(ong3);
                int time = 100;

                while (true)
                {
                    Thread.Sleep(time);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo consolekeyinfo = Console.ReadKey();
                        bird.DiChuyen(consolekeyinfo.Key);
                    }
                    if (core.GhiDiem(list_ongNc, bird) == 0)
                    {
                        Console.ReadLine();
                        break;
                    }
                    if (ogn.X == 9 || ogn1.X == 9 || ogn2.X == 9 || ogn3.X == 9)
                    {
                        core.CORE1++;
                        core.ShowCore();
                        if (core.CORE1 % 5 == 0)
                        {
                            if (time > 10)
                                time -= 10;

                        }
                    }
                    ong.RunOngNuoc(ogn);
                    ong1.RunOngNuoc(ogn1);
                    ong2.RunOngNuoc(ogn2);
                    ong3.RunOngNuoc(ogn3);

                }
            }
        }
    }
}
