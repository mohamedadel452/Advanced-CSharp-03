using System;
using System.Collections.Generic;

namespace Advanced_CSharp_03
{
    #region Exercise 06: Browser History (Undo)
    /// <summary>
    /// Exercise 6: Browser History Simulator (Undo functionality)
    /// Demonstrates Stack&lt;T&gt; (LIFO - Last In, First Out):
    /// - Implemented internally as a dynamically resizing array.
    /// - Push adds elements to top of stack in O(1).
    /// - Pop removes and returns top element in O(1).
    /// - Peek inspects top element without removing it.
    /// - TryPop safely handles empty stack without throwing InvalidOperationException.
    /// </summary>
    public static class BrowserHistorySimulator
    {
        #region Execution Method
        public static void Run()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("          EXERCISE 06: BROWSER HISTORY SIMULATOR (Stack<string>)                ");
            Console.WriteLine("================================================================================\n");

            #region 1. Create Stack and Push 5 URLs
            Stack<string> history = new Stack<string>();
            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");
            #endregion

            #region 2. Peek Current Page (Top of Stack)
            string currentPage = history.Peek();
            Console.WriteLine($"Current Active Page (Peek) : '{currentPage}'");
            Console.WriteLine($"Total Pages in Stack       : {history.Count}");
            Console.WriteLine();
            #endregion

            #region 3. Press Back 3 Times Using Pop
            Console.WriteLine("--- Pressing 'Back' 3 Times (Pop) ---");
            for (int i = 1; i <= 3; i++)
            {
                string leftPage = history.Pop();
                Console.WriteLine($"Step {i}: Left page -> '{leftPage}'");
            }
            Console.WriteLine();
            #endregion

            #region 4. Print Current Page After Going Back
            string currentAfterBack = history.Peek();
            Console.WriteLine($"Current Page After Going Back : '{currentAfterBack}'");
            Console.WriteLine($"Remaining Pages in Stack      : [{string.Join(" -> ", history)}]");
            Console.WriteLine();
            #endregion

            #region 5. TryPop on Empty Stack
            Console.WriteLine("--- Emptying Stack and Testing TryPop ---");
            // Clear remaining pages
            history.Clear();
            Console.WriteLine($"Stack Count is now: {history.Count}");

            // Calling Pop() on empty stack throws InvalidOperationException ("Stack empty.").
            // TryPop() returns false safely.
            bool popSuccess = history.TryPop(out string? poppedUrl);
            Console.WriteLine($"TryPop Success? : {popSuccess}");
            Console.WriteLine($"Popped URL      : '{poppedUrl ?? "null"}'");
            Console.WriteLine("Observation: TryPop returns false safely without throwing exceptions on empty stacks.");
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
    #endregion
}
