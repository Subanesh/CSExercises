using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double 
                  calculation;
            Console.WriteLine("Travel Distance:");
            double distance = double.Parse(Console.ReadLine());

           double distance1 = Math.Ceiling(distance * 10) / 10;

           if (distance1 < 9)
           {
               calculation = 2.40 + (distance1 * 10) * 0.04;
           }
           else
           {
               calculation = 2.40 + (85 * 0.04) + ((distance1 - 9) * 10) * 0.05;
           }

           Console.WriteLine("Charge:{0:c}", calculation);

           Console.ReadLine();


        }
    }
}