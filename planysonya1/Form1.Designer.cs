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
            OpenprojectButton.Location = new Point(66, 352);
            OpenprojectButton.Name = "OpenprojectButton";
            OpenprojectButton.Size = new Size(225, 69);
            OpenprojectButton.TabIndex = 0;
            OpenprojectButton.Text = "button1";
            OpenprojectButton.UseVisualStyleBackColor = true;
            // 
            // CreateprojectButton
            // 
            CreateprojectButton.Location = new Point(66, 485);
            CreateprojectButton.Name = "CreateprojectButton";
            CreateprojectButton.Size = new Size(225, 69);
            CreateprojectButton.TabIndex = 1;
            CreateprojectButton.Text = "button2";
            CreateprojectButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(66, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 244);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2348, 730);
            Controls.Add(listBox1);
            Controls.Add(CreateprojectButton);
            Controls.Add(OpenprojectButton);
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
