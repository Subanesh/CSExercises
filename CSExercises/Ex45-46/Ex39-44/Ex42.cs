using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String 1");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter String 2");
            string s2 = Console.ReadLine();

            int fw = FindWord(s1, s2);

            if(fw==-1)
            {
                Console.WriteLine("String 2 not occurs in string 1");
            }
            else
            {
                Console.WriteLine("String 2 starting position in string 1 is:{0}",fw);

            }

            Console.ReadLine();
        }
        public static int FindWord(string s1, string s2)
        {
            int f = -1;
            if (s1.Contains(s2))
            {
                f = s1.IndexOf(s2);
            }
            else
            {
                f = -1;
            }

            return f;
        }
    }
}
