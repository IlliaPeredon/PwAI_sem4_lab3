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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Test_Subject_Label = new Label();
            Font_Color = new TextBox();
            label11 = new Label();
            label10 = new Label();
            Font_Size = new TextBox();
            label12 = new Label();
            BackGround_Color = new TextBox();
            label13 = new Label();
            Implement_Colors_Button = new Button();
            BackToNormal_button = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label14 = new Label();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label15 = new Label();
            textBox1 = new TextBox();
            AddToSortList_button = new Button();
            Sorting_button = new Button();
            label16 = new Label();
            label17 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Square", "Square root", "Reciprocal" });
            comboBox1.Location = new Point(181, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 40);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(173, 75);
            button1.TabIndex = 1;
            button1.Text = "Calculate\r\n Single";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // N_place_textBox
            // 
            N_place_textBox.Location = new Point(12, 162);
            N_place_textBox.Name = "N_place_textBox";
            N_place_textBox.RightToLeft = RightToLeft.Yes;
            N_place_textBox.Size = new Size(173, 39);
            N_place_textBox.TabIndex = 2;
            // 
            // Output_textBox
            // 
            Output_textBox.Location = new Point(12, 263);
            Output_textBox.Name = "Output_textBox";
            Output_textBox.RightToLeft = RightToLeft.Yes;
            Output_textBox.Size = new Size(173, 39);
            Output_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 4;
            label1.Text = "Action";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 116);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 5;
            label2.Text = "Number Single";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 228);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 6;
            label3.Text = "Output Single";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(247, 151);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(157, 292);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(460, 152);
            listBox2.Name = "listBox2";
            listBox2.RightToLeft = RightToLeft.Yes;
            listBox2.Size = new Size(157, 292);
            listBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 116);
            label4.Name = "label4";
            label4.Size = new Size(198, 32);
            label4.TabIndex = 9;
            label4.Text = "Number Multiple";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 116);
            label5.Name = "label5";
            label5.Size = new Size(186, 32);
            label5.TabIndex = 10;
            label5.Text = "Output Multiple";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 448);
            label6.Name = "label6";
            label6.Size = new Size(168, 32);
            label6.TabIndex = 13;
            label6.Text = "Number to list";
            // 
            // ListNumberAdd_textBox
            // 
            ListNumberAdd_textBox.Location = new Point(231, 483);
            ListNumberAdd_textBox.Name = "ListNumberAdd_textBox";
            ListNumberAdd_textBox.RightToLeft = RightToLeft.Yes;
            ListNumberAdd_textBox.Size = new Size(173, 39);
            ListNumberAdd_textBox.TabIndex = 12;
            // 
            // ListNumberAdd_button
            // 
            ListNumberAdd_button.Location = new Point(231, 538);
            ListNumberAdd_button.Name = "ListNumberAdd_button";
            ListNumberAdd_button.Size = new Size(173, 51);
            ListNumberAdd_button.TabIndex = 11;
            ListNumberAdd_button.Text = "Add";
            ListNumberAdd_button.UseVisualStyleBackColor = true;
            ListNumberAdd_button.Click += NumberToListAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(460, 465);
            button2.Name = "button2";
            button2.Size = new Size(157, 75);
            button2.TabIndex = 14;
            button2.Text = "Calculate\r\n Multiple";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 56);
            label7.Name = "label7";
            label7.Size = new Size(117, 32);
            label7.TabIndex = 15;
            label7.Text = "Point 3 UI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 56);
            label8.Name = "label8";
            label8.Size = new Size(117, 32);
            label8.TabIndex = 16;
            label8.Text = "Point 2 UI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(150, 56);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 17;
            label9.Text = "Point 4 UI";
            // 
            // Test_Subject_Label
            // 
            Test_Subject_Label.AutoSize = true;
            Test_Subject_Label.BorderStyle = BorderStyle.Fixed3D;
            Test_Subject_Label.Location = new Point(228, 207);
            Test_Subject_Label.Name = "Test_Subject_Label";
            Test_Subject_Label.Size = new Size(121, 34);
            Test_Subject_Label.TabIndex = 18;
            Test_Subject_Label.Text = "Test Label";
            // 
            // Font_Color
            // 
            Font_Color.Location = new Point(13, 152);
            Font_Color.Name = "Font_Color";
            Font_Color.RightToLeft = RightToLeft.No;
            Font_Color.Size = new Size(173, 39);
            Font_Color.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 117);
            label11.Name = "label11";
            label11.Size = new Size(126, 32);
            label11.TabIndex = 20;
            label11.Text = "Font Color";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 344);
            label10.Name = "label10";
            label10.Size = new Size(112, 32);
            label10.TabIndex = 22;
            label10.Text = "Font Size";
            // 
            // Font_Size
            // 
            Font_Size.Location = new Point(13, 391);
            Font_Size.Name = "Font_Size";
            Font_Size.RightToLeft = RightToLeft.No;
            Font_Size.Size = new Size(173, 39);
            Font_Size.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 228);
            label12.Name = "label12";
            label12.Size = new Size(201, 32);
            label12.TabIndex = 24;
            label12.Text = "Background color";
            // 
            // BackGround_Color
            // 
            BackGround_Color.Location = new Point(13, 273);
            BackGround_Color.Name = "BackGround_Color";
            BackGround_Color.RightToLeft = RightToLeft.No;
            BackGround_Color.Size = new Size(173, 39);
            BackGround_Color.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 465);
            label13.Name = "label13";
            label13.Size = new Size(289, 128);
            label13.TabIndex = 25;
            label13.Text = "Please write a #ffffff type \r\nof color in *Color*\r\nYou can use numbers 1-9\r\n and letters a-f\r\n";
            // 
            // Implement_Colors_Button
            // 
            Implement_Colors_Button.Location = new Point(228, 309);
            Implement_Colors_Button.Name = "Implement_Colors_Button";
            Implement_Colors_Button.Size = new Size(173, 51);
            Implement_Colors_Button.TabIndex = 26;
            Implement_Colors_Button.Text = "Implement";
            Implement_Colors_Button.UseVisualStyleBackColor = true;
            Implement_Colors_Button.Click += Implement_Colors_Button_Click;
            // 
            // BackToNormal_button
            // 
            BackToNormal_button.Location = new Point(228, 379);
            BackToNormal_button.Name = "BackToNormal_button";
            BackToNormal_button.Size = new Size(173, 51);
            BackToNormal_button.TabIndex = 27;
            BackToNormal_button.Text = "Set to normal";
            BackToNormal_button.UseVisualStyleBackColor = true;
            BackToNormal_button.Click += BackToNormal_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(BackToNormal_button);
            groupBox1.Controls.Add(Implement_Colors_Button);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(BackGround_Color);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Font_Size);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(Font_Color);
            groupBox1.Controls.Add(Test_Subject_Label);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(674, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 609);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(ListNumberAdd_textBox);
            groupBox2.Controls.Add(ListNumberAdd_button);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Output_textBox);
            groupBox2.Controls.Add(N_place_textBox);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 609);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(138, 35);
            label14.Name = "label14";
            label14.Size = new Size(117, 32);
            label14.TabIndex = 28;
            label14.Text = "Point 5 UI";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(20, 136);
            listBox3.Name = "listBox3";
            listBox3.RightToLeft = RightToLeft.Yes;
            listBox3.Size = new Size(157, 292);
            listBox3.TabIndex = 17;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(200, 135);
            listBox4.Name = "listBox4";
            listBox4.RightToLeft = RightToLeft.Yes;
            listBox4.Size = new Size(157, 292);
            listBox4.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(4, 459);
            label15.Name = "label15";
            label15.Size = new Size(168, 32);
            label15.TabIndex = 17;
            label15.Text = "Number to list";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 494);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(173, 39);
            textBox1.TabIndex = 17;
            // 
            // AddToSortList_button
            // 
            AddToSortList_button.Location = new Point(6, 540);
            AddToSortList_button.Name = "AddToSortList_button";
            AddToSortList_button.Size = new Size(173, 47);
            AddToSortList_button.TabIndex = 17;
            AddToSortList_button.Text = "Add";
            AddToSortList_button.UseVisualStyleBackColor = true;
            AddToSortList_button.Click += AddToSortList_Click;
            // 
            // Sorting_button
            // 
            Sorting_button.Location = new Point(200, 476);
            Sorting_button.Name = "Sorting_button";
            Sorting_button.Size = new Size(157, 75);
            Sorting_button.TabIndex = 17;
            Sorting_button.Text = "Sort";
            Sorting_button.UseVisualStyleBackColor = true;
            Sorting_button.Click += Sort_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(61, 86);
            label16.Name = "label16";
            label16.Size = new Size(111, 32);
            label16.TabIndex = 17;
            label16.Text = "Unsorted";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(214, 86);
            label17.Name = "label17";
            label17.Size = new Size(84, 32);
            label17.TabIndex = 31;
            label17.Text = "Sorted";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(Sorting_button);
            groupBox3.Controls.Add(AddToSortList_button);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(listBox4);
            groupBox3.Controls.Add(listBox3);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(1116, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 609);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 656);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Laboratorium 3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label Test_Subject_Label;
        private TextBox Font_Color;
        private Label label11;
        private Label label10;
        private TextBox Font_Size;
        private Label label12;
        private TextBox BackGround_Color;
        private Label label13;
        private Button Implement_Colors_Button;
        private Button BackToNormal_button;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label14;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label15;
        private TextBox textBox1;
        private Button AddToSortList_button;
        private Button Sorting_button;
        private Label label16;
        private Label label17;
        private GroupBox groupBox3;
    }
}
