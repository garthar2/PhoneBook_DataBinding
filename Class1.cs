using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook_DataBinding
{
    public class People
    {
        public People(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }


    }
    public class Animal
    {
        public Animal(string breed = null, string color = null, string weight = null)
        {

            Breed = breed;
            Color = color;
            Weight = weight;
        }

        public string Breed { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }


    }
    public class Credentials 
    {
        public Credentials(string firstName, string lastName, string middleName, bool gender, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            YearOfBirth = yearOfBirth;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public bool Gender { get; set; }
        public int YearOfBirth { get; set; }
    }
    public class Address : Credentials
    {
        public Address(string firstName, string lastName, string middleName, bool gender, int yearOfBirth, string streetName, string buildNum,
            string flatNum):base(firstName,  lastName,  middleName, gender, yearOfBirth)
        {
            StreetName = streetName;
            BuildNum = buildNum;
            FlatNum = flatNum;
        }

        public string StreetName { get; set; }
        public string BuildNum { get; set; }
        public string FlatNum  { get; set; }
    }
    public class Phone : Address
    {
        public Phone(string firstName, string lastName, string middleName, bool gender, int yearOfBirth, string streetName, string buildNum,
            string flatNum, string phoneNum, bool isMobile) : base (firstName, lastName, middleName, gender, yearOfBirth, streetName,buildNum,flatNum)
        {
            PhoneNum = phoneNum;
            this.IsMobile = isMobile;
        }

        public string PhoneNum { get; set; }
        public bool IsMobile { get; set; }
    }
    public class PhoneBook :Phone
    {
        public PhoneBook(string email, string firstName, string lastName, string middleName, bool gender, int yearOfBirth, string streetName, string buildNum,
            string flatNum, string phoneNum, bool isMobile)
            :base (firstName, lastName, middleName, gender, yearOfBirth, streetName, buildNum, flatNum, phoneNum, isMobile)
        {
            Email = email;
        }

        public string Email { get; set; }
    }

    
}
