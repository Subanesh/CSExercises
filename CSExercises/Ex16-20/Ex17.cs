using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());


            if (gender == "M")
            {
                if( age>=40)
                {
                    Console.WriteLine("Good Morning Uncle {0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Mr. {0}", name);
                }
            }
            else if (gender == "F")
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning lady {0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Ms. {0}", name);
                }
            }

            else
            {
                Console.WriteLine("Enter Gender Like M or F");
            }

            Console.ReadLine();
        }
    }
}