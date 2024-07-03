using System;
using System.Collections;

namespace QueuesAndStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue is a first in / first out collection
            Queue queue = new ();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));

            //Dequeue removes and returns the object from the beggining pf the queue
            Console.WriteLine("Remove : {0}", queue.Dequeue());

            //Peek returns the first object without removing it 
            Console.WriteLine("Peek 1 : {0}", queue.Peek());

            object[] numArray = queue.ToArray();
            Console.WriteLine(String.Join(", ", numArray));
            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }
            queue.Clear();

            //Queue is a last in / last out collection
            Stack stack = new Stack();
            //Adding object to stack

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek 1 : {0}", stack.Peek());

            //Remove and return the first item at the top of a stack
            Console.WriteLine("Pop 1 : {0}", stack.Pop());
            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));

            object[] numArray2 = stack.ToArray();
            Console.WriteLine (String.Join(", ", numArray2));

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }
        }
    }
}
