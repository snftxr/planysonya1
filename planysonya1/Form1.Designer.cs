namespace planysonya1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenprojectButton = new Button();
            CreateprojectButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // OpenprojectButton
            // 
            OpenprojectButton.Location = new Point(23, 110);
            OpenprojectButton.Margin = new Padding(1, 1, 1, 1);
            OpenprojectButton.Name = "OpenprojectButton";
            OpenprojectButton.Size = new Size(79, 22);
            OpenprojectButton.TabIndex = 0;
            OpenprojectButton.Text = "button1";
            OpenprojectButton.UseVisualStyleBackColor = true;
            OpenprojectButton.Click += OpenprojectButton_Click_1;
            // 
            // CreateprojectButton
            // 
            CreateprojectButton.Location = new Point(23, 152);
            CreateprojectButton.Margin = new Padding(1, 1, 1, 1);
            CreateprojectButton.Name = "CreateprojectButton";
            CreateprojectButton.Size = new Size(79, 22);
            CreateprojectButton.TabIndex = 1;
            CreateprojectButton.Text = "button2";
            CreateprojectButton.UseVisualStyleBackColor = true;
            CreateprojectButton.Click += CreateprojectButton_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 19);
            listBox1.Margin = new Padding(1, 1, 1, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(129, 79);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 228);
            Controls.Add(listBox1);
            Controls.Add(CreateprojectButton);
            Controls.Add(OpenprojectButton);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button OpenprojectButton;
        private Button CreateprojectButton;
        private ListBox listBox1;
        //private EventHandler CreateprojectButton_Click;
        //private EventHandler OpenprojectButton_Click;
    }
}
