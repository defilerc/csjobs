using System;
using System.Collections.Generic;

namespace CodeFights
{
    public class TaleOfTwoStacks
    {
        // set public for testing
        public Stack<string> lifo = new Stack<string>(); // stack
        public Stack<string> fifo = new Stack<string>(); // queue-like

        public void RunQuery(string query) 
        {
            var q = query.Split(" ");

            if (q[0] == "1") {          // enqueue q[1]
                lifo.Push(q[1]);
            } else if (q[0] == "2") {   // dequeue
                if (fifo.Count == 0) {
                    TransferToFifo();
                }
                fifo.Pop();
            } else {                    // print front
                if (fifo.Count == 0) {
                    TransferToFifo();
                }
                System.Console.WriteLine(fifo.Peek());
            }
        }

        private void TransferToFifo()
        {
            while (lifo.Count > 0) {
                fifo.Push(lifo.Pop());
            }
        }
    }
}