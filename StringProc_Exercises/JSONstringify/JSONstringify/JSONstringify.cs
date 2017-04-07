using System;
using System.Collections.Generic;
using System.Linq;

namespace JSONstringify
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }
    }
    class JSONstringify
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            string text = Console.ReadLine();

            while (!(text == "stringify"))
            {
                var inputParameters = text.Split(new char[] { ' ', ',', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                string studentName = inputParameters[0];
                int studentAge = int.Parse(inputParameters[1]);
                int[] studentGrades = inputParameters.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();

                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(newStudent);

                text = Console.ReadLine();
            }

            string output = String.Empty;
            output += "[";
            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                if (i == students.Count - 1)
                {
                    output += "{";
                    output += "name:\"" + currentStudent.Name + "\",age:" + currentStudent.Age + ",grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                    output += "}";
                }
                else
                {
                    output += "{";
                    output += "name:\"" + currentStudent.Name + "\",age:" + currentStudent.Age + ",grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                    output += "},";
                }
            }
            output += "]";
            Console.WriteLine(output);
        }
    }
}
