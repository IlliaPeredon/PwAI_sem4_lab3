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
        private UIUpdateDelegate builtUpdateUI;
        private string colorToImplement;
        private string fontColorToImplement;
        private int fontSizeToImplement;

        private void ChangeBackgroundColor()
        {
            this.BackColor = ColorTranslator.FromHtml(colorToImplement);
        }

        private void ChangeFontColor()
        {
            Test_Subject_Label.ForeColor = ColorTranslator.FromHtml(fontColorToImplement);
        }

        private void ChangeFontSize()
        {
            Test_Subject_Label.Font = new Font(Test_Subject_Label.Font.FontFamily, fontSizeToImplement);
        }

        private void Build_button_Click(object sender, EventArgs e)
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

            colorToImplement = BackGround_Color.Text;
            fontColorToImplement = Font_Color.Text;
            fontSizeToImplement = size;

            builtUpdateUI = ChangeBackgroundColor;
            builtUpdateUI += ChangeFontColor;
            builtUpdateUI += ChangeFontSize;

            MessageBox.Show("Changes built successfully! You can now implement them.");
        }

        private void Implement_Colors_Button_Click(object sender, EventArgs e)
        {
            if (builtUpdateUI == null)
            {
                MessageBox.Show("Please build the changes first.");
                return;
            }

            try
            {
                builtUpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying styles: " + ex.Message);
            }
        }

        private void BackToNormal_button_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            Test_Subject_Label.ForeColor = SystemColors.ControlText;
            Test_Subject_Label.Font = new Font(Test_Subject_Label.Font.FontFamily, 9f);

            BackGround_Color.Clear();
            Font_Color.Clear();
            Font_Size.Clear();

            builtUpdateUI = null;
        }

        // point 5 and 6

        public struct MixedItem : IComparable<MixedItem>
        {
            public string OriginalText;
            public double NumberValue;
            public bool IsNumber;

            public MixedItem(string text)
            {
                OriginalText = text;
                IsNumber = double.TryParse(text, out NumberValue);
            }

            public int CompareTo(MixedItem other)
            {
                if (this.IsNumber && other.IsNumber)
                {
                    return this.NumberValue.CompareTo(other.NumberValue);
                }
                if (this.IsNumber && !other.IsNumber)
                {
                    return -1; // Numbers first
                }
                if (!this.IsNumber && other.IsNumber)
                {
                    return 1; // Strings after numbers
                }
                
                // if both are strings. Sort alphabetically.
                return string.Compare(this.OriginalText, other.OriginalText, StringComparison.OrdinalIgnoreCase);
            }

            public override string ToString()
            {
                return OriginalText;
            }
        }

        public delegate List<T> SortDelegate<T>(List<T> list);

        private List<T> BubbleSort<T>(List<T> list) where T : IComparable<T>
        {
            List<T> sorted = new List<T>(list); // copy list

            for (int i = 0; i < sorted.Count - 1; i++)
            {
                for (int j = 0; j < sorted.Count - i - 1; j++)
                {
                    if (sorted[j].CompareTo(sorted[j + 1]) > 0)
                    {
                        T temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }

        private List<MixedItem> sortMixedList = new List<MixedItem>();

        private void AddToSortList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a value.");
                return;
            }

            var item = new MixedItem(textBox1.Text);
            sortMixedList.Add(item);
            listBox3.Items.Add(item);

            textBox1.Clear();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (sortMixedList.Count == 0)
            {
                MessageBox.Show("List is empty.");
                return;
            }

            SortDelegate<MixedItem> sorter = BubbleSort;

            var sortedList = sorter(sortMixedList);

            listBox4.Items.Clear();

            foreach (var item in sortedList)
            {
                listBox4.Items.Add(item);
            }
        }
    }
}
