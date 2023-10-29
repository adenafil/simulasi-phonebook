using System;
using System.Linq;
using util;

namespace praktikumASD
{
    public class Program
    {
        private static int JumlahContact = 1;
        private static Contact[] contact = new Contact[JumlahContact];
        private static DoublyLinkedList<Contact> doublyLinkedList = new DoublyLinkedList<Contact>();

        public static void Main(string[] args)
        {
            TestAddContact();
            ShowContact();
        }

        public static void ShowContact() 
        {
            Console.WriteLine("Menu Tampilan Contact");
            doublyLinkedList.PrintList();
        }


        public static void AddContact(String noHp, String nama, String email)
        {
            var isFull = true;

            for (var i = 0; i < contact.Length; i++)
            {
                if (contact[i] == null)
                {
                    isFull = false;
                    break;
                }
            }


            if (isFull)
            {
                JumlahContact *= 2;
            }

            doublyLinkedList.Append(new Contact(noHp, nama, email));
        }

        public static void TestAddContact() {
            AddContact("123", "ade", "ade@gamil.com");
            AddContact("123", "nafil", "ade@gamil.com");
            AddContact("123", "firmansah", "ade@gamil.com");
            AddContact("123", "adena", "ade@gamil.com");
        }


    }
}
