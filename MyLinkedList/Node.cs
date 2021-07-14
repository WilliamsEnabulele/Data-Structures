namespace MyLinkedList
{
    public class Node<T>
    {
        public T Item;
        public Node<T> Next;

        public Node()
        {
            this.Next = null;
        }

        public Node(T data)
        {
            Item = data;
            Next = null;
        }
    }
}