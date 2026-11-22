namespace lab04p01_grakolory
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
            panel4 = new Panel();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(36, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 125);
            panel1.TabIndex = 0;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Location = new Point(264, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 125);
            panel2.TabIndex = 0;
            panel2.MouseEnter += panel2_MouseEnter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Location = new Point(36, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 125);
            panel3.TabIndex = 1;
            panel3.MouseEnter += panel3_MouseEnter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(264, 274);
            panel4.Name = "panel4";
            panel4.Size = new Size(125, 125);
            panel4.TabIndex = 2;
            panel4.MouseEnter += panel4_MouseEnter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 521);
            button1.Name = "button1";
            button1.Size = new Size(427, 51);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 460);
            label1.Name = "label1";
            label1.Size = new Size(427, 61);
            label1.TabIndex = 4;
            label1.Text = "Naciśnij START";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(427, 60);
            label2.TabIndex = 5;
            label2.Text = "Licznik trafień:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // timer2
            // 
            timer2.Interval = 30000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 572);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}
