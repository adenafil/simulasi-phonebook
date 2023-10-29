using System;
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
                Console.WriteLine("d. Urutkan Contact (Optional)");
                Console.WriteLine("e. keluar");

                Console.Write("\nPilih Menu : ");
                char jawaban = Console.ReadLine()[0];

                if (jawaban == 'a') MenuTambahContact();
                if (jawaban == 'b') MenuHapusContact();
                if (jawaban == 'c') MenuPrintContact();
                if (jawaban == 'd') MenuUrutkanContact();
                if (jawaban == 'e') break;
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

        public static void MenuUrutkanContact()
        {
            Console.WriteLine("\nMenu Urutkan Contact");
            Console.WriteLine("1. Berdasarkan Nama(Ascending)");
            Console.WriteLine("2. Berdasarkan Nama(Descending)");
            Console.Write("Pilih Pengurutan : ");
            char answer = Console.ReadLine()[0];
            Console.WriteLine();

            if (answer == '1') doublyLinkedList.AscendingPrint();
            if (answer == '2') doublyLinkedList.DescendingPrint();
        }

    }
}
