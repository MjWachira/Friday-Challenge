// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");
//QUESTION ONE
//Given an integer, return an integer that is reverse ordering the numbers 
// 500 = 5 

//int number = 12;
Console.WriteLine("Reversing a number");
int number = int.Parse(Console.ReadLine());
int dNumber = 0;
int rNumber = 0 ;

dNumber = number % 10;
rNumber = (number * 10) + dNumber;
number = number / 10;

for (int i = 0; i < number; i++)

Console.WriteLine($"Reversed number is{rNumber}");

//Write a method that accepts a string, and the program should capitalize the first letter of each word in the string then return the results string. 
//e.g. hello there should be Hello There 
// hi should be Hi 

Console.WriteLine("Enter A string to convert to Capitalize first word");
string str = Console.ReadLine();
var word =   str.Split(' ');
var cStr = "";
{
    cStr += char.ToUpper(word[0]) + word.Substring(1) + ' ';
}
Console.WriteLine(cStr);


//Given an array and chunk size divide the array into subarrays where each subarray is of length is the chunk size. E.g. 
//[1,2,3,3,4,5,6,7],3)  ===[ [ 1, 2, 3 ], [ 3, 4, 5 ], [ 6, 7 ] ] 
//([1,2,3,5,6,7],1) ===[ [ 1 ], [ 2 ], [ 3 ], [ 5 ], [ 6 ], [ 7 ] ] 

int[] source = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int a = 0;
int chunkSize = 3;
int[][] result = source.GroupBy(s => a++ / chunkSize).Select(g => g.ToArray()).ToArray();



Console.WriteLine(result[1].Length);


//Write a C# program that prompts the user to
//enter a string and counts the number of vowels
//in the entered string. Vowels are the letters
//'a', 'e', 'i', 'o', and 'u' (both uppercase and lowercase). 

Console.WriteLine("enter a string");
string inputstring = Console.ReadLine();
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


//write a program that can remove empty spaces in arrays e.g.[1, 2, , , 4] = [1, 2, 4]

int[] spacedArray = new int[5];
spacedArray[0] = 1;
spacedArray[2] = 2;
spacedArray[4] = 3;
for (int i = 0; i < spacedArray.Length; i++)
{
    
    Console.WriteLine($"{i} = {spacedArray[i]}");
    
}

int[] newArr = new int[spacedArray.Length];
int newSize = 0;

for (int i = 0; i < spacedArray.Length; i++)
    if (spacedArray[i] != 0)
    {
        newArr[newSize] = spacedArray[i];
        newSize++;
    }

if (newSize > 0)
    Array.Resize(ref newArr, newSize);
    Console.WriteLine(newArr.Length);

for (int i = 0; i < newArr.Length; i++)
{

    Console.WriteLine($"{i} = {newArr[i]}");

}
