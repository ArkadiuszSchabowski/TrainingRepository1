using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilionersOnWindowsForm_TestOwnSkills
{
    public class QuestionsFor100
    {
        static public Random rnd = new Random();
        public static void DisplaySelectedQuestion(string[] list, int question)
        {
            if (question == 0)
            {
                list[0] = "Jakiego koloru jest świnka Kropka?";
            }
            if (question == 1)
            {
                list[1] = "Co jedzą świnki, by ścierać zęby?";
            }
            if (question == 2)
            {
                list[2] = "Jakie jest prawidłowe poidełko dla jednej świnki morskiej?";
            }
        }
    }
}
