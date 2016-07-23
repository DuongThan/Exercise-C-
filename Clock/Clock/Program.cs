using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            StopDate stoptime = new StopDate();

            stoptime.Start();
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyinfo = Console.ReadKey();
                    if (keyinfo.Key == ConsoleKey.R) 
                    {
                        stoptime.Start();
                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                    if (keyinfo.Key == ConsoleKey.Spacebar)
                    {
                        stoptime.Resume();
                    }

                }

                stoptime.Count();
                Thread.Sleep(10);
                stoptime.Show(20, 20);
            }

        }
    }
}
