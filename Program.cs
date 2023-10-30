using System;
using util;

namespace praktikumASD
{
    public class Program
    {

        private static DoublyLinkedList<Contact> doublyLinkedList = new DoublyLinkedList<Contact>();

        public static void Main(string[] args)
        {
            // Selama TRUE kode ini akan dieksekusi
            // agar bisa selalu memilih
            while(true) {
                Console.WriteLine("\nMenu Utama");
                Console.WriteLine("a. Tambah Contact");
                Console.WriteLine("b. Hapus Contact");
                Console.WriteLine("c. Tampilkan Contact");
                Console.WriteLine("d. Urutkan Contact (Optional)");
                Console.WriteLine("e. keluar");

                Console.Write("\nPilih Menu : ");
                char jawaban = Console.ReadLine()[0];

                // jika jawaban 'a' maka masuk ke menu tambah contact
                if (jawaban == 'a') MenuTambahContact();
                // jika jawaban 'b' maka masuk ke menu hapus contact
                if (jawaban == 'b') MenuHapusContact();
                //Jika jawaaban 'c' maka masuk ke menu print contact
                if (jawaban == 'c') MenuPrintContact();
                // jika jawaban 'd' maka masuk ke menu urutkan contact
                if (jawaban == 'd') MenuUrutkanContact();
                // Jika jawaban 'e' maka program akan berhenti
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

            // Jika answer == 1 maka masuk ke menu print ascending
            if (answer == '1') doublyLinkedList.AscendingPrint();
            // Jika answer == 1 maka masuk ke menu print ascending
            if (answer == '2') doublyLinkedList.DescendingPrint();
        }

    }
}
