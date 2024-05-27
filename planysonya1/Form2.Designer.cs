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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(57, 277);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(361, 220);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // SaveprojectButton
            // 
            SaveprojectButton.Location = new Point(57, 503);
            SaveprojectButton.Name = "SaveprojectButton";
            SaveprojectButton.Size = new Size(226, 70);
            SaveprojectButton.TabIndex = 1;
            SaveprojectButton.Text = "button1";
            SaveprojectButton.UseVisualStyleBackColor = true;
            SaveprojectButton.Click += SaveprojectButton_Click_1;
            // 
            // DeleteprojectButton
            // 
            DeleteprojectButton.Location = new Point(335, 503);
            DeleteprojectButton.Name = "DeleteprojectButton";
            DeleteprojectButton.Size = new Size(226, 70);
            DeleteprojectButton.TabIndex = 2;
            DeleteprojectButton.Text = "button2";
            DeleteprojectButton.UseVisualStyleBackColor = true;
            DeleteprojectButton.Click += DeleteprojectButton_Click;
            // 
            // DeletetaskButton
            // 
            DeletetaskButton.Location = new Point(57, 604);
            DeletetaskButton.Name = "DeletetaskButton";
            DeletetaskButton.Size = new Size(226, 70);
            DeletetaskButton.TabIndex = 3;
            DeletetaskButton.Text = "button3";
            DeletetaskButton.UseVisualStyleBackColor = true;
            DeletetaskButton.Click += DeletetaskButton_Click_1;
            // 
            // SavetaskButton
            // 
            SavetaskButton.Location = new Point(335, 604);
            SavetaskButton.Name = "SavetaskButton";
            SavetaskButton.Size = new Size(226, 70);
            SavetaskButton.TabIndex = 4;
            SavetaskButton.Text = "button4";
            SavetaskButton.UseVisualStyleBackColor = true;
            SavetaskButton.Click += SavetaskButton_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 55);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 116);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(504, 134);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1863, 704);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SavetaskButton);
            Controls.Add(DeletetaskButton);
            Controls.Add(DeleteprojectButton);
            Controls.Add(SaveprojectButton);
            Controls.Add(checkedListBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button SaveprojectButton;
        private Button DeleteprojectButton;
        private Button DeletetaskButton;
        private Button SavetaskButton;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}