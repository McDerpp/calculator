namespace PracticePractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            add = new Button();
            txtTest = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button15 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            button14 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            add.Location = new Point(214, 176);
            add.Name = "add";
            add.Size = new Size(59, 45);
            add.TabIndex = 0;
            add.Text = "/";
            add.UseVisualStyleBackColor = true;
            add.Click += divide_Click;
            // 
            // txtTest
            // 
            txtTest.Font = new Font("Segoe UI", 25F);
            txtTest.Location = new Point(12, 9);
            txtTest.Name = "txtTest";
            txtTest.ReadOnly = true;
            txtTest.Size = new Size(292, 52);
            txtTest.TabIndex = 3;
            txtTest.TextChanged += txtTest_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(214, 125);
            button1.Name = "button1";
            button1.Size = new Size(59, 45);
            button1.TabIndex = 5;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += subtract_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(214, 77);
            button2.Name = "button2";
            button2.Size = new Size(59, 45);
            button2.TabIndex = 0;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += add_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(214, 227);
            button3.Name = "button3";
            button3.Size = new Size(59, 45);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += multiply_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(149, 227);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(59, 45);
            button4.TabIndex = 10;
            button4.Text = "=";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(149, 125);
            button5.Name = "button5";
            button5.Size = new Size(59, 45);
            button5.TabIndex = 9;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button6_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(149, 77);
            button6.Name = "button6";
            button6.Size = new Size(59, 45);
            button6.TabIndex = 7;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button9_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(149, 176);
            button7.Name = "button7";
            button7.Size = new Size(59, 45);
            button7.TabIndex = 8;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button10.Location = new Point(84, 125);
            button10.Name = "button10";
            button10.Size = new Size(59, 45);
            button10.TabIndex = 11;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button5_Click;
            // 
            // button12
            // 
            button12.AutoSize = true;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button12.Location = new Point(84, 176);
            button12.Name = "button12";
            button12.Size = new Size(59, 45);
            button12.TabIndex = 12;
            button12.Text = "2";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button2_Click;
            // 
            // button13
            // 
            button13.AutoSize = true;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button13.Location = new Point(84, 77);
            button13.Name = "button13";
            button13.Size = new Size(59, 45);
            button13.TabIndex = 11;
            button13.Text = "8";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button8_Click;
            // 
            // button15
            // 
            button15.AutoSize = true;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button15.Location = new Point(84, 227);
            button15.Name = "button15";
            button15.Size = new Size(59, 45);
            button15.TabIndex = 14;
            button15.Text = ".";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button8.Location = new Point(19, 227);
            button8.Name = "button8";
            button8.Size = new Size(59, 45);
            button8.TabIndex = 18;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button0_Click;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button9.Location = new Point(19, 77);
            button9.Name = "button9";
            button9.Size = new Size(59, 45);
            button9.TabIndex = 15;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button7_Click;
            // 
            // button11
            // 
            button11.AutoSize = true;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button11.Location = new Point(19, 176);
            button11.Name = "button11";
            button11.Size = new Size(59, 45);
            button11.TabIndex = 17;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button3_Click;
            // 
            // button14
            // 
            button14.AutoSize = true;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button14.Location = new Point(19, 125);
            button14.Name = "button14";
            button14.Size = new Size(59, 45);
            button14.TabIndex = 16;
            button14.Text = "4";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button4_Click;
            // 
            // button16
            // 
            button16.AutoSize = true;
            button16.BackColor = SystemColors.Info;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(84, 26);
            button16.Margin = new Padding(0);
            button16.Name = "button16";
            button16.Size = new Size(59, 45);
            button16.TabIndex = 19;
            button16.Text = "<-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.AutoSize = true;
            button17.BackColor = SystemColors.Info;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Location = new Point(19, 26);
            button17.Name = "button17";
            button17.Size = new Size(59, 45);
            button17.TabIndex = 21;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.AutoSize = true;
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button18.Location = new Point(149, 26);
            button18.Name = "button18";
            button18.Size = new Size(59, 45);
            button18.TabIndex = 22;
            button18.Text = "(";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.AutoSize = true;
            button19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button19.Location = new Point(214, 26);
            button19.Name = "button19";
            button19.Size = new Size(59, 45);
            button19.TabIndex = 23;
            button19.Text = ")";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(button19);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(add);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 301);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(316, 396);
            Controls.Add(panel1);
            Controls.Add(txtTest);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private TextBox txtTest;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button15;
        private Button button8;
        private Button button9;
        private Button button11;
        private Button button14;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Panel panel1;
    }
}
