using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validate
{
    internal class ValidateUserInput
    {
        public static bool ValidateUserInputs(string letter)
        {
            Regex regex = new Regex(@"^[a-zA-Z]=$");
            return regex.IsMatch(letter);
        }

    }
}
