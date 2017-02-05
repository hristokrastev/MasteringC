using System;

namespace TransportCoursesNeeded
{
    class Transport
    {
        static void Main()
        {

            int totalPeople = int.Parse(Console.ReadLine());

            int totalSpace = 24;

            int coursesNeeded = (int)Math.Ceiling(((double)totalPeople / totalSpace));

            Console.WriteLine(coursesNeeded);
        }
    }
}
