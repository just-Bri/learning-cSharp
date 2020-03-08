using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 & grade <= 100)
            {
                grades.Add(grade);
            }
        }
        public void ShowStats()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var result = 0.0;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            Console.WriteLine($"High: {highGrade:N2}");
            Console.WriteLine($"Low: {lowGrade:N2}");
            Console.WriteLine($"Avg: {result /= grades.Count:N2}");
        }
    }
}