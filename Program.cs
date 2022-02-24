﻿// See https://aka.ms/new-console-template for more information
using System;

namespace AddressBookSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book system");
            bool Exit = false;

            ContactOptions contactOptions = new ContactOptions();
            while (Exit == false)
            {
                Console.Write("enter address book name: ");
                string BookName = Console.ReadLine();

                contactOptions.AddContact(BookName);
                contactOptions.EditContact();
                contactOptions.DeleteContact();
                Console.Write("add another address book? (Y/N): ");
                String Choise = Console.ReadLine().ToUpper();
                Exit = Choise == "Y" ? false :  true;
            }
        }


    }
}
