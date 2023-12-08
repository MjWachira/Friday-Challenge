using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class MostAppearingCharacter
    {
        public void MostAppearing(string input) 
        {


            if (!string.IsNullOrEmpty(input))
            {
                char mostAppearingChar = input
                    .GroupBy(c => c)
                    .OrderByDescending(g => g.Count())
                    .First()
                    .Key;

                Console.WriteLine($"The most appearing character is: '{mostAppearingChar}'");
            }
            else
            {
                Console.WriteLine("Input string cannot be null or empty.");
            }

        }
    }
}
