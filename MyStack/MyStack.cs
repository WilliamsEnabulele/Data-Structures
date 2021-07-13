using MyLinkedList;
using System;

namespace MyStack
{
    public class MyStack<T>
    {
        private Node<T> Top = new Node<T>();
        public int Count;

        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="size"></param>
        public MyStack()
        {
            this.Top = null;
            this.Count = 0;
        }

        /// <summary>
        /// Returns true if the stack is empty and false if it isn’t
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsEmpty()
        {
            return Empty;
        }

        /// <summary>
        /// Adds an item to the Bottom of the stack
        /// </summary>
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (Top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = Top;
            }
            Top = newNode;
            Count++;
        }

        /// <summary>
        /// Removes and returns the last item added to the stack
        /// </summary>
        public T Pop()
        {
            if (Top == null)
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                Top = Top.next;
                Count--;
            }
            return Top.item;
        }

        /// <summary>
        /// Returns the last item added to the stack
        /// </summary>
        public T Peek()
        {
            if (Top == null)
            {
                throw new Exception("Empty Stack");
            }

            return Top.item;
        }

        /// <summary>
        /// Shows the number of items currently in the stack
        /// </summary>
        /// <returns>Integer</returns>
        public int Size()
        {
            return Counts;
        }

        /// <summary>
        /// Empty Getter Method
        /// </summary>
        /// <returns>Boolean</returns>
        private bool Empty
        {
            get { return Count == 0; }
        }

        /// <summary>
        /// counts getter method
        /// </summary>
        private int Counts
        {
            get { return Count; }
        }
    }
}