using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X \t   Y");

            Console.WriteLine("-------------------------------------------------------------");
            for (int x = -5; x <= 5; x++)
            {
                double i = x;

                double y = (2 * Math.Pow(i, 2)) - (4 * (i)) + 3;

                Console.WriteLine("{0:0.00}\t{1:0.00}", i, y);
            }

            for (int x = -5; x <= 5; x++)
            {
                double i = x;

                double y = (2 * Math.Pow(i, 2)) - (4 * (i)) + 3;

                for (int j = 0; j < y; j++)
                {
                   
                    Console.Write("*");
                    
                }
                Console.Write("{0} Times Total", y);
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
