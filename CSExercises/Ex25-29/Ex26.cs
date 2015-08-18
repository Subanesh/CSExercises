using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("-------------------------------------------------------------");
            for (double i = 1; i <= 10; i++)
            {
                double r = 1/i;
                
                Console.WriteLine("{0}\t{1:0.000}\t{2:0.000}\t\t{3}", i, r, Math.Sqrt(i), i * i);
            }

            Console.ReadLine();
        }
    }
}
