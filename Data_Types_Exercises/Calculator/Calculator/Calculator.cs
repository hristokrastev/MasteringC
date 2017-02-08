using System;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            int operand1 = int.Parse(Console.ReadLine());
            string operaTor = Console.ReadLine();
            int operand2 = int.Parse(Console.ReadLine());
            switch (operaTor)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    Console.WriteLine($"{operand1} / {operand2} = {(double)(operand1) / (double)(operand2)}");
                    break;
            }
           
        }
    }
}
