using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_WF
{
    class QuanLy
    {
        private List<SinhVien> list_SinhVien;

        internal List<SinhVien> List_SinhVien
        {
            get
            {
                return list_SinhVien;
            }

            set
            {
                list_SinhVien = value;
            }
        }

        public QuanLy()
        {
            list_SinhVien = new List<SinhVien>();
        }

        public void Add(SinhVien sv)
        {
            list_SinhVien.Add(sv);
        }

        public void Remove(SinhVien sv)
        {
            List_SinhVien.Remove(sv);
        }

        public int Search(string maSV)
        {
            for (int i = 0; i < list_SinhVien.Count(); i++)
            {
                if (maSV == list_SinhVien[i].MaSV)
                    return i;
            }
            return -1;
        }
    }
}
