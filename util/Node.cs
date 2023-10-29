using System;

namespace util
{
    public class Node <T>
    {
        public T data;
        public Contact contact;
        public Node<T> prev;
        public Node<T> next;

        public Node(T d) 
        {
            this.data = d;
        }
    }
}