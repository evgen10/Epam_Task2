using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StringSeparator
    {
        public char GetFirstSymbol(string sourceString)
        {

            if (sourceString == string.Empty)
            {
                throw new Exception("User entered an empty string!");
            }

            return sourceString[0];

        }



    }
}
