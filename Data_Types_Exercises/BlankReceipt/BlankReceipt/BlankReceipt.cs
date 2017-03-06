using System;

namespace BlankReceipt
{
    class BlankReceipt
    {
        static void Main()
        {
            receipHeader();
            receipBody();
            receipFooter();
        

        }
        static void receipHeader() {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void receipBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void receipFooter()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }
    }
}
