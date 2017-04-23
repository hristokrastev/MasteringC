using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONparse
{
    class Student
    {
        string Name { get; set; }
        int Age { get; set; }
        int grades { get; set; }
    }
    class JSONparse
    {
        static void Main()
        {
            List<Student> studensts = new List<Student>();

            var text = Console.ReadLine().Split('{', '}', '[', ']', ',');
        }
    }
}
