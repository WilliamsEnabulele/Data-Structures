namespace MyLinkedList
{
    public class Node<T>
    {
        public T item;
        public Node<T> next;

        public Node()
        {
            this.next = null;
        }

        public Node(T data)
        {
            item = data;
            next = null;
        }
    }
}