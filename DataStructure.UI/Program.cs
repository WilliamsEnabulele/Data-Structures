using MyLinkedList;
using MyQueue;
using MyStack;
using System;

namespace DataStructure.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Instantiate Data Structures*/
            MyLinkedList<int> myLinkInt = new MyLinkedList<int>();
            MyLinkedList<string> myLinkStr = new MyLinkedList<string>();
            MyStack<int> myStackInt = new MyStack<int>();
            MyStack<string> myStackStr = new MyStack<string>();
            MyQueue<int> myQueueInt = new MyQueue<int>();
            MyQueue<string> myQueueStr = new MyQueue<string>();

            //+++++++++++++++++ LINKED LIST TEST ++++++++++++++++//
            Console.WriteLine("LINKEDLIST \n With Integers:");
            // Adds 5 Integers
            myLinkInt.Add(2);
            myLinkInt.Add(4);
            myLinkInt.Add(6);
            myLinkInt.Add(8);
            myLinkInt.Add(10);
            myLinkInt.Add(12);
            // Remove Item from LinkedList
            myLinkInt.Remove(8);
            // Returns Boolean - Should Be False
            Console.WriteLine(myLinkInt.Check(8));
            // Returns Number of Items In Linked List
            Console.WriteLine("Item Count: " + myLinkInt.Count());
            // Returns The Index of An Item In Linked List
            Console.WriteLine("Item Index: " + myLinkInt.Index(12));
            // Prints Records In Linked List
            foreach (var item in myLinkInt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LINKEDLIST\n With Strings:");
            // Adds 5 Strings
            myLinkStr.Add("The");
            myLinkStr.Add("Life");
            myLinkStr.Add("of");
            myLinkStr.Add("a");
            myLinkStr.Add("Software");
            myLinkStr.Add("Engineer");
            // Remove Item from LinkedList
            myLinkInt.Remove(8);
            // Returns Boolean - Should Be True
            Console.WriteLine(myLinkStr.Check("Engineer"));
            // Returns Number of Items In Linked List
            Console.WriteLine($"Item Count: " + myLinkInt.Count());
            // Returns The Index of An Item In Linked List when found and -1 when not found
            Console.WriteLine("Item Index: " + myLinkStr.Index("Engineer"));
            // Prints Records In Linked List
            foreach (var item in myLinkStr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //+++++++++++++++++ STACK TEST ++++++++++++++++//

            Console.WriteLine("STACK \n With Integers:");
            // Adds 5 Integers
            myStackInt.Push(1);
            myStackInt.Push(2);
            myStackInt.Push(3);
            myStackInt.Push(4);
            myStackInt.Push(5);
            myStackInt.Push(6);
            // Returns Size of Stack
            Console.WriteLine("Last Item Added: " + myStackInt.Size());
            // Remove Item from Stack
            Console.WriteLine("Last Item Added: " + myStackInt.Pop());
            // Returns Last Item In The Stack
            Console.WriteLine("Last Item Added: " + myStackInt.Peek());
            // Returns Boolean
            Console.WriteLine("Is Stack Empty?: " + myStackInt.IsEmpty());

            foreach (var item in myStackStr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("STACK\n With Strings:");
            // Adds 5 Strings
            myStackStr.Push(".NET");
            myStackStr.Push("Is");
            myStackStr.Push("Super");
            myStackStr.Push("Dope");
            myStackStr.Push("Yay!");
            // Returns Size of Stack
            Console.WriteLine("Last Item Added: " + myStackStr.Size());
            // Remove Item from Stack
            Console.WriteLine("Last Item Added: " + myStackStr.Pop());
            // Returns Last Item In The Stack
            Console.WriteLine("Last Item Added: " + myStackStr.Peek());
            // Returns Boolean
            Console.WriteLine("Is Stack Empty?: " + myStackStr.IsEmpty());

            foreach (var item in myStackStr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //+++++++++++++++++ QUEUE TEST ++++++++++++++++//
            Console.WriteLine("QUEUE \n With Integers:");
            myQueueInt.Enqueue(10);
            myQueueInt.Enqueue(20);
            myQueueInt.Enqueue(30);
            myQueueInt.Enqueue(40);
            myQueueInt.Enqueue(50);
            // Remove Item From Queue And Returns Item At The Head
            Console.WriteLine("Item At Head After Dequeuing: " + myQueueInt.Dequeue());
            // SIze Of Queue
            Console.WriteLine("Queue Size: " + myQueueInt.Size());
            Console.WriteLine("Is Queue Empty?: " + myQueueInt.IsEmpty());
            foreach (var item in myQueueInt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("QUEUE \n With Strings:");
            myQueueStr.Enqueue("a");
            myQueueStr.Enqueue("b");
            myQueueStr.Enqueue("c");
            myQueueStr.Enqueue("d");
            myQueueStr.Enqueue("e");
            // Remove Item From Queue And Returns Item At The Head
            Console.WriteLine("Item At Head After Dequeuing: " + myQueueStr.Dequeue());
            // SIze Of Queue
            Console.WriteLine("Queue Size: " + myQueueStr.Size());
            Console.WriteLine("Is Queue Empty?: " + myQueueStr.IsEmpty());
            foreach (var item in myQueueStr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}