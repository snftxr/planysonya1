namespace planysonya1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            SaveprojectButton = new Button();
            DeleteprojectButton = new Button();
            DeletetaskButton = new Button();
            SavetaskButton = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(20, 12);
            checkedListBox1.Margin = new Padding(1);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(129, 76);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // SaveprojectButton
            // 
            SaveprojectButton.Location = new Point(20, 116);
            SaveprojectButton.Margin = new Padding(1);
            SaveprojectButton.Name = "SaveprojectButton";
            SaveprojectButton.Size = new Size(79, 22);
            SaveprojectButton.TabIndex = 1;
            SaveprojectButton.Text = "button1";
            SaveprojectButton.UseVisualStyleBackColor = true;
            SaveprojectButton.Click += SaveprojectButton_Click_1;
            // 
            // DeleteprojectButton
            // 
            DeleteprojectButton.Location = new Point(121, 116);
            DeleteprojectButton.Margin = new Padding(1);
            DeleteprojectButton.Name = "DeleteprojectButton";
            DeleteprojectButton.Size = new Size(79, 22);
            DeleteprojectButton.TabIndex = 2;
            DeleteprojectButton.Text = "button2";
            DeleteprojectButton.UseVisualStyleBackColor = true;
            DeleteprojectButton.Click += DeleteprojectButton_Click;
            // 
            // DeletetaskButton
            // 
            DeletetaskButton.Location = new Point(20, 154);
            DeletetaskButton.Margin = new Padding(1);
            DeletetaskButton.Name = "DeletetaskButton";
            DeletetaskButton.Size = new Size(79, 22);
            DeletetaskButton.TabIndex = 3;
            DeletetaskButton.Text = "button3";
            DeletetaskButton.UseVisualStyleBackColor = true;
            DeletetaskButton.Click += DeletetaskButton_Click_1;
            // 
            // SavetaskButton
            // 
            SavetaskButton.Location = new Point(121, 154);
            SavetaskButton.Margin = new Padding(1);
            SavetaskButton.Name = "SavetaskButton";
            SavetaskButton.Size = new Size(79, 22);
            SavetaskButton.TabIndex = 4;
            SavetaskButton.Text = "button4";
            SavetaskButton.UseVisualStyleBackColor = true;
            SavetaskButton.Click += SavetaskButton_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 220);
            Controls.Add(SavetaskButton);
            Controls.Add(DeletetaskButton);
            Controls.Add(DeleteprojectButton);
            Controls.Add(SaveprojectButton);
            Controls.Add(checkedListBox1);
            Margin = new Padding(1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button SaveprojectButton;
        private Button DeleteprojectButton;
        private Button DeletetaskButton;
        private Button SavetaskButton;
    }
}