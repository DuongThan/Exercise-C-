using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class XuLyChuoi
    {
        public int SoKyTu(string chuoi)
        {
            chuoi = chuoi.Replace(" ", "");
            return chuoi.Length;
        }

        public int SoChuCai(string chuoi)
        {
            int n = 0;
            foreach(char temp in chuoi)
            {
                if(char.IsLetter(temp))
                {
                    n++;
                }
            }
            return n;
        }

        public int SoChuSo(string chuoi)
        {
            int n = 0;
            foreach (char temp in chuoi)
            {
                if (char.IsNumber(temp))
                {
                    n++;
                }
            }
            return n;
        }

        public string CatChamLien(string chuoi)
        {
            string ch = null;
            char c;
            int i, j;
            for (i = 0; i < chuoi.Length; i++)
            {
                c = chuoi[i];
                if (c == '.')
                {
                    ch = null;
                    ch = ch + chuoi.Substring(0, i + 1);
                    for (j = i + 1; j < chuoi.Length; j++)
                    {
                        char c2 = chuoi[j];
                        if (c2 != '.')
                        {
                            ch = ch + chuoi.Substring(j);
                            chuoi = ch;
                            break;
                        }
                    }
                }
            }
            return chuoi;
        }
        public string CatPhayLien(string chuoi)
        {
            string ch = null;
            char c;
            int i, j;
            for (i = 0; i < chuoi.Length; i++)
            {
                c = chuoi[i];
                if (c == ',')
                {
                    ch = null;
                    ch = ch + chuoi.Substring(0, i + 1);
                    for (j = i + 1; j < chuoi.Length; j++)
                    {
                        char c2 = chuoi[j];
                        if (c2 != ',')
                        {
                            ch = ch + chuoi.Substring(j);
                            chuoi = ch;
                            break;
                        }
                    }
                }
            }
            return chuoi;
        }

        public string ChamPhayLien(string chuoi)
        {
            int t = chuoi.IndexOf('.', 0);
            while (t >= 0)
            {
                if ((t + 1) < chuoi.Length && chuoi[t + 1] == ',')
                {
                    chuoi = chuoi.Replace(".,", ",");
                    t = chuoi.IndexOf('.', 0);
                }
                else t = chuoi.IndexOf('.', t + 1);
            }
            return chuoi;
        }

        public string PhayChamLien(string chuoi)
        {
            int t = chuoi.IndexOf(',', 0);
            while (t >= 0)
            {
                if (chuoi[t + 1] == '.')
                {
                    chuoi = chuoi.Replace(",.", ".");
                    t = chuoi.IndexOf(',', 0);
                }
                else t = chuoi.IndexOf(',', t + 1);
            }
            return chuoi;
        }

        public string HoaSauCham(string chuoi)
        {
            List<string> list_string;
            list_string = new List<string>();

            char[] KyTyDB = { ' ', '{', '}', '[', ']', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', ':', '(', ')', '-', '=', '\\', '|', ';', '\'', '<', '>', '?', '/', '\t' };
            string[] S = chuoi.Split(KyTyDB);
            int i;
            for (i = 0; i < S.Length; i++)
            {
                if (S[i] != "" && (S[0] != "." || S[0] != ","))
                {
                    list_string.Add(S[i]);
                }
            }
            chuoi = list_string[0];
            for (i = 1; i < list_string.Count(); i++)
            {
                if (list_string[i] == "." || list_string[i] == ",")
                {
                    chuoi = chuoi + list_string[i];
                }
                else
                {
                    if (i - 1 >= 0 && list_string[i - 1] == ".")
                    {
                        list_string[i] = list_string[i].Substring(0, 1).ToUpper() + list_string[i].Substring(1).ToLower();
                    }
                    chuoi = chuoi + " " + list_string[i];
                }
            }
            return chuoi;
        }

        public string Loaidaudau(string chuoi)
        {
            if (chuoi.Substring(0, 1) == "." || chuoi.Substring(0, 1) == ",")
                chuoi = chuoi.Substring(2, 1).ToUpper() + chuoi.Substring(3)+".";
            else
                chuoi = chuoi.Substring(0, 1).ToUpper() + chuoi.Substring(1) + ".";
            return chuoi;
        }

        public string ChuanHoa(string chuoi)
        {
            // xoa khoang trang dau cuoi
            chuoi = chuoi.Trim();
            // tach chuoi, tach ca dau cham
            chuoi = chuoi.Replace(".", "*.*");
            // tach dau phay khoi chuoi
            chuoi = chuoi.Replace(",", "*,*");
            // viet hoa sau dau cham
            chuoi = HoaSauCham(chuoi);
            // loai phay cham lien
            chuoi = PhayChamLien(chuoi);
            // loai cham phay lien
            chuoi = ChamPhayLien(chuoi);
            // loai phay lien tiep nhau
            chuoi = CatPhayLien(chuoi);
            //loai dau dau dong, dong thoi viet hoa dau dong, them dau cham cau;
            chuoi = Loaidaudau(chuoi);
            // loai cham lien tiep nhau
            chuoi = CatChamLien(chuoi);
            return chuoi;
        }
    }
}
