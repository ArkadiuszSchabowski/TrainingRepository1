using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookMay
{
    public class Person
    {
        public string Name 
        { 
            get { return name; } 
        }
        public string name;
        public string notes;
        public Person()
        {
            name = "New Person";
        }
    }
}
