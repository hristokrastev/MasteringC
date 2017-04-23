using System;
using System.Collections.Generic;
using System.Linq;
namespace AvarageStudentsGrades
{
    public class AvarageStudentsGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var avgStudGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var student = line[0];
                var grade = double.Parse(line[1]);
                
                if (!avgStudGrades.ContainsKey(student))
                {
                    avgStudGrades[student] = new List<double>();
                }
                avgStudGrades[student].Add(grade);
            }

            foreach (var kvp in avgStudGrades)
            {
                var students = kvp.Key;
                var grades = kvp.Value;
                var avg = grades.Average();
                Console.WriteLine($"{students} -> {string.Join(" ", grades.Select(p => string.Format("{0:f2}", p)))} (avg: {avg:f2})");
            }
        }
    }
}
