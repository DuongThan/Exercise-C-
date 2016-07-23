using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[100];
            int[] e= { 1, 13, 4, 5, 16 };
            int max = TimMax(e);
            Console.WriteLine(max);
            //int x;
            //string s;
            //s = Console.ReadLine();
            //x = int.Parse(s);
            //Console.Write("Hello hello: ");
            //Console.WriteLine(s);
            //Console.WriteLine("ket qua:" + x);
            //int a = 2, b = 4;
            //int t = tinhtong(a, b);
            //Console.WriteLine(t);
            //int n = 7;
            //bool k = kiemtra(n);
            //Console.WriteLine(k);
            //int c = 4, d = 5;
            // Hoanvi(ref c, ref d);
            // Console.WriteLine("{0}  {1}",c,d);
            Console.ReadLine();
        }
        static int tinhtong(int a, int b)
        {
            return (a + b);
        }
        static bool kiemtra(int n)
        {
          //  if (int.TryParse("123", out n))
            //{ };
            if (n < 2)
            {
                return true;
            }
            else if (n > 2)
            {
                for (int i = 2; i <= Math.Sqrt((float)n); i++)
                {
                    if (n % i == 0)
                        return false;
                }

            }
            return true;
        }
        static void Hoanvi( ref int c,ref int d)
        {

            int temp;
            temp=c;
            c= d;
            d = temp;
        }
        static int TimMax(int [] e)
        { 
            Array.Sort(e);
            int i;
            for (i = e.Length-1; i >=0; i--)
            {
                if (kiemtra(e[i]) == true)
                {
                    //return e[i];
                    break;
                }
            }
            return e[i];
        }
        List<int> l=new List<int>();
        l.Add
    }
   
}