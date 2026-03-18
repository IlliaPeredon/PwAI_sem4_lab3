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


    }
}
