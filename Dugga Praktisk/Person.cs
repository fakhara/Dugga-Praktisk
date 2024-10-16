using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga_Praktisk
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string personalNumber;
        private string address;

        public Person(string firstName, string lastName, string personalNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            Address = address;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Förnamn får inte vara tomt.");
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Efternamn får inte vara tomt.");
                }
            }
        }
        public string PersonalNumber
        {
            get { return personalNumber; }
            set
            {
                if (value.Length == 10 || value.Length == 12) 
                {
                    personalNumber = value;
                }
                else
                {
                    throw new ArgumentException("Personnummer måste vara 10 eller 12 siffror långt.");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    address = value;
                }
                else
                {
                    throw new ArgumentException("Adress får inte vara tom.");
                }
            }
        }
        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Namn: {FirstName} {LastName}");
            Console.WriteLine($"Personnummer: {PersonalNumber}");
            Console.WriteLine($"Adress: {Address}");
        }
    }
}
