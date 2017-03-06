using System;

namespace Notifications
{
    class Notifications
        
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                var textForCheck = Console.ReadLine();
                if (textForCheck == "success")
                {
                    var operation = Console.ReadLine();
                    var massage = Console.ReadLine();

                    Console.WriteLine(ShowSuccess(operation, massage));
                }
                else if (textForCheck == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code));
                }
                else
                    continue;
            }

        }
        static string ShowSuccess(string operation, string message)
        {

            return ($"Successfully executed { operation}.\n==============================\nMessage: { message}.");

        }
        static string ShowError(string operation, int code)
        {
            var reason = string.Empty;
            if (code >= 0)
            {
                reason = "Invalid Client Data";            
            }
            else
            {
                reason = "Internal System Failure";
            }
            
            return ($"Error: Failed to execute { operation}.\n==============================\nError Code: { code}.\nReason: { reason}.");

            
        }

    }
}
