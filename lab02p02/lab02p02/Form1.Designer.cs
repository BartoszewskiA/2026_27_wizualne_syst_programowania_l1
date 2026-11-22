namespace lab02p02
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            hScrollBar1 = new HScrollBar();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 42);
            label1.Name = "label1";
            label1.Size = new Size(508, 263);
            label1.TabIndex = 0;
            label1.Text = "4";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(75, 337);
            label2.Name = "label2";
            label2.Size = new Size(193, 38);
            label2.TabIndex = 1;
            label2.Text = "Rodzaj kostki: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(364, 341);
            label3.Name = "label3";
            label3.Size = new Size(32, 38);
            label3.TabIndex = 2;
            label3.Text = "6";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(471, 337);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 3;
            button1.Text = "Zmień";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(136, 410);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(289, 31);
            hScrollBar1.TabIndex = 4;
            hScrollBar1.Visible = false;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(471, 399);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 5;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 410);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 492);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(hScrollBar1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "KOSTKA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private HScrollBar hScrollBar1;
        private Button button2;
        private Label label4;
    }
}
