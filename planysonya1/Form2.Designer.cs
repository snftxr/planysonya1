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
            checkedListBox1.Location = new Point(20, 87);
            checkedListBox1.Margin = new Padding(1, 1, 1, 1);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(129, 58);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // SaveprojectButton
            // 
            SaveprojectButton.BackColor = Color.FromArgb(192, 255, 255);
            SaveprojectButton.Location = new Point(20, 157);
            SaveprojectButton.Margin = new Padding(1, 1, 1, 1);
            SaveprojectButton.Name = "SaveprojectButton";
            SaveprojectButton.Size = new Size(129, 30);
            SaveprojectButton.TabIndex = 1;
            SaveprojectButton.Text = "сохранить проект";
            SaveprojectButton.UseVisualStyleBackColor = false;
            SaveprojectButton.Click += SaveprojectButton_Click_1;
            // 
            // DeleteprojectButton
            // 
            DeleteprojectButton.BackColor = Color.FromArgb(192, 255, 255);
            DeleteprojectButton.Location = new Point(151, 157);
            DeleteprojectButton.Margin = new Padding(1, 1, 1, 1);
            DeleteprojectButton.Name = "DeleteprojectButton";
            DeleteprojectButton.Size = new Size(129, 30);
            DeleteprojectButton.TabIndex = 2;
            DeleteprojectButton.Text = "удалить проект";
            DeleteprojectButton.UseVisualStyleBackColor = false;
            DeleteprojectButton.Click += DeleteprojectButton_Click;
            // 
            // DeletetaskButton
            // 
            DeletetaskButton.BackColor = Color.FromArgb(192, 255, 255);
            DeletetaskButton.Location = new Point(20, 189);
            DeletetaskButton.Margin = new Padding(1, 1, 1, 1);
            DeletetaskButton.Name = "DeletetaskButton";
            DeletetaskButton.Size = new Size(129, 30);
            DeletetaskButton.TabIndex = 3;
            DeletetaskButton.Text = "удалить задачу";
            DeletetaskButton.UseVisualStyleBackColor = false;
            DeletetaskButton.Click += DeletetaskButton_Click_1;
            // 
            // SavetaskButton
            // 
            SavetaskButton.BackColor = Color.FromArgb(192, 255, 255);
            SavetaskButton.Location = new Point(151, 189);
            SavetaskButton.Margin = new Padding(1, 1, 1, 1);
            SavetaskButton.Name = "SavetaskButton";
            SavetaskButton.Size = new Size(129, 30);
            SavetaskButton.TabIndex = 4;
            SavetaskButton.Text = "сохранить задачу";
            SavetaskButton.UseVisualStyleBackColor = false;
            SavetaskButton.Click += SavetaskButton_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 11);
            textBox1.Margin = new Padding(1, 1, 1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 36);
            textBox2.Margin = new Padding(1, 1, 1, 1);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 45);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(673, 228);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SavetaskButton);
            Controls.Add(DeletetaskButton);
            Controls.Add(DeleteprojectButton);
            Controls.Add(SaveprojectButton);
            Controls.Add(checkedListBox1);
            Margin = new Padding(1, 1, 1, 1);
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