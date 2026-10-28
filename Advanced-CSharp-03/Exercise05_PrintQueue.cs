using System;
using System.Collections.Generic;

namespace Advanced_CSharp_03
{
    #region Exercise 05: Print Queue Simulator
    /// <summary>
    /// Exercise 5: Print Queue Simulator
    /// Demonstrates Queue&lt;T&gt; (FIFO - First In, First Out):
    /// - Implemented internally as a circular array.
    /// - Enqueue adds to the back of the queue in O(1).
    /// - Dequeue removes from the front of the queue in O(1).
    /// - Peek inspects the front element without removal.
    /// - TryDequeue prevents InvalidOperationException on empty queues.
    /// </summary>
    public static class PrintQueueSimulator
    {
        #region Execution Method
        public static void Run()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("             EXERCISE 05: PRINT QUEUE SIMULATOR (Queue<string>)                 ");
            Console.WriteLine("================================================================================\n");

            #region 1. Create Queue and Enqueue 5 Documents
            Queue<string> printQueue = new Queue<string>();
            printQueue.Enqueue("Report.pdf");
            printQueue.Enqueue("Invoice.pdf");
            printQueue.Enqueue("Letter.docx");
            printQueue.Enqueue("Resume.pdf");
            printQueue.Enqueue("Photo.jpg");
            #endregion

            #region 2. Print Queue Contents and Count
            Console.WriteLine("--- Queue Contents ---");
            Console.WriteLine($"Queue Documents : [{string.Join(" -> ", printQueue)}]");
            Console.WriteLine($"Total Documents in Queue : {printQueue.Count}");
            Console.WriteLine();
            #endregion

            #region 3. Peek Next Document
            // Peek returns the element at the beginning of the Queue without removing it
            string nextDoc = printQueue.Peek();
            Console.WriteLine($"Next Document to Print (Peek) : '{nextDoc}'");
            Console.WriteLine($"Queue Count remains unchanged : {printQueue.Count}");
            Console.WriteLine();
            #endregion

            #region 4. Process Queue via Dequeue
            Console.WriteLine("--- Processing Print Queue (FIFO) ---");
            while (printQueue.Count > 0)
            {
                string document = printQueue.Dequeue();
                Console.WriteLine($"Printing: [{document}]");
            }
            Console.WriteLine($"Queue Count after processing: {printQueue.Count}");
            Console.WriteLine();
            #endregion

            #region 5. TryDequeue on Empty Queue
            Console.WriteLine("--- Attempting TryDequeue on Empty Queue ---");
            // If calling printQueue.Dequeue() on empty queue, InvalidOperationException would be thrown.
            // TryDequeue returns false safely without throwing exceptions!
            bool dequeued = printQueue.TryDequeue(out string? result);
            Console.WriteLine($"TryDequeue Success? : {dequeued}");
            Console.WriteLine($"Result Value        : '{result ?? "null"}'");
            Console.WriteLine("Observation: TryDequeue returns false and null gracefully without crashing the app.");
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
    #endregion
}
