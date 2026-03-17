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
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Square", "Square root", "Reciprocal" });
            comboBox1.Location = new Point(28, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 40);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(28, 159);
            button1.Name = "button1";
            button1.Size = new Size(173, 47);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // N_place_textBox
            // 
            N_place_textBox.Location = new Point(261, 66);
            N_place_textBox.Name = "N_place_textBox";
            N_place_textBox.Size = new Size(173, 39);
            N_place_textBox.TabIndex = 2;
            // 
            // Output_textBox
            // 
            Output_textBox.Location = new Point(261, 167);
            Output_textBox.Name = "Output_textBox";
            Output_textBox.Size = new Size(173, 39);
            Output_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 4;
            label1.Text = "Action";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 31);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 5;
            label2.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 132);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 6;
            label3.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
