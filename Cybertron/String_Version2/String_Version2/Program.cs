using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String_Version2
{
    class Program
    {
        static ChuanHoa chuanHoa = new ChuanHoa();
        static StreamWriter writeHistory;
        static string Text_History;
        static List<string> Contain_List = new List<string>();

        static void ReadFile()
        {
            Contain_List.Clear();
            StreamReader read = new StreamReader("filestring.txt");
            string row;
            while ((row = read.ReadLine()) != null)
            {
                Contain_List.Add(row);
            }

            read.Close();
        }

        static void WriteFile()
        {
            StreamWriter write = new StreamWriter("filestring.txt", false);
            foreach(var item in Contain_List)
            {
                write.WriteLine(item);
            }
            write.Close();
        }

        static void TimKiem()
        {
            //------------------------------------------------------------------
            writeHistory = new StreamWriter("History.txt", true);
            //------------------------------------------------------------------
            Console.WriteLine();
            Console.Write("Nhap chuoi can tim kiem : ");
            string s = Console.ReadLine();
            //------------------------------------------------------------------
            writeHistory.WriteLine("TimKiem() : "+s);
            //------------------------------------------------------------------

            List<int> viTriThay = new List<int>();
            Chuoi ch;

            Console.WriteLine("Vi tri tim thay : ");


            //------------------------------------------------------------------
            writeHistory.WriteLine("Result :");
            writeHistory.WriteLine();
            writeHistory.WriteLine("Da thay the vi tri");
            writeHistory.WriteLine();
            //------------------------------------------------------------------

            int row = 1;
            foreach (var item in Contain_List)
            {
                ch = new Chuoi(item);
                Console.Write("Row : " + row + "  Collum : ");
                foreach (var temp in ch.ViTriTK(s))
                {
                    Console.Write(temp + ", ");
                    //------------------------------------------------------------------
                    writeHistory.Write(temp + ", ");
                    //------------------------------------------------------------------
                }
                Console.WriteLine();
                row++;
            }

            writeHistory.WriteLine();
            writeHistory.WriteLine("=============================================================");
            writeHistory.Close();
            Console.ReadLine();
        }

        static void ThayThe()
        {
            writeHistory = new StreamWriter("History.txt", true);
            Console.WriteLine();
            Console.Write("Nhap chuoi can thay the : ");
            string old_s = Console.ReadLine();
            Console.Write("Nhap chuoi thay the : ");
            string new_s = Console.ReadLine();
            if (old_s == "" || new_s == "")
            {
                Console.WriteLine("Chuoi nhap khong hop le");
                writeHistory.Close();
                Console.ReadLine();
                return;
            }


            string FullText = null;
            foreach (string item in Contain_List)
            {
                FullText += Environment.NewLine + item;
            }

            Chuoi chuoi = new Chuoi(FullText);
            List<string> thayThe = new List<string>();
            if (chuoi.Search(old_s, 0) >= 0)
            {
                foreach (string item in Contain_List)
                {
                    chuoi = new Chuoi(item);
                    thayThe.Add(chuoi.ThayThe(old_s, new_s));
                }
                Console.WriteLine("Van ban da duoc chinh sua");
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi de thay the");
                Console.ReadLine();
                //------------------------------------------------------------------
                writeHistory.WriteLine("ThayThe(" + old_s + "," + new_s + ")");
                writeHistory.WriteLine("Input" + Environment.NewLine + "Text");
                writeHistory.WriteLine(chuoi.ChuoiVanBan);
                writeHistory.WriteLine();
                writeHistory.WriteLine("Old_Word : " + old_s);
                writeHistory.WriteLine("New_Word : " + new_s);
                writeHistory.WriteLine();
                writeHistory.WriteLine("Result :");
                writeHistory.WriteLine("Khong tinthay chuoi thay the");
                writeHistory.WriteLine();
                writeHistory.WriteLine("=============================================================");
                writeHistory.Close();
                //------------------------------------------------------------------
                return;
            }


            //------------------------------------------------------------------
            writeHistory.WriteLine("ThayThe(" + old_s + "," + new_s + ")");
            writeHistory.WriteLine("Input" + Environment.NewLine + "Text");
            writeHistory.WriteLine();
            foreach (string item in thayThe)
            {
                writeHistory.WriteLine(item);
            }
            writeHistory.WriteLine();
            writeHistory.WriteLine("Old_Word : " + old_s);
            writeHistory.WriteLine("New_Word : " + new_s);
            writeHistory.WriteLine();
            writeHistory.WriteLine("Result :");
            writeHistory.WriteLine();
            writeHistory.WriteLine("Da thay the vi tri");
            writeHistory.WriteLine();
            //------------------------------------------------------------------

            int row = 1;
            foreach (var item in Contain_List)
            {
                chuoi = new Chuoi(item);
                writeHistory.Write("Row : " + row + "  Collum : ");
                foreach (var temp in chuoi.ViTriTK(old_s))
                {
                    writeHistory.Write(temp + ", ");
                }
                writeHistory.WriteLine();
                row++;
            }
            writeHistory.WriteLine();
            writeHistory.WriteLine("=============================================================");
            writeHistory.Close();
            Contain_List = thayThe;
            WriteFile();
            //------------------------------------------------------------------
            Console.ReadLine();
        }

        static void ChuanHoa()
        {
            Chuoi chuoi;
            Console.WriteLine();
            int i;
            for (i = 0; i < Contain_List.Count; i++) 
            {
                chuoi = new Chuoi(Contain_List[i]);
                Contain_List[i] = chuanHoa.Chuan_Hoa(Contain_List[i]);
            }
            WriteFile();
            Console.WriteLine("Van ban da duoc chuan hoa");

            //------------------------------------------------------------------
            writeHistory = new StreamWriter("History.txt", true);
            writeHistory.WriteLine("ChuanHoa()");
            writeHistory.WriteLine();
            foreach (string item in Contain_List)
            {
                writeHistory.WriteLine(item);
            }
            writeHistory.WriteLine("Van ban da duoc chuan hoa");
            writeHistory.WriteLine();
            writeHistory.WriteLine("=============================================================");
            writeHistory.Close();
            //------------------------------------------------------------------
            Console.ReadLine();
        }

        static void MainMenu()
        {
            Console.WriteLine("1. Tim kiem chuoi");
            Console.WriteLine("2. Thay the chuoi");
            Console.WriteLine("3. Chuan hoa chuoi");
            Console.WriteLine("4. Lich su");
        }

        static void ReadFileHistory()
        {
            StreamReader read = new StreamReader("History.txt");
            Text_History = read.ReadToEnd();
            read.Close();
            Console.WriteLine(Text_History);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DateTime date;
            while(true)
            {
               
                Console.Clear();
                ReadFile();
                Console.SetCursorPosition(30,1);
                Console.WriteLine("VAN BAN : ");
                foreach(string item in Contain_List)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(Environment.NewLine);
                MainMenu();
                Console.Write("Choose : ");
                ConsoleKeyInfo infokey = Console.ReadKey();

                if (infokey.Key == ConsoleKey.D1 || infokey.Key == ConsoleKey.D2 || infokey.Key == ConsoleKey.D3)
                {
                    date = DateTime.Now;
                    writeHistory = new StreamWriter("History.txt", true);
                    writeHistory.WriteLine();
                    writeHistory.WriteLine("=============================================================");
                    writeHistory.WriteLine("Time : " + date.ToString());
                    writeHistory.Close();
                }
                switch(infokey.Key)
                {
                    case ConsoleKey.D1:
                        TimKiem();
                        break;

                    case ConsoleKey.D2:
                        ThayThe();
                        break;

                    case ConsoleKey.D3:
                        ChuanHoa();
                        break;

                    case ConsoleKey.D4:
                        ReadFileHistory();
                        break;

                    default:
                        return;
                }
            }
        }
    }
}
