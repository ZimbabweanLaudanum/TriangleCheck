namespace TriangleCheck
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(141, 54);
            label1.Name = "label1";
            label1.Size = new Size(514, 45);
            label1.TabIndex = 0;
            label1.Text = "Введите стороны треугольника";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 0);
            textBox1.Font = new Font("Comic Sans MS", 24F);
            textBox1.ForeColor = Color.Purple;
            textBox1.Location = new Point(89, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 52);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Font = new Font("Comic Sans MS", 24F);
            textBox2.ForeColor = Color.Purple;
            textBox2.Location = new Point(308, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 52);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 128, 0);
            textBox3.Font = new Font("Comic Sans MS", 24F);
            textBox3.ForeColor = Color.Purple;
            textBox3.Location = new Point(527, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 52);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(302, 311);
            button1.Name = "button1";
            button1.Size = new Size(196, 61);
            button1.TabIndex = 4;
            button1.Text = "ВВЕСТИ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Triangle Chcek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}
