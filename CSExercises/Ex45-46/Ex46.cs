
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int x = 0;
            int[] counter = new int[10];


            for (int i = 1; i <= 50; i++)
            {
                x = r.Next(0, 10);
                counter[x]++;
            }

            for (int k = 0; k < counter.Length; k++)
            {
                Console.WriteLine("The number {0} is occured {1} times", k, counter[k]);
            }

            Console.ReadLine();
        }
    }
}
