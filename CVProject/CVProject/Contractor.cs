using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject
{
    public class Contractor
    {
        public string CompanyName
        {
            get { return companyName; }
        }
        public string companyName;
        public string country;
        public string adress;
        public string eMail;

        public Contractor()
        {
            Initialize();
        }

        public void Initialize()
        {
            companyName = "New Company";
        }
    }
}
