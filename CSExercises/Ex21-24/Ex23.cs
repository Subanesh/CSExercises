using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            //23 a

            //Random r = new Random();

            //int sno = r.Next(0, 10);
            //int guess = 0;
            //int x = 0;
            //do
            //{
            //    Console.WriteLine("Enter Number Between 0 to 9");
            //    guess = int.Parse(Console.ReadLine());

            //    if (guess == sno)
            //    {
            //        x++;
            //        Console.WriteLine("Congratulation...Guess No:{0}", guess);
            //        Console.WriteLine("Attempts:{0}", x);
            //    }
            //    else
            //    {
            //        x++;
            //        Console.WriteLine("Please Try Again");
            //    }

            //} while (sno != guess);

            //Console.ReadLine();


            //23b

            Random r = new Random();

            int sno = r.Next(0, 10);
            int guess = 0;
            int x = 0;
            do
            {
                Console.WriteLine("Enter Number Between 0 to 9");
                guess = int.Parse(Console.ReadLine());

                if (guess == sno)
                {
                    x++;
                    Console.WriteLine("Congratulation...Guess No:{0}", guess);

                }
                else
                {
                    x++;
                    Console.WriteLine("Please Try Again");
                }

            } while (sno != guess);

            if (x <= 2)
            {
                Console.WriteLine("You are a Wizard");
            }

            else if (x >= 2 && x <= 5)
            {
                Console.WriteLine("You are a good guess");
            }

            else
            {
                Console.WriteLine("You are a Lousy");
            }
            Console.ReadLine();
        }
    }
}
