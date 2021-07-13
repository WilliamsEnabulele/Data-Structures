using MyLinkedList;
using System;

namespace DataStructure.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyLinkedList<int> num = new MyLinkedList<int>();
            num.Add(5);
            Console.WriteLine(num.Add(7));
            num.Add(9);
            num.Add(5);
            Console.WriteLine(num.Remove(9));
            num.Add(78);
            Console.WriteLine(num.Check(0));
            //num.DeleteNode(70);
            //m.DisplayList();
        }
    }
}