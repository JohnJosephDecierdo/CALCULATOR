namespace Calculator
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
            textBox1_Result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            Clear = new Button();
            button17 = new Button();
            backspace = new Button();
            LabelCurrentOperation = new Label();
            label1 = new Label();
            button16 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1_Result
            // 
            textBox1_Result.BackColor = SystemColors.InfoText;
            textBox1_Result.Font = new Font("Segoe UI", 20F);
            textBox1_Result.ForeColor = SystemColors.Window;
            textBox1_Result.Location = new Point(9, 45);
            textBox1_Result.Name = "textBox1_Result";
            textBox1_Result.Size = new Size(330, 43);
            textBox1_Result.TabIndex = 0;
            textBox1_Result.TextAlign = HorizontalAlignment.Right;
            textBox1_Result.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(7, 117);
            button1.Name = "button1";
            button1.Size = new Size(60, 65);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Moccasin;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(73, 117);
            button2.Name = "button2";
            button2.Size = new Size(60, 65);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button9_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Moccasin;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(139, 117);
            button3.Name = "button3";
            button3.Size = new Size(60, 65);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightYellow;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(205, 198);
            button4.Name = "button4";
            button4.Size = new Size(60, 65);
            button4.TabIndex = 4;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operator_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Moccasin;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 10F);
            button5.Location = new Point(7, 198);
            button5.Name = "button5";
            button5.Size = new Size(60, 65);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Moccasin;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 10F);
            button6.Location = new Point(73, 198);
            button6.Name = "button6";
            button6.Size = new Size(60, 65);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Moccasin;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 10F);
            button7.Location = new Point(139, 198);
            button7.Name = "button7";
            button7.Size = new Size(60, 65);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightYellow;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 10F);
            button8.Location = new Point(205, 280);
            button8.Name = "button8";
            button8.Size = new Size(60, 65);
            button8.TabIndex = 8;
            button8.Text = "x";
            button8.UseVisualStyleBackColor = false;
            button8.Click += operator_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Moccasin;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI", 10F);
            button9.Location = new Point(7, 282);
            button9.Name = "button9";
            button9.Size = new Size(60, 65);
            button9.TabIndex = 9;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Moccasin;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 10F);
            button10.Location = new Point(73, 282);
            button10.Name = "button10";
            button10.Size = new Size(60, 65);
            button10.TabIndex = 10;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button9_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Moccasin;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Segoe UI", 10F);
            button11.Location = new Point(139, 282);
            button11.Name = "button11";
            button11.Size = new Size(60, 65);
            button11.TabIndex = 11;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button9_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.LightYellow;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Segoe UI", 10F);
            button12.Location = new Point(205, 367);
            button12.Name = "button12";
            button12.Size = new Size(60, 65);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += operator_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Moccasin;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Segoe UI", 10F);
            button13.Location = new Point(7, 367);
            button13.Name = "button13";
            button13.Size = new Size(126, 65);
            button13.TabIndex = 13;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button9_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Moccasin;
            button14.FlatStyle = FlatStyle.Popup;
            button14.Font = new Font("Segoe UI", 10F);
            button14.Location = new Point(139, 367);
            button14.Name = "button14";
            button14.Size = new Size(60, 65);
            button14.TabIndex = 14;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button9_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.LightYellow;
            button15.FlatStyle = FlatStyle.Popup;
            button15.Font = new Font("Segoe UI", 10F);
            button15.Location = new Point(205, 117);
            button15.Name = "button15";
            button15.Size = new Size(60, 65);
            button15.TabIndex = 15;
            button15.Text = "+";
            button15.UseVisualStyleBackColor = false;
            button15.Click += operator_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Gainsboro;
            Clear.FlatStyle = FlatStyle.Popup;
            Clear.Font = new Font("Segoe UI", 10F);
            Clear.Location = new Point(277, 367);
            Clear.Name = "Clear";
            Clear.Size = new Size(60, 65);
            Clear.TabIndex = 16;
            Clear.Text = "CLEAR";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += button16_Click_1;
            // 
            // button17
            // 
            button17.BackColor = Color.Gainsboro;
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Segoe UI", 10F);
            button17.Location = new Point(277, 280);
            button17.Name = "button17";
            button17.Size = new Size(60, 67);
            button17.TabIndex = 17;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // backspace
            // 
            backspace.BackColor = Color.Gainsboro;
            backspace.FlatStyle = FlatStyle.Popup;
            backspace.Font = new Font("Segoe UI", 10F);
            backspace.Location = new Point(277, 117);
            backspace.Name = "backspace";
            backspace.Size = new Size(60, 65);
            backspace.TabIndex = 18;
            backspace.Text = "⌫";
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += button18_Click;
            // 
            // LabelCurrentOperation
            // 
            LabelCurrentOperation.AutoSize = true;
            LabelCurrentOperation.Font = new Font("Segoe UI", 17F);
            LabelCurrentOperation.ForeColor = SystemColors.ControlDark;
            LabelCurrentOperation.Location = new Point(20, 9);
            LabelCurrentOperation.Name = "LabelCurrentOperation";
            LabelCurrentOperation.Size = new Size(0, 31);
            LabelCurrentOperation.TabIndex = 19;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(330, 26);
            label1.TabIndex = 21;
            label1.Click += label1_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Gainsboro;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Segoe UI", 10F);
            button16.Location = new Point(278, 198);
            button16.Name = "button16";
            button16.Size = new Size(60, 65);
            button16.TabIndex = 22;
            button16.Text = "+/-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += buttonNegate_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(backspace);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(Clear);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(textBox1_Result);
            panel1.Location = new Point(12, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 458);
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(365, 499);
            Controls.Add(LabelCurrentOperation);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
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

        private TextBox textBox1_Result;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button Clear;
        private Button button17;
        private Button backspace;
        private Label LabelCurrentOperation;
        private Label label1;
        private Button button16;
        private Panel panel1;
    }
}
