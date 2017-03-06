using System;

namespace PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double border = double.Parse(Console.ReadLine()) * 100;
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double current = double.Parse(Console.ReadLine());
                double differance = Persentage(last, current);
                bool isSignificantDifference = isDifferent(differance, border);

                string message = GetInputAndReturnMassage(current, last, differance, isSignificantDifference);
                Console.WriteLine(message);
                last = current;
            }
        }
        private static string GetInputAndReturnMassage(double current, double last, double difference, bool etherTrueOrFalse)
        {
            string massage = "";
            if (difference == 0)
            {
                massage = string.Format("NO CHANGE: {0}", current);
            }
            else if (!etherTrueOrFalse)
            {
                massage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, current, difference);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                massage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, current, difference);
            }
            else if (etherTrueOrFalse && (difference < 0))
                massage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, current, difference);
            return massage;
        }
        private static bool isDifferent(double border, double isDifferent)
        {
            if (Math.Abs(border) >= isDifferent)
            {
                return true;
            }else
            return false;
        }

        private static double Persentage(double last, double current)
        {
            double result = ((current - last) / last) * 100;
            return result;
        }
    }
}
