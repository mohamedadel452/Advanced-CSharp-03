using System;
using System.Collections.Generic;

namespace Advanced_CSharp_03
{
    #region Exercise 03: Phone Book
    /// <summary>
    /// Exercise 3: Phone Book
    /// Demonstrates Dictionary&lt;TKey, TValue&gt; (Hash Table):
    /// - Stores key-value pairs using hash buckets.
    /// - O(1) average time complexity for Add, Lookup, and Remove.
    /// - Demonstrates key collision, exception handling, and safe access patterns.
    /// </summary>
    public static class PhoneBookManager
    {
        #region Execution Method
        public static void Run()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("            EXERCISE 03: PHONE BOOK (Dictionary<string, string>)                ");
            Console.WriteLine("================================================================================\n");

            #region 1. Create Collection with 4 Contacts
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                { "Ahmed", "01012345678" },
                { "Sara",  "01123456789" },
                { "Ali",   "01234567890" },
                { "Mona",  "01545678901" }
            };
            Console.WriteLine("--- Initial Phone Book ---");
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
            Console.WriteLine();
            #endregion

            #region 2. Add New Contact Using [] Syntax (Add or Update)
            // Indexer [] adds if key does not exist, or updates if key already exists
            phoneBook["Kareem"] = "01099988877";
            Console.WriteLine($"Added Kareem via [] Indexer: {phoneBook["Kareem"]}");
            Console.WriteLine();
            #endregion

            #region 3. Try Adding Duplicate with .Add() (Catches Exception)
            Console.WriteLine("--- Adding Duplicate via .Add() ---");
            try
            {
                // .Add throws ArgumentException when key already exists!
                phoneBook.Add("Kareem", "01000000000");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[CAUGHT EXPECTED EXCEPTION]: {ex.Message}");
            }
            Console.WriteLine();
            #endregion

            #region 4. Try Adding Duplicate with .TryAdd() (Safe)
            Console.WriteLine("--- Adding Duplicate via .TryAdd() ---");
            bool tryAddSuccess = phoneBook.TryAdd("Kareem", "01000000000");
            Console.WriteLine($"TryAdd('Kareem') Succeeded? : {tryAddSuccess} (Returned false safely without throwing exception)");
            Console.WriteLine();
            #endregion

            #region 5. Search for a Contact that Doesn't Exist
            bool hasHassan = phoneBook.ContainsKey("Hassan");
            Console.WriteLine($"Searching for non-existent contact 'Hassan': Exists? {hasHassan}");
            Console.WriteLine();
            #endregion

            #region 6. Get Contact with Fallback ("Not Found")
            // Using TryGetValue or GetValueOrDefault
            string fallbackContact = phoneBook.GetValueOrDefault("Hassan", "Not Found");
            Console.WriteLine($"Get 'Hassan' with Fallback: '{fallbackContact}'");
            Console.WriteLine();
            #endregion

            #region 7. Print All Keys on One Line, Then All Values on Another
            Console.WriteLine("--- Phone Book Directory Keys & Values ---");
            Console.WriteLine("All Keys   : " + string.Join(", ", phoneBook.Keys));
            Console.WriteLine("All Values : " + string.Join(", ", phoneBook.Values));
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
    #endregion
}
