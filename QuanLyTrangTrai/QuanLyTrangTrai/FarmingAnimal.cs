using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    public class FarmingAnimal
    {
        private List<Animal> animalList;

        public List<Animal> AnimalList
        {
            get { return animalList; }
            set { animalList = value; }
        }

        public FarmingAnimal()
        {
            animalList = new List<Animal>();
        }


        public void Add(Animal animal)
        {
            animalList.Add(animal);
        }

        public void Remove(Animal animal)
        {
            animalList.Remove(animal);
        }

        public int Soluong()
        {
            return animalList.Count;
        }

        public double LuongThucAn()
        {
            if (animalList.Count == 0) return 0;
            return animalList.Count * animalList[0].SoLuongTieuThu;
        }

        public double TienNuoi()
        {
            if (animalList.Count == 0) return 0;
            double s=animalList[0].SoLuongTieuThu * animalList[0].ThucAn.Price * animalList.Count;
            return  s;
        }

    }
}
