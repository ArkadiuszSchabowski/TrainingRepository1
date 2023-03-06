using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realera_started_today___3_days_little_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MasterSorcerer MasterSorcerer = new MasterSorcerer();
            MasterSorcerer.Spells();
            MasterSorcerer.SpellsMS();
            ElderDruid ElderDruid = new ElderDruid();
            ElderDruid.Spells();
            ElderDruid.SpellsED();
            Console.ReadKey();
            
        }
    }
}