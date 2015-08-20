using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        { 
        
            Console.WriteLine("Please enter number:");
            double x = double.Parse(Console.ReadLine());

            double fact = factor(x);

            Console.WriteLine("Factorial for Number {0} is:{1}", x,fact);
            Console.ReadLine();
          
        }

        public static double factor(double x)
        {
            if (x == 1)
            {
                return 1;

            }

            else
            {
                return x * factor(x - 1);
            }
            
        }

        }
    }

