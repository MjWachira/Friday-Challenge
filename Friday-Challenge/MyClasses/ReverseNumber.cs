using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class ReverseNumber
    {
        //QUESTION ONE
        //Given an integer, return an integer that is reverse ordering the numbers 
        // 500 = 5 

        //int number = 12;
        public int ReverseNumbers(int number)
        {
           // Console.WriteLine("Reversing a number");
            //int number = int.Parse(Console.ReadLine());
            int reversedNumber = 0;

            while (number != 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number = number / 10;
            }
            return reversedNumber;
           // Console.WriteLine($"Reversed number is {reversedNumber}");

        }

    }
}
