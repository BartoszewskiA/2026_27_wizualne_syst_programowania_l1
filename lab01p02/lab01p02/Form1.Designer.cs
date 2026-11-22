namespace lab01p02
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(12, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 45);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(231, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 45);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(180, 23);
            label1.Name = "label1";
            label1.Size = new Size(36, 38);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(407, 23);
            label2.Name = "label2";
            label2.Size = new Size(36, 38);
            label2.TabIndex = 3;
            label2.Text = "=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(484, 23);
            label3.Name = "label3";
            label3.Size = new Size(32, 38);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(551, 12);
            button1.Name = "button1";
            button1.Size = new Size(269, 66);
            button1.TabIndex = 5;
            button1.Text = "LICZ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 90);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
