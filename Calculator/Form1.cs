using System.DirectoryServices.ActiveDirectory;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = ((Button)sender).Text;
                return;
            }
            TryAddSymbol(sender);
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            TryAddSymbol(sender);
        }

        private void TryAddSymbol(object sender)
        {
            if (((Button)sender).Text == ",")
            {
                string[] numbers = label1.Text.Split(Checker.operations);
                if (numbers.Last() == "")
                    label1.Text += "0,";
                return;
            }
            if (Checker.CanAddSymbol(label1.Text, ((Button)sender).Text[0]))
                label1.Text += ((Button)sender).Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            label1.Text = Calculate();
        }

        private string Calculate()
        {
            List<string> numbers = label1.Text.Split(Checker.operations).ToList();
            List<char> operations = label1.Text.Where(symbol => !char.IsNumber(symbol) && symbol != ',').ToList();
            if (numbers.Last() == "")
            {
                numbers.RemoveAt(numbers.Count - 1);
                operations.RemoveAt(operations.Count - 1);
            }
            for (int i = 0; i < operations.Count;)
            {
                if (operations[i] == '*')
                {
                    numbers[i] = (double.Parse(numbers[i]) * double.Parse(numbers[i + 1])).ToString();
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    continue;
                }
                if (operations[i] == '/')
                {
                    numbers[i] = (double.Parse(numbers[i]) / double.Parse(numbers[i + 1])).ToString();
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    continue;
                }
                i++;
            }

            for (int i = 0; i < operations.Count;)
            {
                if (operations[i] == '+')
                {
                    numbers[i] = (double.Parse(numbers[i]) + double.Parse(numbers[i + 1])).ToString();
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    continue;
                }
                if (operations[i] == '-')
                {
                    numbers[i] = (double.Parse(numbers[i]) - double.Parse(numbers[i + 1])).ToString();
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    continue;
                }
                i++;
            }

            return numbers[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            if (label1.Text == "")
                label1.Text = "0";
        }
    }
}