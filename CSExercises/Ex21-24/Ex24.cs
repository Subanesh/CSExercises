using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Enter NUmber:");
            double N = double.Parse(Console.ReadLine());
           // double N = Math.Sqrt(i);

            double G = r.Next(1, Convert.ToInt32(N + 1));

            if (Math.Round(N,5)==G)
            {
                Console.WriteLine("Guess in First Time..Input{0} \tGuess Number:{1}", N, G * G);
            }
            else
            {
                int k = 0;
                do
                {
                    G = (G + (N / G)) / 2.0;
                    k++;

                } while (Math.Round(G * G, 5) != N);

                Console.WriteLine("GUESS Number:{0:0.00000} & Attempts:{1}",G,k);
                //while (N != G * G)
                //{
                //    G = (G + (N / G)) / 2.0;
                //    G = Math.Round(G, 5);

                //    if (G * G == N)
                //    {
                //        Console.WriteLine("Success");
                //    }
                    //else
                    //{
                    //    Console.WriteLine("Fail");
                    //}
                
            }

            Console.ReadLine();

        }
    }
}
