using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityChallenge_StringTransformation
{
    class StringTransformer
    {
        public string Solution(string S)
        {
            if (S.Length > 50000)
                return "";

            return GetReplace(S);
        }

        public string GetReplace(string input)
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
    }
}
