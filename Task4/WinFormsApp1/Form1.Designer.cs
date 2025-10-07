namespace WinFormsApp1
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
            button1 = new Button();
            textBox1 = new TextBox();
            First_Name = new Label();
            Pass_word = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(85, 158);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // First_Name
            // 
            First_Name.AutoSize = true;
            First_Name.Location = new Point(44, 40);
            First_Name.Name = "First_Name";
            First_Name.Size = new Size(87, 20);
            First_Name.TabIndex = 2;
            First_Name.Text = "Fisrt Name :";
            // 
            // Pass_word
            // 
            Pass_word.AutoSize = true;
            Pass_word.Location = new Point(44, 99);
            Pass_word.Name = "Pass_word";
            Pass_word.Size = new Size(70, 20);
            Pass_word.TabIndex = 4;
            Pass_word.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 229);
            Controls.Add(Pass_word);
            Controls.Add(textBox2);
            Controls.Add(First_Name);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label First_Name;
        private Label Pass_word;
        private TextBox textBox2;
    }
}
