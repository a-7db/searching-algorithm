using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = { 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220, 230, 240};
            int userInput;
            
            do
            {
                Console.Write("Enter Number To Finde it Inide array (-1) To Exit: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == -1)
                {
                    break;
                }

                int FoundIndex = BinarySearch(arrNum, userInput);

                if (FoundIndex >= 0)
                {
                    Console.WriteLine("{0} is in index {1} ", userInput, FoundIndex);
                    
                }
                else
                {
                    Console.WriteLine("{0} is Not Found", userInput);
                }

            } while (userInput >= 0);

            
        }

        private static int BinarySearch(int[] arrNum, int userInput)
        {
            int Left = 0;
            int Right = arrNum.Length -1;
            

            while (Left <= Right)
            {
                int Middle = (Left + Right) / 2;

                if (arrNum[Middle] == userInput)
                {
                    return Middle;
                }
                else if (arrNum[Middle] < userInput)
                {
                    Left = Middle + 1;
                }
                else
                {
                    Right = Middle -1;
                }
                
            }
            return -1;
        }

        private static int LinearSearch(int[] arrNum, int userInput)
        {
            
            for (int i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] == userInput)
                {
                    return i;
                }
                
            }
            return -1;
        }
    }
}
