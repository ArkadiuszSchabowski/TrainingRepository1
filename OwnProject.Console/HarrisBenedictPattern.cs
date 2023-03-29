using OwnProjectConsole;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OwnProjectConsole
{
    internal class HarrisBenedictPattern
    {

        public static double bmr, tef, trainingGoal, tea;
        public static int neat = 0;

        public static double cpm = 0;
        public static void CaloricRequirementCalculation()
        {
            var user = new User();
            if (user.GenderValue == 665.09)
            {
                bmr = 665.09 + (9.56 * user.Weight) + (1.85 * user.Height);
                bmr = bmr - (4.67 * user.Age);
            }
            else
            {
                bmr = 66.47 + (13.75 * user.Weight) + (5 * user.Height);
                bmr = bmr - (6.75 * user.Age);
            }
            tef = bmr * 0.1;
            neat = user.PhysicalActivity;
            tea = user.CaloriesBurnedAtWork;
            trainingGoal = user.Goal;
            cpm = Math.Round(bmr + (bmr * tea) + tef + neat) * trainingGoal;

            Console.WriteLine($"Twoje łączne zapotrzebowanie kaloryczne wynosi: {cpm} kcal.");
        }
    }
}