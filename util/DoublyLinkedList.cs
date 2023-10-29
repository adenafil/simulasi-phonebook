using System;

namespace util
{
    public class DoublyLinkedList<T>
    {
        public Node<T> head;

        public void Append(T data)
        {
            Node<T> nodeBaru = new Node<T>(data);

            if (this.head == null)
            {
                head = nodeBaru;
                return;
            }

            Node<T> terakhir = head;

            while (terakhir.next != null)
            {
                terakhir = terakhir.next;
            }

            terakhir.next = nodeBaru;
            nodeBaru.prev = head;

        }

        public void Delete(T data)
        {
            Node<T> sekarang = head;
            
            while(sekarang != null)
            {
                if (sekarang.data.Equals(data))
                {
                    if (sekarang.prev != null)
                    {
                        sekarang.prev.next = sekarang.next;
                    }
                    else
                    {
                        head = sekarang.next;
                    }
                    if (sekarang.next != null)
                    {
                        sekarang.next.prev = sekarang.prev;
                    }
                    return;
                }
                sekarang = sekarang.next;
            }

        }


        public void PrintList()
        {
            Node<T> sekarang = head;
            while (sekarang != null)
            {
                Console.WriteLine(sekarang.data);
                sekarang = sekarang.next;
            }
        }

    }
}