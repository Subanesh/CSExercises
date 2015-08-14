using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Temperature in Centigrade:");
            double c = double.Parse(Console.ReadLine());

            double f = (1.8 * c) + 32;

            Console.WriteLine("Fahrenheit:{0}", f);

        }
    }
}
