
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter B:");
            int b = int.Parse(Console.ReadLine());
            int HCF = 0, a1 = a, b1 = b;

           
            if (a > b)
            {
                while (a != b)
                {
                    int t = a - b;
                    a = t;
                }

                HCF = a;
                Console.WriteLine("HCF:{0}", HCF);



            }

            else
            {

                while (a != b)
                {
                    int t = b - a;
                    b = t;
                }

                HCF = b;
                Console.WriteLine("HCF:{0}", HCF);
            }


            int LCM = (a1 * b1) / (HCF);
            Console.WriteLine("LCM:{0}", LCM);

          Console.ReadLine();


        }
    }
}
