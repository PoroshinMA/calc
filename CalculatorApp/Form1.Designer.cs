namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(318, 39);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Кнопки цифр и операций
            // 
            int btnW = 60, btnH = 45, margin = 12;
            int[,] positions = new int[,] {
                {margin, 207}, {margin+btnW+6, 207}, {margin+2*(btnW+6), 207}, // 1 2 3
                {margin, 156}, {margin+btnW+6, 156}, {margin+2*(btnW+6), 156}, // 4 5 6
                {margin, 105}, {margin+btnW+6, 105}, {margin+2*(btnW+6), 105}, // 7 8 9
                {margin, 258}, {margin+btnW+6, 258}, // 0 .
            };
            this.btn1.Location = new System.Drawing.Point(positions[0,0], positions[0,1]);
            this.btn2.Location = new System.Drawing.Point(positions[1,0], positions[1,1]);
            this.btn3.Location = new System.Drawing.Point(positions[2,0], positions[2,1]);
            this.btn4.Location = new System.Drawing.Point(positions[3,0], positions[3,1]);
            this.btn5.Location = new System.Drawing.Point(positions[4,0], positions[4,1]);
            this.btn6.Location = new System.Drawing.Point(positions[5,0], positions[5,1]);
            this.btn7.Location = new System.Drawing.Point(positions[6,0], positions[6,1]);
            this.btn8.Location = new System.Drawing.Point(positions[7,0], positions[7,1]);
            this.btn9.Location = new System.Drawing.Point(positions[8,0], positions[8,1]);
            this.btn0.Location = new System.Drawing.Point(positions[9,0], positions[9,1]);
            this.btnDot.Location = new System.Drawing.Point(positions[10,0], positions[10,1]);
            this.btn1.Size = this.btn2.Size = this.btn3.Size = this.btn4.Size = this.btn5.Size = this.btn6.Size = this.btn7.Size = this.btn8.Size = this.btn9.Size = this.btn0.Size = this.btnDot.Size = new System.Drawing.Size(btnW, btnH);
            this.btn1.Text = "1"; this.btn2.Text = "2"; this.btn3.Text = "3";
            this.btn4.Text = "4"; this.btn5.Text = "5"; this.btn6.Text = "6";
            this.btn7.Text = "7"; this.btn8.Text = "8"; this.btn9.Text = "9";
            this.btn0.Text = "0"; this.btnDot.Text = ".";
            // 
            // Операции
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 105);
            this.btnSub.Location = new System.Drawing.Point(210, 156);
            this.btnMul.Location = new System.Drawing.Point(210, 207);
            this.btnDiv.Location = new System.Drawing.Point(210, 258);
            this.btnAdd.Size = this.btnSub.Size = this.btnMul.Size = this.btnDiv.Size = new System.Drawing.Size(60, 45);
            this.btnAdd.Text = "+";
            this.btnSub.Text = "-";
            this.btnMul.Text = "*";
            this.btnDiv.Text = "/";
            // 
            // =, C
            // 
            this.btnEq.Location = new System.Drawing.Point(276, 207);
            this.btnEq.Size = new System.Drawing.Size(54, 96);
            this.btnEq.Text = "=";
            this.btnClear.Location = new System.Drawing.Point(276, 105);
            this.btnClear.Size = new System.Drawing.Size(54, 45);
            this.btnClear.Text = "C";
            // 
            // Save, Load, Theme
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 309);
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.Text = "Сохранить";
            this.btnLoad.Location = new System.Drawing.Point(108, 309);
            this.btnLoad.Size = new System.Drawing.Size(90, 35);
            this.btnLoad.Text = "Загрузить";
            this.btnTheme.Location = new System.Drawing.Point(204, 309);
            this.btnTheme.Size = new System.Drawing.Size(126, 35);
            this.btnTheme.Text = "Сменить тему";
            // 
            // Добавление на форму
            // 
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn0); this.Controls.Add(this.btn1); this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3); this.Controls.Add(this.btn4); this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6); this.Controls.Add(this.btn7); this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9); this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnAdd); this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul); this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnEq); this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave); this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTheme);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 356);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTheme;
    }
} 