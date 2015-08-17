using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks between 0 and 100");
            int m = int.Parse(Console.ReadLine());
            if (m >= 80 && m <= 80)
            {
                Console.WriteLine("You Scored {0} marks Which is A grade",m);

            }

            else if(m>=60 && m<=79)
            {
                Console.WriteLine("You Scored {0} marks Which is B grade",m);
            }

            else if (m >= 40 && m <= 59)
            {
                Console.WriteLine("You Scored {0} marks Which is C grade",m);
            }
            else if (m>= 0 && m <= 39)
            {
                Console.WriteLine("You Scored {0} marks Which is F grade", m);
            }
            else
            {
                Console.WriteLine("Please Enter Marks between 0 and 100 ",m);
            }

            Console.ReadLine();
        }
    }
}