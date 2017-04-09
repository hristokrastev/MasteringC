using System;
namespace Stateless
{
    class Stateless
    {
        public static void Main()
        {
            var states = Console.ReadLine();
            var fiction = Console.ReadLine();
            while (states != "collapse")
            {
                while (states.Length != 0 && fiction.Length != 0)
                {
                    try
                    {
                        states = states.Remove(states.IndexOf(fiction), fiction.Length);
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        try
                        {
                            fiction = fiction.Remove(0, 1);
                            fiction = fiction.Remove(fiction.Length - 1, 1);
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            break;
                        }
                    }
                }
                if (states.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(states.Trim());
                }
                states = Console.ReadLine();
                fiction = Console.ReadLine();
            }
        }
    }
}
