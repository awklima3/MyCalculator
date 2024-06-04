namespace MyFirstWinForm
{
    public partial class CalculatorForm : Form
    {
        float currentValue;

        Operation currentOperation;


        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {

            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtDisplay.Text, out float displayValue))
            {
                return;
            }

            txtDisplay.Text = currentOperation switch
            {
                Operation.Divide => (currentValue / displayValue).ToString(),
                Operation.Add => (currentValue + displayValue).ToString(),
                Operation.Multiply => (currentValue * displayValue).ToString(),
                Operation.Minus => (currentValue - displayValue).ToString(),
                _ => throw new Exception(),
            };
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }


        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtDisplay.Text, out float currentInvertValue))
            {
                currentInvertValue *= -1;
                txtDisplay.Text = currentInvertValue.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            currentValue = default;
            currentOperation = default;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CurrentValueCalculation(Operation.Multiply);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CurrentValueCalculation(Operation.Minus);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CurrentValueCalculation(Operation.Add);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            CurrentValueCalculation(Operation.Divide);
        }

        enum Operation
        {
            Add,
            Minus,
            Multiply,
            Divide
        }

        private void CurrentValueCalculation(Operation operation)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                currentValue = float.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                currentOperation = operation;
            }
        }
    }
}
