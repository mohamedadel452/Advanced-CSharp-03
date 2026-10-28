using System;

namespace Advanced_CSharp_03
{
    #region PART 01: SENIOR CLR & RAM DEEP DIVE - COLLECTIONS ARCHITECTURE
    /*
    ========================================================================================================================
    ADVANCED C# SESSION 03: BUILT-IN COLLECTIONS & MEMORY INTERNALS
    ========================================================================================================================

    1. List<T> (Dynamic Contiguous Array)
    ------------------------------------------------------------------------------------------------------------------------
    - Memory Layout: Allocated as a single continuous block of memory on the Managed Heap (T[] _items).
    - Capacity Growth: When the count reaches capacity, List<T> allocates a NEW array on the Heap with DOUBLE the capacity
      (capacity * 2), copies all old elements (via Array.Copy / memmove), and leaves the old array for the Garbage Collector (GC).
    - Time Complexity:
      * Indexer Access: O(1) direct memory pointer offset.
      * Add: Amortized O(1).
      * Insert/Remove at index: O(N) due to memory block shifting.

    2. Dictionary<TKey, TValue> & HashSet<T> (Hash Tables)
    ------------------------------------------------------------------------------------------------------------------------
    - Memory Layout: Consists of two internal parallel arrays:
      a) int[] _buckets: Stores head indexes into the entries array.
      b) Entry[] _entries: Stores hashCode, next pointer (for collision chaining), key, and value.
    - Hashing Mechanism: bucketIndex = (key.GetHashCode() & 0x7FFFFFFF) % buckets.Length.
    - Collision Resolution: Chaining via index pointers (not linked list objects, avoiding GC fragmentation).
    - Time Complexity: O(1) average lookup, insertion, and deletion.
    - Case Sensitivity: Passing StringComparer.OrdinalIgnoreCase calculates identical hash codes for "abc" and "ABC",
      ensuring case-insensitive uniqueness without string allocations.

    3. SortedList<TKey, TValue> vs SortedDictionary<TKey, TValue>
    ------------------------------------------------------------------------------------------------------------------------
    - SortedList<TKey, TValue>:
      * Stores items in two sorted arrays: TKey[] _keys and TValue[] _values.
      * Uses Binary Search (Array.BinarySearch) for lookup: O(log N).
      * Inserts/Deletes are O(N) because elements must be shifted.
      * Crucial Advantage: Low memory overhead, and keys/values can be accessed directly by index (Keys[0], Values[0]) in O(1)!
    - SortedDictionary<TKey, TValue>:
      * Implemented as a Red-Black Balanced Binary Search Tree.
      * Inserts and Deletions are O(log N) (no shifting).
      * Higher memory overhead due to left/right/parent node pointers.

    4. Queue<T> (Circular Buffer / Ring Array)
    ------------------------------------------------------------------------------------------------------------------------
    - Memory Layout: Uses an internal array with _head and _tail pointers that wrap around using modulo arithmetic.
    - Dequeue does NOT shift array elements! It simply advances the _head index in O(1).
    - Enqueue appends to the _tail index in O(1).
    - Principle: FIFO (First In, First Out).

    5. Stack<T> (LIFO Array)
    ------------------------------------------------------------------------------------------------------------------------
    - Memory Layout: Uses an internal array with a single _size pointer.
    - Push increments _size and sets element in O(1).
    - Pop decrements _size and clears the reference in O(1).
    - Principle: LIFO (Last In, First Out).
    ========================================================================================================================
    */
    #endregion

    #region Program Entrypoint
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("################################################################################");
            Console.WriteLine("         ADVANCED C# SESSION 03: COLLECTIONS ARCHITECTURE & EXERCISES           ");
            Console.WriteLine("################################################################################\n");

            #region Exercise 01
            StudentGradeManager.Run();
            #endregion

            #region Exercise 02
            LeaderboardManager.Run();
            #endregion

            #region Exercise 03
            PhoneBookManager.Run();
            #endregion

            #region Exercise 04
            EmailValidatorManager.Run();
            #endregion

            #region Exercise 05
            PrintQueueSimulator.Run();
            #endregion

            #region Exercise 06
            BrowserHistorySimulator.Run();
            #endregion

            Console.WriteLine("################################################################################");
            Console.WriteLine("               ALL 6 EXERCISES COMPLETED & VERIFIED SUCCESSFULLY                ");
            Console.WriteLine("################################################################################");
        }
    }
    #endregion
}
