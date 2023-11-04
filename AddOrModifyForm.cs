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
    public partial class AddOrModifyForm : Form
    {
        public BindingSource personBindingSource;
        public bool isAddedForm; 

        public AddOrModifyForm()
        {
            InitializeComponent();
            personBindingSource = new BindingSource();
        }

        private void AddOrModifyForm_Load(object sender, EventArgs e)
        { 
            if (this.isAddedForm)
            {
                lblTitle.Text = "Add New Person";
                cbGender.SelectedIndex = 0;

                txtFirstName.Focus();
            }
            else
            {
                var person = personBindingSource.Current as Person;
                lblTitle.Text = $"Modify : {person.FirstName} {person.LastName}";
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                cbGender.SelectedItem = person.Gender;
                txtPhone.Text = person.Phone;

                btnAccept.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private bool IsValidTextBox(TextBox textBox, string name)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{name} is required!", "Error"); 
                return false; 
            }
            return true; 
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(IsValidTextBox(txtFirstName, "First name") &&
               IsValidTextBox(txtLastName, "Last name") &&
               IsValidTextBox(txtPhone, "Phone")) 
                if (this.isAddedForm)
                {
                    personBindingSource.AddNew();
                    var person = personBindingSource.Current as Person;
                    PutData(person);
                    personBindingSource.EndEdit();

                    ClearText();
                }
                else
                {
                    var person = personBindingSource.Current as Person;
                    PutData(person);
                    personBindingSource.EndEdit();
                    personBindingSource.ResetCurrentItem();

                    Close();
                }
        }

        private void PutData(Person person)
        {
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Gender = cbGender.Text;
            person.Phone = txtPhone.Text;
        }

        private void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cbGender.SelectedIndex = 0;
            txtPhone.Clear();
        }
    }
}
