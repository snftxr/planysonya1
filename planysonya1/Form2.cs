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
            Project.Name = Name.Text;
            Project.Tasks.Clear();
            foreach (string task in checkedListBox1.CheckedItems)
            {
                Project.Tasks.Add(task);
            }
            this.Close(); 
        }

        private void SavetaskButton_Click_1(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(Task.Text, true);
            Task.Clear();
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
    }
}





