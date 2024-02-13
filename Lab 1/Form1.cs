using System.Drawing.Design;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private float currentNumber = 0;
        private float lastNumber = 0;
        private float memoryNumber = 0;

        private bool isTrigRoot = false;

        public Form1()
        {
            InitializeComponent();
        }

        private float CalcNumber(string str, float number)
        {
            float _number = float.Parse(str[str.Length - 1].ToString());

            if(number < 0)
                _number *= -1;

            return number.ToString().Length < 11 ? number * 10 + _number : number;
        }

        private float CalcTrigRoot(float number)
        { 
            number = (float)Math.Round(number, 5);
            text.Text = number.ToString();
            isTrigRoot = true;
            return number;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            if(isTrigRoot == true)
                return;

            currentNumber = CalcNumber(sender.ToString(), currentNumber);
            text.Text = currentNumber.ToString();
        }

        private void MemoryClearClick(object sender, EventArgs e)
        {
            memoryNumber = 0;
        }

        private void MemoryAddClick(object sender, EventArgs e)
        {
            memoryNumber = currentNumber;
        }

        private void MemoryGetClick(object sender, EventArgs e)
        {
            if (memoryNumber == 0)
                return;

            currentNumber = memoryNumber;
            text.Text = currentNumber.ToString();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            lastNumber = 0;
            ClearCurrentClick(sender, e);
        }

        private void ClearCurrentClick(object sender, EventArgs e)
        {
            currentNumber = 0;
            text.Text = "0";
            isTrigRoot = false;
        }

        private void SinClick(object sender, EventArgs e)
        {
            currentNumber = CalcTrigRoot((float)Math.Sin(currentNumber));
            Sin.Invoke(currentNumber);
        }

        private void CosClick(object sender, EventArgs e)
        {
            currentNumber = CalcTrigRoot((float)Math.Cos(currentNumber));
        }

        private void TanClick(object sender, EventArgs e)
        {
            currentNumber = CalcTrigRoot((float)Math.Tan(currentNumber));
        }

        private void CtnClick(object sender, EventArgs e)
        {
            currentNumber = CalcTrigRoot(1 / (float)Math.Tan(currentNumber));
        }

        private void CubeRootClick(object sender, EventArgs e)
        {
            currentNumber = CalcTrigRoot((float)Math.Cbrt(currentNumber));
        }

        private void SquareRootClick(object sender, EventArgs e)
        {
            currentNumber = CalcTrigRoot((float)Math.Sqrt(currentNumber));
        }

        private void PowClick(object sender, EventArgs e)
        {
            lastNumber = currentNumber;
            currentNumber = 0;
            text.Text = "0";
            isTrigRoot = false;
        }

        private void EqualClick(object sender, EventArgs e)
        {
            if (lastNumber == 0 && currentNumber == 0)
                return;

            currentNumber = (float)Math.Pow(lastNumber, currentNumber);
            text.Text = currentNumber.ToString();
            lastNumber = 0;
        }

        private void NotClick(object sender, EventArgs e)
        {
            currentNumber *= -1;
            text.Text = currentNumber.ToString();
        }
    }
}
