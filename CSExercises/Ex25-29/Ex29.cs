using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a NUmber:");
            int num = Convert.ToInt32(Console.ReadLine());

            int nn = num;
            int sum = 0;

            for (int i = 1; i < num; i++) 
            {
                if(num % i== 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == nn)
            {
                Console.WriteLine("Perfect Number");
            }

            else
            {
                Console.WriteLine("Not Perfect Number");
            }

            Console.ReadLine();

        }
    }
}
