using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tFinding Vowels");

            Console.WriteLine("Please Enter a Pharse:");
            string p = Console.ReadLine();

            int tc = 0, ca = 0, ce = 0, ci = 0, co = 0, cu = 0;

           foreach(char c in p)
           {
               switch(c)
               {

                   case 'a':
                   case 'A':
                       tc++;
                       ca++;
                       break;

                   case 'e':
                   case 'E':
                       tc++;
                       ce++;
                       break;

                   case 'i':
                   case 'I':
                       tc++;
                       ci++;
                       break;

                   case 'o':
                   case 'O':
                       tc++;
                       co++;
                       break;

                   case 'u':
                   case 'U':
                       tc++;
                       cu++;
                       break;

                   default:
                       break;

               }

           }

           Console.WriteLine("Number of a:{0}", ca);
           Console.WriteLine("Number of e:{0}", ce);
           Console.WriteLine("Number of i:{0}", ci);
           Console.WriteLine("Number of o:{0}", co);
           Console.WriteLine("Number of u:{0}", cu);

           Console.WriteLine("Total Number of Vowels:{0}", tc);

           Console.ReadLine();
           
        }
    }
}
