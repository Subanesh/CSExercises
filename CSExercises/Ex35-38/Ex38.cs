using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] { "John", "Vengat", "Mary", "Victor", "Betty" };

            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            Console.WriteLine("Name\t Marks");
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (mark[i] < mark[j])
                    {
                        int temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                    }
                }


            }
            string[] name1 = new string[] { "John", "Vengat", "Mary", "Victor", "Betty" };

            int[] mark1 = new int[] { 63, 29, 75, 82, 55 };
            for (int i = 0; i < mark1.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", name1[i], mark1[i]);
            }
            Console.WriteLine("-------------------------------");
            Array.Sort(name1);

            for (int i = 0; i < mark1.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", name1[i], mark1[i]);
            }

            Console.ReadLine();

        }
    }
}
