﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class ManipulateContact
    {

        public List<ContactDetails> AddressBookList = new List<ContactDetails>();

        //Dictionary<string , ContactOptions> AddressBookList = new Dictionary<string, ContactOptions>();
        //Dictionary<string, ContactOptions> AddressBookList;


        public void AddingContact
            (
            string Name,
            string Address,
            string City,
            string State,
            string ZipCode,
            string PhoneNumber,
            string Email
            )
        {
            
            AddressBookList.Add
                ( new ContactDetails()
                {
                    Name = Name,
                    Address = Address,
                    City = City,
                    State = State,
                    ZipCode = ZipCode,
                    PhoneNumber = PhoneNumber,
                    Email = Email
                }
            );
            Console.WriteLine($"{Name}'s contact is added______");

    }


    public void EditingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.Name.Contains(Name))
                {
                    /*Console.Write("plz provide new ");
                    contact.Address = Console.ReadLine();
                    Console.Write("plz provide new ");
                    contact.City = Console.ReadLine();
                    Console.Write("plz provide new ");
                    contact.State = Console.ReadLine();
                    Console.Write("plz provide new ");
                    contact.ZipCode = Console.ReadLine();*/
                    Console.Write("enter new phone number: ");
                    contact.PhoneNumber = Console.ReadLine();
                    Console.Write("enter new email id: ");
                    contact.Email = Console.ReadLine();
                    Console.WriteLine($"{Name}'s Contact is edited______");
                    break;
                }
            }
        }

        public void DeletingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.Name.Contains(Name))
                {
                    AddressBookList.Remove(contact);
                    Console.WriteLine($"{Name}'s Contact is deleted______");
                    break;
                }
            }
        }
    }
}
