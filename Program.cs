using System;
using util;

namespace praktikumASD
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact("082149250644", "Ade Nafil Firmansah", "nafilie9@gmail.com");
            DoublyLinkedList<Contact> contactList = new DoublyLinkedList<Contact>();
            contactList.Append(contact);
            contactList.PrintList();
        }
    }
}
