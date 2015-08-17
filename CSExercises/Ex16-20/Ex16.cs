using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Gender:");
            string gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr.{0}",name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms.{0}", name);
            }

            else
            {
                Console.WriteLine("Enter Gender Like M or F");
            }

            Console.ReadLine();
        }
    }
}