using System;

namespace util
{
    public class Node <T>
    {
        public T data;
        public Node<T> prev;
        public Node<T> next;

        public Node(T d) 
        {
            this.data = d;
        }

        public T Tes()
        {
            return data;
        }

    }
}