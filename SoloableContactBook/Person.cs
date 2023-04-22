using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloableContactBook
{
    public class Person
    {
        public string name = "New Person";
        public string email;
        public string adress;
        public DateTime birthday;
        public string notes;
        public string Name { get; }

        public Person()
        {
            Name = name;
            birthday = DateTime.Now;
        }
    }
}
