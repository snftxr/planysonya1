using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace planysonya1
{
    public partial class Form2 : Form
    {
        private Project project;

        public object Project { get; private set; }

        public Form2()
        {
            InitializeComponent();
            project = new Project();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveprojectButton_Click_1(object sender, EventArgs e)
        {
            /* Project.Name = textBox1.Text;
            Project.Tasks.Clear();
            foreach (string task in checkedListBox1.CheckedItems)
            {
                Project.Tasks.Add(task);
            }
            this.Close(); */


            Project project = new Project();
            project.Name = TextBox1.Text;
            //project.Description = TextBox2.Text;
            //сохранение

            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                form1.AddProjectToList(project);
            }
            this.Close();
        }

        private void SavetaskButton_Click_1(object sender, EventArgs e)
        {
            //checkedListBox1.Items.Add(Task.Text, true);
            //Task.Clear();

            string task = TextBox2.Text;
            if (!string.IsNullOrEmpty(task))
            {
                checkedListBox1.Items.Add(task);
                TextBox2.Clear();
            }
        }

        private void DeletetaskButton_Click_1(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }

        private void DeleteprojectButton_Click(object sender, EventArgs e)
        {
            Project = null;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //name
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //задача
        }
    }
    //private System.Windows.Forms.TextBox? TextBox2;

}





