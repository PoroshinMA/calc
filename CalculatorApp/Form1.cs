using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double _currentValue = 0;
        private double _lastValue = 0;
        private string _operation = "";
        private bool _isNewEntry = true;
        private bool _error = false;
        private string _saveFile = "calc_save.txt";
        private bool _darkTheme = false;
        private bool _justEvaluated = false;
        private Color _customBackColor = SystemColors.Control;
        private Color _customButtonColor = SystemColors.ControlLight;
        private Color _customTextColor = Color.Black;
        private Font _customFont = null;

        public Form1()
        {
            InitializeComponent();
            AssignHandlers();
            UpdateDisplay("0");
            // Добавляю кнопку для смены шрифта
            var btnFont = new Button();
            btnFont.Text = "Шрифт";
            btnFont.Location = new System.Drawing.Point(12, 350);
            btnFont.Size = new System.Drawing.Size(90, 35);
            btnFont.Click += (s, e) => FontClick();
            this.Controls.Add(btnFont);
        }

        private void AssignHandlers()
        {
            btn0.Click += (s, e) => DigitClick("0");
            btn1.Click += (s, e) => DigitClick("1");
            btn2.Click += (s, e) => DigitClick("2");
            btn3.Click += (s, e) => DigitClick("3");
            btn4.Click += (s, e) => DigitClick("4");
            btn5.Click += (s, e) => DigitClick("5");
            btn6.Click += (s, e) => DigitClick("6");
            btn7.Click += (s, e) => DigitClick("7");
            btn8.Click += (s, e) => DigitClick("8");
            btn9.Click += (s, e) => DigitClick("9");
            btnDot.Click += (s, e) => DotClick();
            btnAdd.Click += (s, e) => OperationClick("+");
            btnSub.Click += (s, e) => OperationClick("-");
            btnMul.Click += (s, e) => OperationClick("*");
            btnDiv.Click += (s, e) => OperationClick("/");
            btnEq.Click += (s, e) => EqualClick();
            btnClear.Click += (s, e) => ClearClick();
            btnSave.Click += (s, e) => SaveClick();
            btnLoad.Click += (s, e) => LoadClick();
            btnTheme.Click += (s, e) => ThemeClick();
        }

        private void DigitClick(string digit)
        {
            if (_error) { ClearClick(); }
            if (_isNewEntry || _justEvaluated)
            {
                txtDisplay.Text = digit;
                _isNewEntry = false;
                _justEvaluated = false;
            }
            else
            {
                if (txtDisplay.Text == "0") txtDisplay.Text = digit;
                else txtDisplay.Text += digit;
            }
        }

        private void DotClick()
        {
            if (_error) { ClearClick(); }
            if (_isNewEntry || _justEvaluated)
            {
                txtDisplay.Text = "0.";
                _isNewEntry = false;
                _justEvaluated = false;
            }
            else if (!txtDisplay.Text.EndsWith("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void OperationClick(string op)
        {
            if (_error) { ClearClick(); }
            if (_justEvaluated)
            {
                _justEvaluated = false;
            }
            if (txtDisplay.Text.Length == 0) return;
            char last = txtDisplay.Text[txtDisplay.Text.Length - 1];
            if (IsOperator(last))
            {
                // Заменить последний оператор
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) + op;
            }
            else
            {
                txtDisplay.Text += op;
            }
            _isNewEntry = false;
        }

        private void EqualClick()
        {
            if (_error) { ClearClick(); return; }
            string expr = txtDisplay.Text;
            try
            {
                double result = EvaluateExpression(expr);
                UpdateDisplay(result.ToString());
                _justEvaluated = true;
                _isNewEntry = true;
            }
            catch (Exception ex)
            {
                ShowError("Ошибка: " + ex.Message);
            }
        }

        private void ClearClick()
        {
            _currentValue = 0;
            _lastValue = 0;
            _operation = "";
            _isNewEntry = true;
            _error = false;
            UpdateDisplay("0");
        }

        private void SaveClick()
        {
            try
            {
                File.WriteAllText(_saveFile, txtDisplay.Text);
                MessageBox.Show("Результат сохранён!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void LoadClick()
        {
            try
            {
                if (File.Exists(_saveFile))
                {
                    string val = File.ReadAllText(_saveFile);
                    txtDisplay.Text = val;
                    _isNewEntry = true;
                }
                else
                {
                    MessageBox.Show("Нет сохранённого результата.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void ThemeClick()
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = this.BackColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _customBackColor = dlg.Color;
                    this.BackColor = _customBackColor;
                    txtDisplay.BackColor = _customBackColor;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button b)
                        {
                            b.BackColor = _customBackColor;
                            b.ForeColor = _customTextColor;
                        }
                    }
                }
            }
        }

        private void FontClick()
        {
            using (FontDialog dlg = new FontDialog())
            {
                dlg.Font = txtDisplay.Font;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _customFont = dlg.Font;
                    txtDisplay.Font = _customFont;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button b)
                        {
                            b.Font = _customFont;
                        }
                    }
                }
            }
        }

        private void UpdateDisplay(string text)
        {
            txtDisplay.Text = text;
        }

        private string GetLastNumber(string expr)
        {
            int i = expr.Length - 1;
            while (i >= 0 && (char.IsDigit(expr[i]) || expr[i] == '.')) i--;
            return expr.Substring(i + 1);
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private double EvaluateExpression(string expr)
        {
            // Поддержка только одного оператора (например, 12+34)
            char[] ops = new char[] { '+', '-', '*', '/' };
            int opPos = -1;
            char op = '\0';
            foreach (char c in ops)
            {
                opPos = expr.IndexOf(c, 1); // не первый символ
                if (opPos > 0)
                {
                    op = c;
                    break;
                }
            }
            if (opPos < 0)
                return double.Parse(expr);
            double left = double.Parse(expr.Substring(0, opPos));
            double right = double.Parse(expr.Substring(opPos + 1));
            switch (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/':
                    if (right == 0) throw new DivideByZeroException();
                    return left / right;
            }
            throw new Exception("Неизвестная операция");
        }

        private void ShowError(string message)
        {
            txtDisplay.Text = message;
            _error = true;
        }
    }
} 