using System;
using MyLinkedList;

namespace MyQueue
{
    public class MyQueue<T>
    {
        Node<T> Head = new Node<T>();
        Node<T> Tail = new Node<T>();
        private int count;

        public MyQueue()
        {
            Head = Tail = null;
            count = 0;
        }

        /// <summary>
        /// Adds an item to the Tail of the queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this.Tail == null)
            {
                this.Head = this.Tail = newNode;
            }
            else
            {
                this.Tail.next = newNode;
                this.Tail = newNode;
                count++;
            }
        }

        /// <summary>
        /// Removes and returns the item at the Head of the queue
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (this.Head == null)
            {
                throw new Exception("Empty Queue");
            }
            else
            {
                Node<T> temp = this.Head;
                this.Head = this.Head.next;
                count--;
            }
            return Head.item;
        }

        /// <summary>
        /// Returns true if the queue is empty and false if it isn’t
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Empty;
        }

        /// <summary>
        /// Shows the number of items currently in the queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return counts;
        }

        /// <summary>
        /// Empty Getter Method
        /// </summary>
        private bool Empty
        {
            get { return this.count == 0; }
        }

        /// <summary>
        /// counts getter method
        /// </summary>
        private int counts
        {
            get { return this.count; }
        }
    }
}