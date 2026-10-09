using System;
using System.Collections.Generic;
using System.Linq;

#region Student Grade



List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
Console.WriteLine("Grades: " + string.Join(", ", grades));
Console.WriteLine($"Count: {grades.Count}");
Console.WriteLine($"First: {grades[0]}, Last: {grades[grades.Count - 1]}");
grades.Sort();
Console.WriteLine("Sorted: " + string.Join(", ", grades));
int firstAbove90 = grades.Find(g => g > 90);
Console.WriteLine($"First grade above 90: {firstAbove90}");
List<int> failing = grades.FindAll(g => g < 75);
Console.WriteLine("Failing grades: " + string.Join(", ", failing));
grades.RemoveAll(g => g < 75);
Console.WriteLine("After removing failing: " + string.Join(", ", grades));
Console.WriteLine($"Contains 100? {grades.Contains(100)}");
List<string> gradeLabels = grades.ConvertAll(g => $"Grade: {g}");
Console.WriteLine(string.Join(" | ", gradeLabels));
Console.WriteLine();
#endregion
