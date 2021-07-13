 using System;

namespace MyLinkedList
{
    public class MyLinkedList<T>
    {
        private Node<T> Head { get; set; }
        public int count { get; set; }

        public MyLinkedList()
        {
            this.Head = null;
            this.count = 0;
        }

        /// <summary>
        /// Adds an item to the tail of the linkedList and returns the linked list’s size
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Int Size</returns>
        public int Add(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.Head == null)
            {
                this.Head = newNode;
                count++;
            }
            else
            {
                Node<T> current = this.Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Removes the first occurrence of an item
        /// in the linked list, returns true if said
        /// item is found and removed or returns
        /// false otherwise
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(T item)
        {
            if (this.Head.item.Equals(item))
            {
                Head = Head.next;
                count--;
                return true;
            }
            else
            {
                Node<T> current = Head;
                Node<T> currentPre = Head;
                bool matched = false;
                while (!(matched = current.item.Equals(item)) && current.next != null)
                {
                    currentPre = current;
                    current = current.next;
                }
                if (matched)
                {
                    currentPre.next = current.next;
                    count--;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// checks for a specified item in the linked list. Returns a boolean
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Check(T item)
        {
            Node<T> current = this.Head;
            bool matched = false;
            while (!(matched = current.item.Equals(item)) && current.next != null)
            {
                current = current.next;
            }
            return matched;
        }

        /// <summary>
        /// Returns the index of an item or returns -1 if the item isn’t found
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /* public int Index(T item)
         {
             var count = 0;
             for (var node = list.First; node != null; node = node.Next, count++)
             {
                 if (item.Equals(node.Value))
                     return count;
             }
             return -1;
         }*/

        public void DisplayList()
        {
            Console.WriteLine("Displaying List!");
            Node<T> temp = this.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.item);
                temp = temp.next;
            }
        }
    }
}