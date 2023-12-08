using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class CapitalizeWordsMethod
    {
        public static string CapitalizeWords(string input)
        {
            var words = input.Split(' ');
            var capitalizedString = "";

            foreach (var word in words)
            {
                // Check if the word is not empty
                if (!string.IsNullOrEmpty(word))
                {
                    // Capitalize the first letter of each word and append to the result string
                    capitalizedString += char.ToUpper(word[0]) + word.Substring(1) + ' ';
                }
            }

            return capitalizedString.Trim();
        }
    }
}
