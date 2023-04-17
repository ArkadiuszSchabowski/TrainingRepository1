using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class Person
    {
        public string name;
        public string email;
        public string adress;
        public DateTime birthay;
        public string notes;

        public string Name
        {
            get { return name; }
        }
        public Person()
        {
            Initialize();
        }
        public void Initialize()
        {
            name = "New Person";
            birthay = DateTime.Today;
        }
    }
}
