using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace planysonya1
{
    public partial class Form1 : Form
    {
        private List<Project> projects;
        public Form1()
        {
            InitializeComponent();
            projects = new List<Project>();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenprojectButton_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateprojectButton_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
        public void AddProjectToList(Project project)
        {
            // добавление проекта на форм1
            listBox1.Items.Add(project);
            //обновление списка
            RefreshlistBox1();
        }

        private void RefreshlistBox1()
        {
            //обновление списка (удаление и добавление заново)
            listBox1.Items.Clear();
            foreach (Project project in listBox1.Items)
            {
                listBox1.Items.Add(project.Name);
            }
        }
    }
}


