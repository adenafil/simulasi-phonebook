using System;
using util;

namespace praktikumASD
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact("082149250644", "Ade Nafil Firmansah", "nafilie9@gmail.com");

            Contact[] tes = new Contact[3];

            tes[0] = new Contact("123", "123", "123");
            tes[1] = new Contact("124", "124", "124");
            tes[2] = new Contact("125", "125", "125");


            DoublyLinkedList<Contact> contactList = new DoublyLinkedList<Contact>();
            contactList.Append(contact);
            contactList.Append(tes[0]);
            contactList.Append(tes[1]);
            contactList.Append(tes[2]);
            contactList.PrintList();

            contactList.Delete(tes[0]);
            contactList.PrintList();
            tes[1].NoTelepon = null;
            Console.WriteLine(tes[1].NoTelepon);


        }
    }
}
