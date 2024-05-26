using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace planysonya1
{
    public partial class Form1 : Form
    {
        //private List<Project> projects;
        public Form1()
        {
            InitializeComponent();
            //projects = new List<Project>();
        }
        private void OpenprojectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateprojectButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

    
