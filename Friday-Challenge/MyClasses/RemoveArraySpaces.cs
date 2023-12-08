using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class RemoveArraySpaces
    {
        public void RemoveArraySpace()
        {

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


        }

    }
}
