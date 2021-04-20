using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace PhoneBook_DataBinding
{
    public partial class Form4 : Form
    {
        //  C:\Users\Андрей\source\repos\PhoneBook_DataBinding\PhoneBookData.xml
        public BindingList<PhoneBook> PhonebookList { get; set; } = new BindingList<PhoneBook>();
        private void InitializePhonebookList()
        {
            // Create the new BindingList of Part type.
            PhonebookList = new BindingList<PhoneBook>();

            // Allow new parts to be added, but not removed once committed.        
            PhonebookList.AllowNew = true;
            PhonebookList.AllowRemove = false;

            // Raise ListChanged events when new parts are added.
            PhonebookList.RaiseListChangedEvents = true;

            // Do not allow parts to be edited.
            PhonebookList.AllowEdit = false;

            // Add a couple of parts to the list.
            PhonebookList.Add(new Credentials("Колян", "Петров", "Иванович", true, new DateTime(1945, 10, 6)));
            PhonebookList.Add(new Credentials("Васян", "Дачев", "Бедросович", false, new DateTime(1967, 12, 12)));
        }

        //public BindingList<PhoneInfo> PhoneBooks { get; set; } = new BindingList<PhoneInfo>();


        //public BindingList<PhoneBook> PhoneBooks { get; set; } = new BindingList<PhoneBook>();
        public Form4()
        {
            InitializePhonebookList();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhonebookList.Add(new Credentials("Колян", "Петров", "Иванович", true, new DateTime(1945, 10, 6)));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhonebookList.Add(new Credentials(Name, "", "", true, new DateTime(1945, 1, 1)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhonebookList.Add(new Credentials(firstNameTextBox.Text, lastNameTextBox.Text, middleNameTextBox.Text, true,
                new DateTime(1945, 10, 6)));
        }
    }
}
