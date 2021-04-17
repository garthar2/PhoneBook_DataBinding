using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneBook_DataBinding
{
    public partial class Form2 : Form
    {
        public BindingList<People> PeopleList { get; set; }
        public BindingList<Animal> AnimalList { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(BindingList<People> peopleList)
        {
            PeopleList = peopleList;
            InitializeComponent();
        }
        public Form2(BindingList<Animal> animalList)
        {
            AnimalList = animalList;
            InitializeComponent();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            PeopleList.Add(new People(firstNameTextBox.Text,
                                      lastNameTextBox.Text,
                                      middleNameTextBox.Text));
        }

    }
}
