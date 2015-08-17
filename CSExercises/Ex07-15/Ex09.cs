using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Value X:");

            int x = int.Parse(Console.ReadLine());

            double y = (2 * Math.Pow(x, 2)) - (4 * (x)) + 3;

            Console.WriteLine("Output:{0}", y);

            Console.ReadLine();
        }
    }
}
