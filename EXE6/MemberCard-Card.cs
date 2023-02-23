using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE6
{
    public class MemberCard : Card
    {
        private string organisation = "Świnki Morskie na Szczytach";
        public string Organisation { get; set; }
        public MemberCard()
        {
            this.Organisation = organisation;
        }
    }
}