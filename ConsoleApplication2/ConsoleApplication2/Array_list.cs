using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Array_list
    {
        private List<int> list_array;

        public List<int> List_array
        {
            get { return list_array; }
            set { list_array = value; }
        }
        public Array_list()
        {
            list_array = new List<int>();
        }

        public void Push(int info)
        {
            list_array.Add(info);
        }

        public void Pop()
        {
            list_array.Remove(list_array.Count-1);
        }
        public void ShowList()
        {
            foreach(int temp in list_array)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
