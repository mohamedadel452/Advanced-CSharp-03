using System;
using System.Collections.Generic;

namespace Advanced_CSharp_03
{
    #region Exercise 04: Unique Email Validator
    /// <summary>
    /// Exercise 4: Unique Email Validator
    /// Demonstrates HashSet&lt;T&gt; (Set Data Structure):
    /// - Stores distinct elements using hash buckets with O(1) average lookup.
    /// - Custom IEqualityComparer (StringComparer.OrdinalIgnoreCase) for case-insensitive uniqueness.
    /// - Mathematical Set operations: UnionWith, IntersectWith, ExceptWith, and IsSubsetOf.
    /// </summary>
    public static class EmailValidatorManager
    {
        #region Execution Method
        public static void Run()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("             EXERCISE 04: UNIQUE EMAIL VALIDATOR (HashSet<string>)              ");
            Console.WriteLine("================================================================================\n");

            #region 1. HashSet with Case-Insensitive Comparer
            // StringComparer.OrdinalIgnoreCase ensures uppercase and lowercase produce identical hash codes and equality
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Add emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");
            #endregion

            #region 2. Print Count and Explanation
            Console.WriteLine("--- Email Storage Verification ---");
            Console.WriteLine($"Actual Stored Emails : [{string.Join(", ", emails)}]");
            Console.WriteLine($"Count in HashSet     : {emails.Count}");
            Console.WriteLine("EXPLANATION:");
            Console.WriteLine("Even though 4 additions were attempted, only 2 unique emails are stored.");
            Console.WriteLine("Because StringComparer.OrdinalIgnoreCase treats 'ahmed@test.com' and 'AHMED@test.com'");
            Console.WriteLine("as having identical hash codes and matching equality, preventing duplicates in O(1).");
            Console.WriteLine();
            #endregion

            #region 3. Mathematical Set Operations
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            Console.WriteLine("--- Mathematical Set Operations ---");
            Console.WriteLine($"Set A : [{string.Join(", ", setA)}]");
            Console.WriteLine($"Set B : [{string.Join(", ", setB)}]");
            Console.WriteLine();

            // A. UnionWith (A ∪ B)
            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);
            Console.WriteLine($"UnionWith (Set A ∪ Set B)        : [{string.Join(", ", unionSet)}]");

            // B. IntersectWith (A ∩ B)
            HashSet<int> intersectSet = new HashSet<int>(setA);
            intersectSet.IntersectWith(setB);
            Console.WriteLine($"IntersectWith (Set A ∩ Set B)    : [{string.Join(", ", intersectSet)}]");

            // C. ExceptWith (A \ B)
            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);
            Console.WriteLine($"ExceptWith (Set A \\ Set B)       : [{string.Join(", ", exceptSet)}]");
            Console.WriteLine();
            #endregion

            #region 4. IsSubsetOf Verification
            HashSet<int> subsetCandidate = new HashSet<int> { 1, 2 };
            bool isSub = subsetCandidate.IsSubsetOf(setA);
            Console.WriteLine($"Is {{ 1, 2 }} a subset of Set A? : {isSub}");
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
    #endregion
}
