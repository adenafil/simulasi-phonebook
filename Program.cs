using System;
using System.Linq;
using System.Runtime.InteropServices;
using util;

namespace praktikumASD
{
    public class Program
    {

        private static DoublyLinkedList<Contact> doublyLinkedList = new DoublyLinkedList<Contact>();

        public static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("\nMenu Utama");
                Console.WriteLine("a. Tambah Contact");
                Console.WriteLine("b. Hapus Contact");
                Console.WriteLine("c. Tampilkan Contact");
                Console.WriteLine("d. Keluar");

                Console.Write("\nPilih Menu : ");
                char jawaban = Console.ReadLine()[0];

                if (jawaban == 'a') MenuTambahContact();
                if (jawaban == 'b') MenuHapusContact();
                if (jawaban == 'c') MenuPrintContact();
                if (jawaban == 'd') break;
            }
        }

        public static void MenuTambahContact()
        {
            Console.WriteLine("\nMenu Tambah Contact");
            Console.Write("Telepon : ");
            String telepon = Console.ReadLine();
            Console.Write("Nama : ");
            String nama = Console.ReadLine();
            Console.Write("Email : ");
            String email = Console.ReadLine();

            doublyLinkedList.Append(new Contact(telepon, nama, email));
        }

        public static void MenuHapusContact()
        {
            Console.WriteLine("\nMenu Hapus Contact");
            Console.Write("Masukan nama contact yang mau dihapus : ");
            String hapusContact = Console.ReadLine();
            doublyLinkedList.Delete(hapusContact);
        }

        public static void MenuPrintContact()
        {
            Console.WriteLine("\nMenu Print Contact");
            doublyLinkedList.PrintList();
            Console.WriteLine("Total Contact : " + doublyLinkedList.SIZE);
        }

    }
}
