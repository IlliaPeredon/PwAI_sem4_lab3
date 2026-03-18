namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate double MathOperation(double n);

        public double Square(double n)
        {
            return n * n;
        }

        public double Square_Root(double n)
        {
            return Math.Sqrt(n);
        }

        public double Reciprocal(double n)
        {
            return 1 / n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(N_place_textBox.Text))
            {
                MessageBox.Show("Please enter a number.");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an action.");
                return;
            }

            if (!double.TryParse(N_place_textBox.Text, out double number))
            {
                MessageBox.Show("Invalid number format.");
                return;
            }

            MathOperation op = null;
            string action = comboBox1.SelectedItem.ToString();

            switch (action)
            {
                case "Square":
                    op = Square;
                    break;
                case "Square root":
                    if (number < 0)
                    {
                        MessageBox.Show("Cannot calculate square root of a negative number.");
                        return;
                    }
                    op = Square_Root;
                    break;
                case "Reciprocal":
                    if (number == 0)
                    {
                        MessageBox.Show("Cannot calculate reciprocal of zero.");
                        return;
                    }
                    op = Reciprocal;
                    break;
            }

            if (op != null)
            {
                double result = op(number);
                Output_textBox.Text = result.ToString();
            }
        }


        // point 3

        private List<double> ProcessCollection(List<double> numbers, MathOperation operation)
        {
            List<double> result = new List<double>();

            foreach (var num in numbers)
            {
                result.Add(operation(num));
            }

            return result;
        }

        private List<double> numbersList = new List<double>();


        private void NumberToListAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(ListNumberAdd_textBox.Text, out double number))
            {
                MessageBox.Show("Invalid number.");
                return;
            }

            numbersList.Add(number);
            listBox1.Items.Add(number);

            ListNumberAdd_textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numbersList.Count == 0)
            {
                MessageBox.Show("List is empty.");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an action.");
                return;
            }

            MathOperation op = null;
            string action = comboBox1.SelectedItem.ToString();

            switch (action)
            {
                case "Square":
                    op = Square;
                    break;

                case "Square root":
                    op = Square_Root;
                    break;

                case "Reciprocal":
                    op = Reciprocal;
                    break;
            }

            if (op == null) return;

            var results = ProcessCollection(numbersList, op);

            listBox2.Items.Clear();

            foreach (var item in results)
            {
                listBox2.Items.Add(item);
            }
        }


        // point 4

        public delegate void UIUpdateDelegate();

        private void ChangeBackgroundColor()
        {
            Test_Subject_Label.BackColor = ColorTranslator.FromHtml(BackGround_Color.Text);
        }

        private void ChangeFontColor()
        {
            Test_Subject_Label.ForeColor = ColorTranslator.FromHtml(Font_Color.Text);
        }

        private void ChangeFontSize()
        {
            if (int.TryParse(Font_Size.Text, out int size))
            {
                Test_Subject_Label.Font = new Font(Test_Subject_Label.Font.FontFamily, size);
            }
        }

        private void Implement_Colors_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BackGround_Color.Text) || 
                string.IsNullOrWhiteSpace(Font_Color.Text) || 
                string.IsNullOrWhiteSpace(Font_Size.Text))
            {
                MessageBox.Show("Please fill all three text fields.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(BackGround_Color.Text, "^#[0-9a-fA-F]{6}$"))
            {
                MessageBox.Show("Background color must be in #ffffff format.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(Font_Color.Text, "^#[0-9a-fA-F]{6}$"))
            {
                MessageBox.Show("Font color must be in #ffffff format.");
                return;
            }

            if (!int.TryParse(Font_Size.Text, out int size) || size <= 0)
            {
                MessageBox.Show("Font size must be a positive integer.");
                return;
            }

            UIUpdateDelegate updateUI = ChangeBackgroundColor;
            updateUI += ChangeFontColor;
            updateUI += ChangeFontSize;

            try
            {
                updateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying styles: " + ex.Message);
            }
        }

        private void BackToNormal_button_Click(object sender, EventArgs e)
        {
            Test_Subject_Label.BackColor = SystemColors.Control;
            Test_Subject_Label.ForeColor = SystemColors.ControlText;
            Test_Subject_Label.Font = new Font(Test_Subject_Label.Font.FontFamily, 9f);
            
            BackGround_Color.Clear();
            Font_Color.Clear();
            Font_Size.Clear();
        }
    }
}
