using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Distance:");

            double d = double.Parse(Console.ReadLine());

            double f = 2.40 + (d * 0.4);

            Console.WriteLine("Total Fare:{0}", f);

            Console.ReadLine();
        }
    }
}
