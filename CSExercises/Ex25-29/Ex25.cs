using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            //25a

            Console.WriteLine("Enter Number:");
            int no = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <=no; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of NUmber {0} is :{1}", no, fact);

            Console.ReadLine();

            //25b

            //Console.WriteLine("Enter Number:");
            //int no = int.Parse(Console.ReadLine());
            //int s = 1;
            //for (int i = no; i >= 1; i--)
            //{
            //    s *= i;
            //}

            //Console.WriteLine("Factorial of NUmber {0} is :{1}", no, s);

            //Console.ReadLine();
        }
    }
}
