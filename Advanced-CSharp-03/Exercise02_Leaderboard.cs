using System;
using System.Collections.Generic;

namespace Advanced_CSharp_03
{
    #region Exercise 02: Leaderboard
    /// <summary>
    /// Exercise 2: Leaderboard
    /// Demonstrates SortedList&lt;TKey, TValue&gt;:
    /// - Stores keys and values in two separate sorted internal arrays.
    /// - Automatically maintains elements sorted by key upon insertion via Binary Search.
    /// - Direct index access to keys and values via Keys[index] and Values[index] in O(1).
    /// - Lookup is O(log N) via binary search.
    /// </summary>
    public static class LeaderboardManager
    {
        #region Execution Method
        public static void Run()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("              EXERCISE 02: LEADERBOARD (SortedList<int, string>)                ");
            Console.WriteLine("================================================================================\n");

            #region 1. Initialization and Adding Entries
            // Create SortedList: Keys represent scores, Values represent player names
            SortedList<int, string> leaderboard = new SortedList<int, string>();

            // Add entries: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");
            #endregion

            #region 2. Print All Entries (Sorted Automatically)
            Console.WriteLine("--- Automatically Sorted Leaderboard ---");
            foreach (KeyValuePair<int, string> entry in leaderboard)
            {
                Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
            }
            Console.WriteLine();
            #endregion

            #region 3. Access First Key and First Value
            // SortedList allows direct index access to the internal sorted arrays in O(1)
            int firstKey = leaderboard.Keys[0];
            string firstValue = leaderboard.Values[0];
            Console.WriteLine($"First Key   (Lowest Score) : {firstKey}");
            Console.WriteLine($"First Value (Player Name)  : {firstValue}");
            Console.WriteLine();
            #endregion

            #region 4. Check if Score 500 Exists
            bool score500Exists = leaderboard.ContainsKey(500);
            Console.WriteLine($"Score 500 Exists? : {score500Exists}");
            Console.WriteLine();
            #endregion

            #region 5. Safely Get Player with Score 999
            // TryGetValue prevents KeyNotFoundException when key is missing
            bool found999 = leaderboard.TryGetValue(999, out string? player999);
            Console.WriteLine($"Get Score 999 : Found={found999}, Player={player999 ?? "None"}");
            Console.WriteLine();
            #endregion

            #region 6. Remove Player with Score 200 and Print Updated List
            bool removed200 = leaderboard.Remove(200);
            Console.WriteLine($"--- After Removing Score 200 (Success: {removed200}) ---");
            foreach (var kvp in leaderboard)
            {
                Console.WriteLine($"Score: {kvp.Key} -> Player: {kvp.Value}");
            }
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
    #endregion
}
