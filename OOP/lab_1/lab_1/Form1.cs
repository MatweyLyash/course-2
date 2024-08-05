namespace lab_1
{
    public partial class Calc : Form
    {
        double FirstValue;
        string arithmetic;
        string memoryNumber;
        public Calc()
        {
            InitializeComponent();
            Calculator someMethod = new Calculator();
            someMethod.Clear(textBox);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void multi_bottun(object sender, EventArgs e)
        {

            try
            {
                FirstValue = Convert.ToDouble(textBox.Text);
            }
            catch { textBox.Text = "Вы не ввели числовое значение. Очистите поле для дальнейших вычислений"; return; }
            textBox.Text = "";
            arithmetic = "*";
        }

        private void division_button(object sender, EventArgs e)
        {
            try
            {
                FirstValue = Convert.ToDouble(textBox.Text);
            }
            catch { textBox.Text = "Вы не ввели числовое значение. Очистите поле для дальнейших вычислений"; return; }
            textBox.Text = "";
            arithmetic = "/";
        }

        private void minus_button(object sender, EventArgs e)
        {
            try
            {
                FirstValue = Convert.ToDouble(textBox.Text);
            }
            catch { textBox.Text = "Вы не ввели числовое значение. Очистите поле для дальнейших вычислений"; return; }
            textBox.Text = "";
            arithmetic = "-";
        }

        private void new_memory_button(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memoryNumber))
            {
                memoryNumber = textBox.Text;
            }
            else
            {
                textBox.Text = memoryNumber;
            }

        }

        private void cell_button(object sender, EventArgs e)
        {
            try
            {
                FirstValue = Convert.ToDouble(textBox.Text);
            }
            catch { textBox.Text = "Вы не ввели числовое значение. Очистите поле для дальнейших вычислений"; return; }
            textBox.Text = "";
            arithmetic = "cell";
        }

        private void two_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void three_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void five_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void six_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void seven_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void eight_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void nine_input_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            arithmetic = "";
        }

        private void nol_Click(object sender, EventArgs e)
        {

            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {

            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
        }
        private void rest_Click(object sender, EventArgs e)
        {
            try
            {
                FirstValue = Convert.ToDouble(textBox.Text);
            } 
            catch { textBox.Text = "Вы не ввели числовое значение. Очистите поле для дальнейших вычислений";return; }
            textBox.Text = "";
            arithmetic = "%";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                FirstValue = Convert.ToDouble(textBox.Text);
            }
            catch { textBox.Text = "Вы не ввели числовое значение. Очистите поле для дальнейших вычислений"; return; }
            textBox.Text = "";
            arithmetic = "+";
        }

        private void ravno_button(object sender, EventArgs e)
        {
            double SecondValue;
            double outcome;
            try
            {
                SecondValue = Convert.ToInt64(textBox.Text);
            }
            catch
            {
                textBox.Text = "подсчёт числа после знака " + arithmetic + " невозможно вслед за =";
                return;
            }
            finally { }
            Calculator calc = new Calculator();
            if (arithmetic == "+")
            {
                
                outcome = calc.Add(FirstValue,SecondValue);
                textBox.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "-")
            {
                outcome = calc.Minus(FirstValue, SecondValue);
                textBox.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "*")
            {
                outcome = calc.Multi(FirstValue, SecondValue);
                textBox.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "/")
            {
                if (SecondValue == 0)
                {
                    textBox.Text = "ДИВИЗИОН БАЙ ЗИРО!";
                }
                else
                {
                    outcome = calc.Division(FirstValue, SecondValue);
                    textBox.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }
            if (arithmetic == "cell")
            {
                if (SecondValue == 0)
                {
                    textBox.Text = "НЕКОРРЕКТНАЯ ОПЕРАЦИЯ";
                }
                else
                {
                    outcome =calc.Cell(FirstValue, SecondValue);
                    textBox.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }
            if (arithmetic == "%")
            {
                if (SecondValue == 0)
                {
                    textBox.Text = "НЕКОРРЕКТНАЯ ОПЕРАЦИЯ";
                }
                else
                {
                    outcome = calc.Rest(FirstValue, SecondValue);
                    textBox.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }
            if (arithmetic == "")
            {
                textBox.Text = "";
            }

        }

        private void del_memory_Click(object sender, EventArgs e)
        {
            memoryNumber = "";
        }
    }
}