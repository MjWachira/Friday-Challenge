using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class Palidrome
    {
        public  void Palid(string inputString) 
        {


            // Remove non-alphanumeric characters and convert to lowercase
            string cleanedString = new string(inputString.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            int length = cleanedString.Length;
            bool isPalindrome = true;

            for (int i = 0; i < length / 2; i++)
            {
                if (cleanedString[i] != cleanedString[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
               
                Console.WriteLine("The entered string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The entered string is not a palindrome.");
            }

        }
    }
}
