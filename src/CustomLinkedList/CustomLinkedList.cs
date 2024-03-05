using System.Collections;

namespace CustomLinkedList
{
    /// <summary>
    /// CustomLinkedList Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomLinkedList<T> : IEnumerable
    {
        public Node<T> Head { get; set; }
        private int count { get; set; }

        public CustomLinkedList()
        {
            Head = null;
            this.count = 0;
        }

        /// <summary>
        /// Adds an Item to the tail of the linkedList and returns the linked list’s size
        /// </summary>
        /// <param name="Item"></param>
        /// <returns>Int Size</returns>
        public int Add(T Item)
        {
            Node<T> newNode = new Node<T>
            {
                Item = Item
            };

            if (Head == null)
            {
                Head = newNode;
                count++;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Removes the first occurrence of an Item
        /// in the linked list, returns true if said
        /// Item is found and removed or returns
        /// false otherwise
        /// </summary>
        /// <param name="Item"></param>
        public bool Remove(T Item)
        {
            if (Head.Item.Equals(Item))
            {
                Head = Head.Next;
                count--;
                return true;
            }
            else
            {
                Node<T> current = Head;
                Node<T> currentPre = Head;
                bool matched;
                while (!(matched = current.Item.Equals(Item)) && current.Next != null)
                {
                    currentPre = current;
                    current = current.Next;
                }
                if (matched)
                {
                    currentPre.Next = current.Next;
                    count--;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// checks for a specified Item in the linked list. Returns a boolean
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public bool Check(T Item)
        {
            Node<T> current = Head;
            bool matched;
            while (!(matched = current.Item.Equals(Item)) && current.Next != null)
            {
                current = current.Next;
            }
            return matched;
        }

        /// <summary>
        /// Returns the index of an Item or returns -1 if the Item isn’t found
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Index(T Item)
        {
            Node<T> current = Head;
            var count = 0;
            for (var node = current; node != null; node = node.Next, count++)
            {
                if (Item.Equals(node.Item))
                    return count;
            }
            return -1;
        }

        public int Count()
        {
            return count;
        }

        /// <summary>
        /// Adds an Item to the Head of the linkedList
        /// </summary>
        /// <param name="Item"></param>
        public void AddAtHead(T Item)
        {
            Node<T> newNode = new Node<T>();
            newNode.Item = Item;
            if (Head == null)
            {
                Head = newNode;
                count++;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                count++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> node = Head;
            while (node != null)
            {
                yield return node.Item;
                node = node.Next;
            }
        }
    }
}