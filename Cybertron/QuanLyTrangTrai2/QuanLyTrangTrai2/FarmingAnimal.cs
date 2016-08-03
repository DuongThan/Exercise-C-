using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    public class FarmingAnimal
    {
        private List<Animal> List_animal;

        public List<Animal> List_animal1
        {
            get { return List_animal; }
            set { List_animal = value; }
        }
        public FarmingAnimal()
        {
            List_animal = new List<Animal>();
        }

        public void Add(Animal animal)
        {
            List_animal.Add(animal);
        }

        public void Remove(Animal animal)
        {
            List_animal.Remove(animal);
        }

        public int SoLuong()
        {
            return List_animal.Count;
        }
        public int LuongThucAn()
        {
            if (SoLuong() == 0) return 0;
            return SoLuong() * List_animal[0].LuongTieuThu;
        }

        public double TienNuoi()
        {
            if (SoLuong() == 0) return 0;
            return LuongThucAn() * List_animal[0].ThucAn.Price;

        }
    }
}
