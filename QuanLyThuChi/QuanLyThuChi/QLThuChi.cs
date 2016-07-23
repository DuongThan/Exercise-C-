using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi
{
    class QLThuChi
    {
        private float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private List<string> mucChiTieu;
        private List<ThongTinChiTien> danhSachChi;

        private List<ThongTinChiTien> DanhSachChi
        {
            get { return danhSachChi; }
            set { danhSachChi = value; }
        }

        public List<string> MucChiTieu
        {
            get { return mucChiTieu; }
            set { mucChiTieu = value; }
        }

        class ThongTinChiTien
        {
            public string mucChiTieu;
            public float soTienDaChi;
            public string lyDo;

            public ThongTinChiTien(string mucChi, float tien, string lydo)
            {
                mucChiTieu = mucChi;
                soTienDaChi = tien;
                this.lyDo = lydo;
            }
        }

        public QLThuChi(float tien)
        {
            tongTien = tien;
            danhSachChi = new List<ThongTinChiTien>();
            mucChiTieu = new List<string>() {"Quy Den","Di Cho","Mua Sam","Bar" };

        }

        public void CapNhatTongtien( float tien)
        {
            TongTien += tien;
        }

        public void XemTaiKhoan()
        {
            Console.WriteLine(" So tien con lai cua quy khach la : " + TongTien+ " VND");
        }

        public void XemCacKhoanDaChi(string mucChitieu = null)
        {
            Console.WriteLine("Chi :{0} ", mucChitieu ?? "");
            foreach(ThongTinChiTien item in DanhSachChi)
            {
                if(item!=null && (mucChiTieu==null ||  (mucChiTieu!=null && item.mucChiTieu.Equals(mucChitieu))  ) )
                {
                    Console.WriteLine("  {0} |  {1}   |  {2} ", item.mucChiTieu, item.soTienDaChi, item.lyDo);
                }
            }
        }

        public void ChiTien(string mucChi, float soTienCanChi, string lydo = null)
        {
            if(TongTien < soTienCanChi)
            {
                Console.WriteLine(" Khong the chi qua so tien con lai");
                return;
            }
            DanhSachChi.Add(new ThongTinChiTien(mucChi, soTienCanChi, lydo));
            tongTien -= soTienCanChi;
            Console.WriteLine(" Da chi cho viec {} so tien {} ly do {}", mucChi, soTienCanChi, lydo);
            XemTaiKhoan();
        }

        public void CapNhatSoTienTrongTaiKhoan()
        {
            Console.Write(" Nhap so tien can them : ");
            string tien = Console.ReadLine();
            float money;
            if(float.TryParse(tien,out money))
            {
                tongTien += money;
            }
            else
            {
                Console.WriteLine(" So tien nhap sai");
            }
        }

        public void _XemCacKhoanDaChi()
        {
            XemCacKhoanDaChi();
        }

        public void XemCacKhoanDaChiTheoMuc()
        {
            ShowChi();
        }

        public void ShowChi()
        {
            int i=0;
            foreach(string mucCt in MucChiTieu)
            {
                i++;
                Console.WriteLine(i + " ." + mucCt);
            }
        }

        public void ChiTienUser()
        {

        }

        public void ShowMenu()
        {
            string menu = " Phan mem quan li thu chi"
                + Environment.NewLine
                + " 1. Xem tong tien "
                + Environment.NewLine
                + " 2. Cap nhat so tien trong tai khoan"
                + Environment.NewLine
                + " 3. Xem khoan da chi "
                + Environment.NewLine
                + " 4. Xem khoan da chi theo muc "
                + Environment.NewLine
                + " 5. Chi tien.";
            Console.WriteLine(menu);
        }

        public void UserCommand()
        {

            string command = Console.ReadLine();
            switch(command)
            {
                case "1":
                    XemTaiKhoan();
                    break;

                case "2":
                    CapNhatSoTienTrongTaiKhoan();
                    break;

                case "3":
                    _XemCacKhoanDaChi();
                    break;

                case "4":
                    XemCacKhoanDaChiTheoMuc();
                    break;

                case "5":
                    ChiTienUser();
                    break;

                    
                default:
                    Console.WriteLine(" Vui long nhap dung du lieu");
                    break;
            }
        }




    }
}
