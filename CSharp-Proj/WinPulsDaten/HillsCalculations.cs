using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPulsDaten.data;

namespace WinPulsDaten
{
    public static class HillsCalculations
    {

        /// <summary>
        /// Takes in conditions and returns a function to calculate their HFmax
        /// </summary>
        /// <param name="male"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Func<int,int> GetCalculationFunction(bool male, Trainingcondition condition)
        {
            // Overweight
            if (condition.IsOverweight)
                return age => 200 - age / 2;

            if (male)
            {
                // Trained Male
                if (condition.IsTrained)
                    return age => 205 - age/2;

                // Untrained Male
                return age => 214 - (int)(.8 * age);
            }

            // Trained Female
            if (condition.IsTrained)
                return age => 211 - age/2;

            // Untrained Female
            return age => 209 - (int)(.7 * age);
        }

    }
}
