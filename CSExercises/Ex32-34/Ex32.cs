using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises 
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
           // int[] month = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int[] sales=new int[12];

           

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter Sales for month {0}:",i);
                sales[i] = int.Parse(Console.ReadLine());      
            }
            Console.WriteLine("Maxmum Sales:{0}", sales.Max());
            Console.WriteLine("Minimum Sales:{0}",sales.Min());
            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] < sales[i + 1])
                {

                }
            }


            Console.WriteLine("Average Sales:{0}", sales.Average());
            Console.ReadLine();
        }
    }
}
