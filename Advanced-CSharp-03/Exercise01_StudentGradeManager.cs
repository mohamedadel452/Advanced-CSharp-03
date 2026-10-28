using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_CSharp_03
{
    #region Exercise 01: Student Grade Manager
    /// <summary>
    /// Exercise 1: Student Grade Manager
    /// Demonstrates List&lt;T&gt; (Dynamic Array):
    /// - Continuous contiguous memory allocation on the Managed Heap.
    /// - O(1) indexer access, amortized O(1) addition, and O(N) removals.
    /// </summary>
    public static class StudentGradeManager
    {
        #region Execution Method
        public static void Run()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("                 EXERCISE 01: STUDENT GRADE MANAGER (List<T>)                   ");
            Console.WriteLine("================================================================================\n");

            #region 1. Collection Initialization
            // Create a collection with the initial grades: 85, 92, 78, 95, 88, 70, 100, 65
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            #endregion

            #region 2. Print Collection, Count, First and Last Grade
            Console.WriteLine("--- Initial Grades ---");
            Console.WriteLine($"All Grades  : [{string.Join(", ", grades)}]");
            Console.WriteLine($"Total Count : {grades.Count}");
            Console.WriteLine($"First Grade : {grades[0]}");
            Console.WriteLine($"Last Grade  : {grades[grades.Count - 1]}");
            Console.WriteLine();
            #endregion

            #region 3. Sort Ascending
            // Sort grades in-place (IntroSort algorithm: QuickSort + HeapSort + InsertionSort)
            grades.Sort();
            Console.WriteLine("--- Sorted Grades (Ascending) ---");
            Console.WriteLine($"Sorted      : [{string.Join(", ", grades)}]");
            Console.WriteLine();
            #endregion

            #region 4. Get First Grade Above 90
            int firstAbove90 = grades.Find(g => g > 90);
            Console.WriteLine($"First Grade Above 90 : {firstAbove90}");
            Console.WriteLine();
            #endregion

            #region 5. Get All Failing Grades (Below 75)
            List<int> failingGrades = grades.FindAll(g => g < 75);
            Console.WriteLine("--- Failing Grades (< 75) ---");
            Console.WriteLine($"Failing     : [{string.Join(", ", failingGrades)}]");
            Console.WriteLine();
            #endregion

            #region 6. Remove All Failing Grades
            int removedCount = grades.RemoveAll(g => g < 75);
            Console.WriteLine("--- After Removing Failing Grades ---");
            Console.WriteLine($"Removed Count : {removedCount}");
            Console.WriteLine($"Active Grades : [{string.Join(", ", grades)}]");
            Console.WriteLine();
            #endregion

            #region 7. Check if Any Grade Equals 100
            bool hasPerfectScore = grades.Contains(100);
            Console.WriteLine($"Contains Grade 100? : {hasPerfectScore}");
            Console.WriteLine();
            #endregion

            #region 8. Transform to List<string> ("Grade: X")
            List<string> formattedGrades = grades.ConvertAll(g => $"Grade: {g}");
            Console.WriteLine("--- Formatted String Grades ---");
            foreach (var item in formattedGrades)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
    #endregion
}
