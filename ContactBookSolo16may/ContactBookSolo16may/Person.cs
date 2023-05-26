using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookSolo16may
{
    public class Person
    {
        public Person()
        {
            name = "New Person";
            birthday = DateTime.Now;
        }
        public string name;
        public string Name 
        {
            get { return name; } 
        }
        public string eMail;
        public string adress;
        public DateTime birthday;
        public string notes;
    }
}
