using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            while(true)
            {
                Console.Clear();
                menu.Show_Menu();
                Console.WriteLine("Choose : ");
                ConsoleKeyInfo infokey = Console.ReadKey();
                switch (infokey.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        menu.Add_();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        menu.Remove_();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        menu.Infomation();
                        Console.ReadLine();
                        break;
                       

                    default:
                        return;
                }
            }
        }
    }
}
