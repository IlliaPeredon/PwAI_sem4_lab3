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
    }
}
