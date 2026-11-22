namespace lab03p01
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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            hScrollBar1 = new HScrollBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(55, 46);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(198, 50);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(282, 46);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(198, 50);
            textBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(55, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluta źródłowa";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 142);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(72, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "USD";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "EURO";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "PLN";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(282, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(198, 212);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Waluta docelowa";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(16, 142);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(72, 29);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "USD";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(16, 95);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(83, 29);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "EURO";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(16, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 29);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "PLN";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(55, 387);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(425, 39);
            hScrollBar1.TabIndex = 5;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 460);
            Controls.Add(hScrollBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private HScrollBar hScrollBar1;
    }
}
