using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array_list array = new Array_list();
            array.Push(1);
            array.Push(2);
            array.Push(3);
            array.Push(4);
            array.Push(5);
            array.Push(6);
            array.Push(7);
            array.Push(8);
            array.Push(9);
            array.ShowList();
            string x = Console.ReadLine();
            bool t=true ;
            foreach(char temp in x)
            {
                if (!char.IsDigit(temp)) t = false;
            }
            //int.TryParse(x,out t);
            if (t == true) Console.Write(int.Parse(x));
            else Console.Write("Khong phai so");
            Console.ReadLine();
        }
    }
}
