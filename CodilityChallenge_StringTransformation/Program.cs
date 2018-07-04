using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityChallenge_StringTransformation
{
    class Program
    {        
        static void Main(string[] args)
        {
            //string S = "ACCAABBC"; // Returns "AC"
            //string S = "ABCBBCBA"; // Returns empty string
            string S = "BABABA";     // Returns "BABABA"

            StringTransformer st = new StringTransformer();
            string result = st.Solution(S);

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
