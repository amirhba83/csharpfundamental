using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SignUpForm;

public partial class Form2 : Form
{
    List<Person> people;
    public Form2()
    {
        InitializeComponent();
        people = new List<Person>();
        dataGridView1.DataSource = people;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Person p1 = new Person()
        {
            Name = nameTextBox.Text,
            LastName = lastNameTextBox.Text,
            PhoneNumber = phoneTextBox.Text,
            Adress = adressTextBox.Text
        };
        
        people.Add(p1);
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = people;
        dataGridView1.Refresh();
        nameTextBox.Text = string.Empty;
        lastNameTextBox.Text = string.Empty;
        phoneTextBox.Text = string.Empty;
        adressTextBox.Text = string.Empty;


    }
}
internal class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Adress { get; set; }
}