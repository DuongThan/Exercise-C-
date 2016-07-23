using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    abstract class People
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool sex;

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public abstract void Info();
    }
}
