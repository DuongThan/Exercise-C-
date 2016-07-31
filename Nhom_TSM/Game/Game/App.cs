using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Game
{
    class App
    {
        private Bird bird_;
        private Moi moi_;
        private DiemSo diem_;

        internal Bird Bird_
        {
            get
            {
                return bird_;
            }

            set
            {
                bird_ = value;
            }
        }

        internal Moi Moi_
        {
            get
            {
                return moi_;
            }

            set
            {
                moi_ = value;
            }
        }

        public App()
        {
            bird_ = new Bird(new Diem(20, 17));
            diem_ = new DiemSo();
            moi_ = new Moi();
        }

        public void ShowApp()
        {
            bird_.Show();
            diem_.ShowDiem(30,3);
            moi_.Show();
        }

        public bool XuLyCham()
        {
            if (moi_.X >= bird_.Dau_Bird.X && moi_.X <= bird_.Dau_Bird.X + bird_.Dai
                && moi_.Y >= bird_.Dau_Bird.Y && moi_.Y <= bird_.Dau_Bird.Y + bird_.Rong ) 
            return true;

            return false;
        }

    }
}
