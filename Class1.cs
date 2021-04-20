using System;

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



    public abstract class PhoneBook
    {

        public abstract void PrintInfo();
        public abstract bool IsClientByDate(DateTime date);
    }

    public class Credentials : PhoneBook
    {
        public Credentials(string firstName, string lastName, string middleName, bool gender, DateTime yearOfBirth)
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
        public DateTime YearOfBirth { get; set; }



        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия: {0}", LastName);
            Console.WriteLine("Имя: {0}", FirstName);
            Console.WriteLine("Отчество: {0}", MiddleName);
            Console.WriteLine("Дата рождения: {0}", YearOfBirth.ToShortDateString());
            Console.WriteLine("Муж?: {0}", Gender);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (YearOfBirth == date)
                return true;
            return false;
        }
    }

    public class Address : PhoneBook
    {
        public string StreetName { get; set; }
        public string BuildNum { get; set; }
        public string FlatNum { get; set; }

        public Address(string streetName, string buildNum, string flatNum)
        {
            StreetName = streetName;
            BuildNum = buildNum;
            FlatNum = flatNum;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Улица: {0}", StreetName);
            Console.WriteLine("Номер дома: {0}", BuildNum);
            Console.WriteLine("Номер квартиры: {0}", FlatNum);
        }

        public override bool IsClientByDate(DateTime date)
        {
            /*    if (CreditDate == date)
                    return true;*/
            return false;
        }
    }

    public class PhoneInfo : PhoneBook
    {
        public PhoneInfo(string phoneNum, bool isMobile)
        {
            PhoneNum = phoneNum;
            IsMobile = isMobile;
        }

        public string PhoneNum { get; set; }
        public bool IsMobile { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Телефон: {0}", PhoneNum);
            Console.WriteLine("Мобильный?: {0}", IsMobile);
        }

        public override bool IsClientByDate(DateTime date)
        {
            // if (AccountDate == date)
            //    return true;
            return false;
        }
    }

}

