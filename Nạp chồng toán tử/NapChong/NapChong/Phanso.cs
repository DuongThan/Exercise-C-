using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapChong
{
    class Phanso
    {
        private float tuSo;

        public float TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        private float mauSo;

        public float MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }
        public Phanso()
        {
            tuSo = 1;
            mauSo = 1;
        }
        public Phanso(float tu, float mau)
        {
            this.tuSo = tu;
            this.mauSo = mau;
        }

        public void Show()
        {
            Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }

        public static Phanso operator + (Phanso p1, Phanso p2)
        {
            Phanso p3 = new Phanso();
            p3.tuSo = p1.tuSo * p2.mauSo + p1.mauSo * p2.tuSo;
            p3.mauSo = p1.mauSo * p2.mauSo;
            return p3;
        }
    }
}
