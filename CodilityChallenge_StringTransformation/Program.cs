using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityChallenge_StringTransformation
{
    class Program
    {
        public static string solution(string S)
        {
            return GetReplace(S);
        }

        public static string GetReplace(string input)
        {
            /*string retval = input.Replace("AB", "AA")
                                 .Replace("BA", "AA")
                                 .Replace("CB", "CC")
                                 .Replace("BC", "CC")
                                 .Replace("AA", "A")
                                 .Replace("CC", "C");*/

            string retval = input.Replace("AA", "")
                                 .Replace("BB", "")
                                 .Replace("CC", "");

            if (input == retval)
                return retval;
            else
                return GetReplace(retval);
        }
        static void Main(string[] args)
        {
            string S = "ACCAABBC";
            string result = solution(S);

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
