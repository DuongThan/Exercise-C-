using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    class BoSua:Animal
    {
        public BoSua()
        {
            Name = Constant.BOSUA_NAME;
            SoLuongTieuThu = Constant.BOSUA_LUONGTIEUTHU;
            ThucAn = new Co();
        }
    }
}
