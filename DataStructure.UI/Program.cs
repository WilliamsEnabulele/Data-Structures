using MyLinkedList;
using MyStack;
using MyQueue;
using System;

namespace DataStructure.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyLinkedList<int> num = new MyLinkedList<int>();
            MyStack<int> mystack = new MyStack<int>();
            MyQueue<int> myqueue = new MyQueue<int>();
                
            /*num.Add(5);
            Console.WriteLine(num.Add(7));
            num.Add(9);
            num.Add(5);
            Console.WriteLine(num.Remove(9));
            num.Add(78); 
            Console.WriteLine(num.Check(0));*/
            mystack.Push(5);
            mystack.Push(67);
            mystack.Push(68);
            Console.WriteLine(mystack.IsEmpty());
            Console.WriteLine(mystack.Size());
            Console.WriteLine(mystack.Peek());
            Console.WriteLine(mystack.Pop());

            //num.DeleteNode(70);
            //m.DisplayList();
        }
    }
}