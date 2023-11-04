using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Init_Project
{
    public partial class MainForm : Form
    {
        private List<Person> people;

        public MainForm()
        {
            InitializeComponent();
            people = new List<Person>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //tool strip with event handler method 
            personBindingSource.ListChanged += PersonBindingSource_ListChanged;

            people = GetPersonList();
            personBindingSource.DataSource = people;
        }

        private void PersonBindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {
            toolStripLabelShowPeopleAmount.Text = $"{personBindingSource.Count}"; 
        }

        private List<Person> GetPersonList()
        {
            return new List<Person>
            {
                new Person{FirstName = "Jackson", LastName = "Heng", Gender = "Male", Phone = "0123456789"},
                new Person{FirstName = "Dara", LastName = "Vuth", Gender = "Male", Phone = "0123456789"},
                new Person{FirstName = "Rita", LastName = "Cheata", Gender = "Female", Phone = "098765432"},
            };
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddOrModifyForm form = new AddOrModifyForm();
            form.personBindingSource = this.personBindingSource;
            form.isAddedForm = true;
            form.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            AddOrModifyForm form = new AddOrModifyForm();
            form.personBindingSource = this.personBindingSource;
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(personBindingSource.Count == 0)
            {
                MessageBox.Show("Data is empty! cannot delete...", "Error");
                return; 
            }

            //check confirmation 
            var person = personBindingSource.Current as Person; 
            DialogResult result = MessageBox.Show($"Are you sure to want to delete {person.FirstName} {person.LastName}?",
                "Confirmation", MessageBoxButtons.OKCancel); 

            if(result == DialogResult.OK)
            {
                personBindingSource.RemoveCurrent();
                personBindingSource.EndEdit();
            }
        }
    }
}
