using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            if (type.Equals("int"))
            {
                int inputOne = int.Parse(Console.ReadLine());
                int inputTwo = int.Parse(Console.ReadLine());
                int max = GetMax(inputOne, inputTwo);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char inputOne = char.Parse(Console.ReadLine());
                char inputTwo = char.Parse(Console.ReadLine());
                char max = GetMax(inputOne, inputTwo);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();
                string max = GetMax(inputOne, inputTwo);
                Console.WriteLine(max);
            }                  
        }

        static string GetMax(string inputOne, string inputTwo)
        {

            if (inputOne.CompareTo(inputTwo) >= 0)
            {
                return inputOne;
            }
            else
                return inputTwo;

        }
        static char GetMax(char inputOne, char inputTwo)
        {
            if (inputOne >= inputTwo)
            {
                return inputTwo;
            }
            else
                return inputTwo;
        }
        static int GetMax(int inputOne, int inputTwo)
        {
            if (inputOne >= inputTwo)
            {
                return inputOne;
            }
            else
                return inputTwo;
        }
        
    }
}
