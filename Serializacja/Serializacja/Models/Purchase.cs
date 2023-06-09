using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacja.Models
{
    internal class Purchase
    {
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
