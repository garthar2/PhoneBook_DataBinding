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
    public partial class Form4 : Form
    {
        //  C:\Users\Андрей\source\repos\PhoneBook_DataBinding\PhoneBookData.xml
        public BindingList<PhoneBook> PhonebookList { get; set; } = new BindingList<PhoneBook>();
        public Form4()
        {
            InitializeComponent();
        }
    }
}
