
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hexa Decimal Number between 1 and 100");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Hexa Decimal Number of:{0} is {1}", i, Hex(i));
            }

            Console.ReadLine();
        }

        public static string Hex(int i)
        {
            string hexvalue = i.ToString("X");
            return hexvalue;
        }
    }
}
