using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_PhanSo
{
    public class PhanSo
    {
        private float tuSo;
        private float mauSo;

        public float MauSo
        {
            get
            {
                return mauSo;
            }

            set
            {
                mauSo = value;
            }
        }

        public float TuSo
        {
            get
            {
                return tuSo;
            }

            set
            {
                tuSo = value;
            }
        }

        public PhanSo(float tu,float mau)
        {
            this.tuSo = tu;
            this.mauSo = mau;
        }
        public PhanSo()
        {

        }
    }
}
