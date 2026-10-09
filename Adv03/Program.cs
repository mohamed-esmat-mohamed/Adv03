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

#region Leaderboard
Console.WriteLine("===== Exercise 2: Leaderboard =====");
SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();
leaderboard.Add(500, "Ahmed");
leaderboard.Add(200, "Sara");
leaderboard.Add(800, "Ali");
leaderboard.Add(350, "Mona");
foreach (var entry in leaderboard)
    Console.WriteLine($"{entry.Key} => {entry.Value}");
Console.WriteLine($"First key: {leaderboard.Keys.First()}");
Console.WriteLine($"First value: {leaderboard.Values.First()}");
Console.WriteLine($"Score 500 exists? {leaderboard.ContainsKey(500)}");
if (leaderboard.TryGetValue(999, out string? player))
    Console.WriteLine($"Player with 999: {player}");
else
    Console.WriteLine("No player with score 999");
leaderboard.Remove(200);
Console.WriteLine("Updated leaderboard:");
foreach (var entry in leaderboard)
    Console.WriteLine($"{entry.Key} => {entry.Value}");
Console.WriteLine();
#endregion

#region Phone_Book
Dictionary<string, string> phoneBook = new Dictionary<string, string>
{
    { "Ahmed", "01011111111" },
    { "Sara",  "01022222222" },
    { "Ali",   "01033333333" },
    { "Mona",  "01044444444" }
};
phoneBook["Omar"] = "01055555555";   
phoneBook["Ahmed"] = "01099999999";  
Console.WriteLine("After [] add/update: " + string.Join(", ", phoneBook.Select(c => $"{c.Key}={c.Value}")));
try
{
    phoneBook.Add("Sara", "01000000000");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Add() failed: {ex.Message}");
}
bool added = phoneBook.TryAdd("Sara", "01000000000");
Console.WriteLine($"TryAdd succeeded? {added}");
Console.WriteLine($"Contains 'Hassan'? {phoneBook.ContainsKey("Hassan")}");
string number = phoneBook.GetValueOrDefault("Hassan", "Not Found");
Console.WriteLine($"Hassan: {number}");
Console.WriteLine("Keys:   " + string.Join(", ", phoneBook.Keys));
Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
Console.WriteLine();
#endregion


#region Unique Email
HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
emails.Add("ahmed@test.com");
emails.Add("AHMED@test.com");
emails.Add("sara@test.com");
emails.Add("Sara@Test.Com");
Console.WriteLine($"Count: {emails.Count}");
Console.WriteLine("Why 2? The comparer ignores case, so 'AHMED@test.com' equals 'ahmed@test.com' " +
                  "and 'Sara@Test.Com' equals 'sara@test.com' -> HashSet rejects them.");
HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
HashSet<int> union = new HashSet<int>(setA);
union.UnionWith(setB);
Console.WriteLine("UnionWith:     " + string.Join(", ", union));

HashSet<int> intersect = new HashSet<int>(setA);
intersect.IntersectWith(setB);
Console.WriteLine("IntersectWith: " + string.Join(", ", intersect));

HashSet<int> except = new HashSet<int>(setA);
except.ExceptWith(setB);
Console.WriteLine("ExceptWith:    " + string.Join(", ", except));
HashSet<int> small = new HashSet<int> { 1, 2 };
Console.WriteLine($"{{1,2}} is subset of A? {small.IsSubsetOf(setA)}");
Console.WriteLine();
#endregion