using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Version2
{
    class ChuanHoa
    {

        public void TachKyTuDB(ref string chuoiVanBan)
        {
            chuoiVanBan.Trim();
            chuoiVanBan = chuoiVanBan.Replace(",", "*,*");
            chuoiVanBan = chuoiVanBan.Replace(".", "*.*");
            string[] mangchuoitach = chuoiVanBan.Split('!', '@','$', '#', '%', '^', '&', '*', '*', '(', ')', ' ', '-', '=', '+', '/', '<', '>', '?', ':', ';', '\"', '|', '`', '~');
            chuoiVanBan = mangchuoitach[0];
            for (int i = 1; i < mangchuoitach.Length; i++)
            {
                string chuoicon = mangchuoitach[i];
                if (chuoicon != "")
                {
                    chuoiVanBan += " " + chuoicon;
                }

            }
        }

        public void XuLyPhay(ref string chuoiVanBan)
        {
            int t = chuoiVanBan.IndexOf(",");
            while (t > 0)
            {
                chuoiVanBan = chuoiVanBan.Remove(t - 1, 1);
                t = chuoiVanBan.IndexOf(",", t);
            }
        }

        public void XuLyCham(ref string chuoiVanBan)
        {
            int t = chuoiVanBan.IndexOf(".");
            while (t > 0)
            {
                if (t + 2 < chuoiVanBan.Length)
                {
                    string s = chuoiVanBan.Substring(0, t);
                    chuoiVanBan = chuoiVanBan.Substring(0, t + 2) + chuoiVanBan.Substring(t + 2, 1).ToUpper() + chuoiVanBan.Substring(t + 3);
                }
                chuoiVanBan = chuoiVanBan.Remove(t - 1, 1);
                t = chuoiVanBan.IndexOf(".", t);
            }
        }

        public void XuLyDauDong(ref string chuoiVanBan)
        {
            while (chuoiVanBan.Substring(0, 1) == "." || chuoiVanBan.Substring(0, 1) == "," || chuoiVanBan.Substring(0, 1) == " ")
            {
                chuoiVanBan = chuoiVanBan.Remove(0, 1);
            }
            chuoiVanBan = chuoiVanBan.Substring(0, 1).ToUpper() + chuoiVanBan.Substring(1);
        }

        public string Chuan_Hoa(string chuoiVanBan)
        {
            TachKyTuDB(ref chuoiVanBan);
            XuLyPhay(ref chuoiVanBan);
            XuLyCham(ref chuoiVanBan);
            XuLyDauDong(ref chuoiVanBan);
            return chuoiVanBan;
        }
    }
}
