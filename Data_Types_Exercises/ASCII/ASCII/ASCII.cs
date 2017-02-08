using System;

namespace ASCII
{
    class ASCII
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char newInp =' ';
            string lastOutput = "";
            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                newInp = (char)(input);
                lastOutput += newInp.ToString();
                
            }
            Console.WriteLine(lastOutput);

        }
    }
}
