namespace lab05_kasyno
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(34, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 150);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(214, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 150);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(396, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 150);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(512, 47);
            label1.TabIndex = 3;
            label1.Text = "$ 1 000 000 $";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(34, 252);
            button1.Name = "button1";
            button1.Size = new Size(512, 129);
            button1.TabIndex = 4;
            button1.Text = "STOP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(38, 397);
            button2.Name = "button2";
            button2.Size = new Size(304, 34);
            button2.TabIndex = 5;
            button2.Text = "Nowa Gra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(417, 397);
            button3.Name = "button3";
            button3.Size = new Size(129, 34);
            button3.TabIndex = 6;
            button3.Text = "Wypłać";
            button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 2000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
