using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class CapitalizeWordsProgram
    {
        public void CapitalizeWordsProg() 
        {
            //Write a method that accepts a string, and the program should capitalize the first letter of each word in the string then return the results string. 
            //e.g. hello there should be Hello There 
            // hi should be Hi 

            Console.WriteLine("Enter a string to capitalize the first letter of each word:");
            string inputString = Console.ReadLine();
            var words = inputString.Split(' ');
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

            Console.WriteLine(capitalizedString.Trim());

        }
    }
}
