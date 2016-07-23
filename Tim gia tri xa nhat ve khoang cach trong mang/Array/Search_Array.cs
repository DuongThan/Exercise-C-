using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Search_Array
    {
        private List<int> ListArray;
        private List<int> KQ;

        public List<int> KQ1
        {
            get { return KQ; }
            set { KQ = value; }
        }


        public Search_Array()
        {
            Random rand = new Random();
            ListArray = new List<int> {  rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8) };
        }

        public List<int> ListArray1
        {
            get { return ListArray; }
            set { ListArray = value; }
        }

        public void ShowList(List<int> list_)
        {
            Console.WriteLine("Danh sach cac ohan tu tong list : ");
            foreach(int temp in list_)
            {
                Console.Write("{0,4}  ", temp);
            }
            Console.WriteLine();
        }

        public List<int> Search(int temp)
        {
            List<int> ViTri = new List<int>();
            List<int> GiaTri = new List<int>(); 
            if (ListArray1.Contains(temp))
            {
                int i;
                for(i=0;i<ListArray1.Count;i++)
                {
                    if (ListArray1[i] == temp)
                    {
                        ViTri.Add(i);
                    }
                }
                int vttb = ListArray1.Count / 2;
                if(   (ViTri[0] >= vttb && ListArray1.Count %2==0  ) || (ViTri[0] > vttb && ListArray1.Count % 2 != 0))
                {
                    GiaTri.Add(ListArray1[0]);
                }
                else if (ViTri[ViTri.Count - 1] < vttb)
                {
                    GiaTri.Add(ListArray1[ListArray1.Count - 1]);
                }
                else
                {
                    GiaTri.Add(ListArray1[0]);
                    GiaTri.Add(ListArray1[ListArray1.Count - 1]);
                }

                return GiaTri;
            }
            return null;

        }

        public void KetLuan(int temp)
        {
            KQ = Search(temp);
            if(KQ==null)
            {
                Console.WriteLine(" Gia tri nhap khong co trong day ");
                return;
            }
            Console.WriteLine("Gia tri xa nhat ve khoang cach trong mang la : ");
            foreach(int temp1 in KQ)
            {
                if (temp1 != temp) 
                Console.Write("  {0,3} ",temp1);
            }
            Console.WriteLine();
        }
    }
}
