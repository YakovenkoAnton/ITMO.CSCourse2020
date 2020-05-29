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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditPersonForm editForm = new EditPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count == 0)
                return;
            ListViewItem item = personListView.SelectedItems[0];
            EditPersonForm editForm = new EditPersonForm();
            
            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();


        }
    }
}
