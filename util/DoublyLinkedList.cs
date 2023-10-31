using System;

namespace util
{
    public class DoublyLinkedList<T>
    {
        public Node<T> head;
        private int Size = 0;
        public int SIZE
        {
            get { return Size; }
        }


        public void Append(T data)
        {
            Node<T> nodeBaru = new Node<T>(data);

            // cek jika head null
            if (this.head == null)
            {
                // head = nodeBaru;
                head = nodeBaru;
                Size++;
                return;
            }

            Node<T> terakhir = head;
            
            // selama next tidak null while running dan head != null
            while (terakhir.next != null)
            {
                // hingga mendaptkan next paling ujung
                terakhir = terakhir.next;
            }

            // node next menjadi node baru;
            terakhir.next = nodeBaru;
            // node prev menjadi menjadi terakhir atau head
            nodeBaru.prev = terakhir;

            Size++;
        }

        public Node<T> Get(String contactName)
        {
            Node<T> sekarang = head;

            // selama head tidak kosong maka program ini jalan
            while (sekarang != null)
            {
                String tempName = "" + sekarang.data;
                // jika cek true maka return sekarang
                if (tempName.Split(" ")[0] == contactName)
                {
                    return sekarang;
                }
                sekarang = sekarang.next;
            }
            return null;
        }


        public void Delete(Node<T> data)
        {
            // cek head && data jika null maka berhenti
            if (head == null || data == null)
            {
                return;
            }

            Node<T> sekarang = head;
            while (sekarang != null)
            {
                // cek jika node sekarang sama dengan input data
                if (sekarang.Equals(data))
                {
                    // cek jika head == data
                    if (head == data)
                    {
                        // maka geser ke next
                        head = data.next;
                    }

                    // cek jika nextnya tidak kosong
                    if (data.next != null)
                    {
                        // geser next.prev ke prev
                        data.next.prev = data.prev;
                    }

                    // sebaliknya jika prev tidak kosong
                    if (data.prev != null)
                    {
                        // prev.next dari data asign ke data.next
                        data.prev.next = data.next;
                    }
                    Size--;
                    return;
                }
                sekarang = sekarang.next;
            }
        }

        public void PrintList()
        {
            Node<T> sekarang = head;

            // jika head atau sekarang tidak sama dengan null
            // maka print sekarang.data
            // lalu asign dengan sekaran.next
            while (sekarang != null)
            {
                // geser ke next terus hingga == null
                Console.WriteLine(sekarang.data);
                sekarang = sekarang.next;
            }
        }

        public void AscendingPrint()
        {
            Node<T> sekarang = head;
            String[] arrTemp = new string[SIZE];
            // Jika Sekarang != null
            // maka kita akan mengasign array baru ke arrTempt
            // lalu kita next hingga sekarang = null
            for (int i = 0; sekarang != null; i++)
            {
                arrTemp[i] = "" + sekarang.data;
                sekarang = sekarang.next;
            }

            // Kemudian kita sort ascending
            // menggunakan method static dari
            // class Array 
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

            // Jika Sekarang != null
            // maka kita akan mengasign array baru ke arrTempt
            // lalu kita next hingga sekarang = null
            for (int i = 0; sekarang != null; i++)
            {
                arrTemp[i] = "" + sekarang.data;
                sekarang = sekarang.next;
            }

            // Kemudian kita sort ascending
            // menggunakan method static dari
            // class Array lalu kita reverse
            // sehingga menjadi descending
            Array.Sort(arrTemp);
            Array.Reverse(arrTemp);
            foreach (var arr in arrTemp)
            {
                Console.WriteLine(arr);
            }
        }

    }
}