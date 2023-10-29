using System;

namespace util
{
    public class DoublyLinkedList<T>
    {
        public Node<T> head;
        private int Size = 1;
        public int SIZE
        {
            get{return Size;}
        }

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

            Size++;
        }


        public void Delete(String data)
        {
            Node<T> sekarang = head;
            
            while(sekarang != null)
            {
                String temp = "" + sekarang.data;
                if (temp.Split(" ")[0] == data)
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
                    return;                }
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

        public void AscendingPrint()
        {
            Node<T> sekarang = head;
            String[] arrTemp = new string[SIZE]; 
            for (int i = 0; sekarang != null; i++)
            {
                arrTemp[i] = "" + sekarang.data;
                sekarang = sekarang.next;
            }

            Array.Sort(arrTemp);
            foreach (var arr in arrTemp)
            {
                Console.WriteLine(arr);
            }
        }

        public void DescendingPrint()
        {
            Node<T> sekarang = head;
            String[] arrTemp = new string[SIZE]; 
            for (int i = 0; sekarang != null; i++)
            {
                arrTemp[i] = "" + sekarang.data;
                sekarang = sekarang.next;
            }

            Array.Sort(arrTemp);
            Array.Reverse(arrTemp);
            foreach (var arr in arrTemp)
            {
                Console.WriteLine(arr);
            }
        }

    }
}