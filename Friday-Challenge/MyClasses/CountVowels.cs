using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class CountVowels
    {
        public void CountVowel(string inputstring) 
        {
            //Write a C# program that prompts the user to
            //enter a string and counts the number of vowels
            //in the entered string. Vowels are the letters
            //'a', 'e', 'i', 'o', and 'u' (both uppercase and lowercase). 


            int i, len, vowels, consonants;


            vowels = 0;
            consonants = 0;
            len = inputstring.Length;

            // Iterating the string from left to right
            for (i = 0; i < len; i++)
            {

                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {

                    // Increment the vowels
                    vowels++;
                }

                // Check if the character is a alphabet
                // other than vowels
                else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                         (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                {

                    // Increment the consonants
                    consonants++;
                }
               
            }

            
            // Display the count of vowels and consonant
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);

            


        }
    }
}
