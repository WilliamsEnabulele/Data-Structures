using CustomLinkedList;
using System;
using System.Collections;

namespace MyStack
{
    public class CustomStack<T> : IEnumerable
    {
        private Node<T> Top = new Node<T>();
        public int Count;

        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="size"></param>
        public CustomStack()
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
        /// Adds an Item to the Bottom of the stack
        /// </summary>
        public void Push(T Item)
        {
            Node<T> newNode = new Node<T>(Item);

            if (Top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Top;
            }
            Top = newNode;
            Count++;
        }

        /// <summary>
        /// Removes and returns the last Item added to the stack
        /// </summary>
        public T Pop()
        {
            if (Top == null)
            {
                throw new Exception("Empty Stack");
            }
            else if (Top.Next != null)
            {
                Top = Top.Next;
                Count--;
                return Top.Item;
            }
            else throw new Exception("Last Item is null");
        }

        /// <summary>
        /// Returns the last Item added to the stack
        /// </summary>
        public T Peek()
        {
            if (Top == null)
            {
                throw new Exception("Empty Stack");
            }

            return Top.Item;
        }

        /// <summary>
        /// Shows the number of Items currently in the stack
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

        public IEnumerator GetEnumerator()
        {
            Node<T> node = this.Top;
            while (node != null)
            {
                yield return node.Item;
                node = node.Next;
            }
        }
    }
}