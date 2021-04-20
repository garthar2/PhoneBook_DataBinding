using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhoneBook_DataBinding
{
    public partial class Form3 : Form
    {
        public BindingList<Animal> AnimalList { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(BindingList<Animal> animalList)
        {
            AnimalList = animalList;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalList.Add(new Animal(breedTextBox.Text, colorTextBox.Text, weightTextBox.Text));
        }
    }
}
