using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Distance:");

            double d = double.Parse(Console.ReadLine());

            double f = 2.40 + (d * 0.4);
            double ff = Math.Round(f / 10) * 10;

            Console.WriteLine("Total Fare:{0:0.00}", f);

            Console.ReadLine();
        }
    }
}
