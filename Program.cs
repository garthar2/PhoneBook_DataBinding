using System;
using System.Windows.Forms;

namespace PhoneBook_DataBinding
{
    interface IDataProvider
    {
        string GetData();//все паблик в интерфейсах
    }
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из API";
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());

            PhoneBook[] phoneBookDataBase = new PhoneBook[]
            {
                    new Credentials ( "Колян", "Петров", "Иванович",true,new DateTime(1945,10,6) ),
                    new Credentials ("Васян", "Дачев","Бедросович",false, new DateTime(1967,12,12)),
                    new Address ("Ленина", "10","5"),
                    new Address ("Гаражная", "2","105"),
                    new PhoneInfo("4096583",false),
                    new PhoneInfo("0679146592",true)
            };

            foreach (PhoneBook phoneBook in phoneBookDataBase)
            {
                phoneBook.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine();

            DateTime askDate = new DateTime(2014, 3, 8);
            int foundClients = 0;

            foreach (PhoneBook phoneBook in phoneBookDataBase)
            {
                if (phoneBook.IsClientByDate(askDate))
                {
                    phoneBook.PrintInfo();
                    foundClients++;
                    Console.WriteLine();
                }
            }
            if (foundClients == 0)
            {
                Console.WriteLine("Клиенты по данной дате не найдены");
            }
            //Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());
        }
    }
}

