
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int sno = 88;
            int g = -1;
            do
            {
                Console.WriteLine("Enter an integer Number:");
                int cno = int.Parse(Console.ReadLine());

                if (cno == sno)
                {
                    Console.WriteLine("\"Lucky You...,\"");
                    break;
                }


            }
            while (g != sno);
            Console.ReadLine();
        }
    }
}
