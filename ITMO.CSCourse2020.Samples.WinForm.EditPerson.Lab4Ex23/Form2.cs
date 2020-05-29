using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse2020.Samples.WinForm.EditPerson.Lab4Ex23
{
    public partial class EditPersonForm : Form
    {
        public EditPersonForm()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return surnameTextBox.Text; }
            set { surnameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value;  }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditPersonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
