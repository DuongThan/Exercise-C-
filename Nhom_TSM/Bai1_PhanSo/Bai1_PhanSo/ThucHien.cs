using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_PhanSo
{
    public class ThucHien
    {

        public void Nhap(PhanSo phanSo)
        {
            float tu,mau;
            Console.WriteLine("Nhap tu so : ");
            while(!float.TryParse(Console.ReadLine(),out tu))
            {
            }
            phanSo.TuSo = tu;
            Console.WriteLine("Nhap mau so : ");
            while (!float.TryParse(Console.ReadLine(), out mau) || mau==0)
            {
            }
            phanSo.MauSo = mau;
        }

        public void HienThi(PhanSo phanSo)
        {
            Console.WriteLine(" Phan so : {0} / {1}", phanSo.TuSo, phanSo.MauSo);
        }

        public void ToiGian(ref PhanSo phanSo)
        {
            if (phanSo.TuSo * phanSo.MauSo == 0) return;
            float tu = phanSo.TuSo;
            float mau = phanSo.MauSo;
            while (tu != mau) 
            {
                if (tu > mau)
                {
                    tu -= mau;
                }
                else mau -= tu;
            }

            phanSo.TuSo /= tu;
            phanSo.MauSo /= tu;
        }

        public PhanSo Tong(PhanSo ps1,PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.TuSo = ps1.TuSo * ps2.MauSo + ps1.MauSo * ps2.TuSo;
            ps3.MauSo = ps1.MauSo * ps2.MauSo;
            ToiGian(ref ps3);
            return ps3;
        }
        public PhanSo Tich(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.TuSo = ps1.TuSo * ps2.TuSo;
            ps3.MauSo = ps1.MauSo * ps2.MauSo;
            ToiGian(ref ps3);
            return ps3;
        }

    }
}
