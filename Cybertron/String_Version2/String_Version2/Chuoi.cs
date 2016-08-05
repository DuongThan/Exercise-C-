using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Version2
{
    class Chuoi
    {
        private string chuoiVanBan;

        public string ChuoiVanBan
        {
            get
            {
                return chuoiVanBan;
            }

            set
            {
                chuoiVanBan = value;
            }
        }

        public Chuoi(string s)
        {
            chuoiVanBan = s;
        }

        public Chuoi()
        {

        }
        
        public int Search(string s,int index)
        {
            int vt = chuoiVanBan.IndexOf(s,index);
            return vt;
        }
        public List<int> ViTriTK(string s)
        {
            List<int> viTri = new List<int>();
            int t = Search(s,0);
            while(t>=0)
            {
                viTri.Add(t);
                if (t + 1 < chuoiVanBan.Length)
                    t = Search(s, t + 1);
                else break;
            }
            return viTri;
        }
        public string ThayThe(string oldstring, string newstring)
        {
                return chuoiVanBan.Replace(oldstring,newstring);
        }

        
    }
}
