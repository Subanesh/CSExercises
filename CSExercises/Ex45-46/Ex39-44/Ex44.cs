
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter Char 1");
            char c1 = char.Parse( Console.ReadLine());

            Console.WriteLine("Enter Char 2");
            char c2 = char.Parse(Console.ReadLine());

            Console.WriteLine("The New Word:{0}", Substitute(s, c1, c2));

            Console.ReadLine();

        }
        public static string Substitute(string s, char c1, char c2)
        {
            return s.Replace(c1, c2);
        }
    }
}
