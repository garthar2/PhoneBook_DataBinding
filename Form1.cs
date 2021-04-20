using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhoneBook_DataBinding
{
    //   https://www.youtube.com/watch?v=6uSWzKMgbzs binding
    //   https://www.youtube.com/watch?v=8eZy5xiildM using interface
    //   https://www.youtube.com/watch?v=ZDEiR46gDbw Phone book example

    public partial class Form1 : Form
    {
        public BindingList<People> PeopleList { get; set; } = new BindingList<People>();
        public BindingList<Animal> AnimalList { get; set; } = new BindingList<Animal>();
        public Form1()
        {
            InitializeComponent();
            peopleListBindingSource.DataSource = PeopleList;
            animalListBindingSource.DataSource = AnimalList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(PeopleList);
            form2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(AnimalList);
            form3.ShowDialog();
        }
    }

}
