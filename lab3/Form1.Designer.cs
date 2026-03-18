namespace lab3
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            N_place_textBox = new TextBox();
            Output_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ListNumberAdd_textBox = new TextBox();
            ListNumberAdd_button = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Square", "Square root", "Reciprocal" });
            comboBox1.Location = new Point(116, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 40);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 344);
            button1.Name = "button1";
            button1.Size = new Size(173, 75);
            button1.TabIndex = 1;
            button1.Text = "Calculate\r\n Single";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // N_place_textBox
            // 
            N_place_textBox.Location = new Point(12, 173);
            N_place_textBox.Name = "N_place_textBox";
            N_place_textBox.RightToLeft = RightToLeft.Yes;
            N_place_textBox.Size = new Size(173, 39);
            N_place_textBox.TabIndex = 2;
            // 
            // Output_textBox
            // 
            Output_textBox.Location = new Point(12, 274);
            Output_textBox.Name = "Output_textBox";
            Output_textBox.RightToLeft = RightToLeft.Yes;
            Output_textBox.Size = new Size(173, 39);
            Output_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 4;
            label1.Text = "Action";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 127);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 5;
            label2.Text = "Number Single";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 239);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 6;
            label3.Text = "Output Single";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(247, 162);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(157, 292);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(476, 162);
            listBox2.Name = "listBox2";
            listBox2.RightToLeft = RightToLeft.Yes;
            listBox2.Size = new Size(157, 292);
            listBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 127);
            label4.Name = "label4";
            label4.Size = new Size(198, 32);
            label4.TabIndex = 9;
            label4.Text = "Number Multiple";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 127);
            label5.Name = "label5";
            label5.Size = new Size(186, 32);
            label5.TabIndex = 10;
            label5.Text = "Output Multiple";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 459);
            label6.Name = "label6";
            label6.Size = new Size(168, 32);
            label6.TabIndex = 13;
            label6.Text = "Number to list";
            // 
            // ListNumberAdd_textBox
            // 
            ListNumberAdd_textBox.Location = new Point(231, 494);
            ListNumberAdd_textBox.Name = "ListNumberAdd_textBox";
            ListNumberAdd_textBox.RightToLeft = RightToLeft.Yes;
            ListNumberAdd_textBox.Size = new Size(173, 39);
            ListNumberAdd_textBox.TabIndex = 12;
            // 
            // ListNumberAdd_button
            // 
            ListNumberAdd_button.Location = new Point(231, 549);
            ListNumberAdd_button.Name = "ListNumberAdd_button";
            ListNumberAdd_button.Size = new Size(173, 51);
            ListNumberAdd_button.TabIndex = 11;
            ListNumberAdd_button.Text = "Add";
            ListNumberAdd_button.UseVisualStyleBackColor = true;
            ListNumberAdd_button.Click += NumberToListAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(460, 476);
            button2.Name = "button2";
            button2.Size = new Size(173, 75);
            button2.TabIndex = 14;
            button2.Text = "Calculate\r\n Multiple";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 612);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(ListNumberAdd_textBox);
            Controls.Add(ListNumberAdd_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Output_textBox);
            Controls.Add(N_place_textBox);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private TextBox N_place_textBox;
        private TextBox Output_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ListNumberAdd_textBox;
        private Button ListNumberAdd_button;
        private Button button2;
    }
}
