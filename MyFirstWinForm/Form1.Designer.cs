namespace MyFirstWinForm
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCE = new Button();
            btnC = new Button();
            btnBackspace = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnInvert = new Button();
            btn0 = new Button();
            btnDecimalPoint = new Button();
            btnEquals = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btnCE
            // 
            btnCE.Location = new Point(61, 124);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(94, 29);
            btnCE.TabIndex = 0;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(161, 124);
            btnC.Name = "btnC";
            btnC.Size = new Size(94, 29);
            btnC.TabIndex = 0;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(261, 124);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(94, 29);
            btnBackspace.TabIndex = 0;
            btnBackspace.Text = "<--";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(361, 124);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(94, 29);
            btnDivide.TabIndex = 0;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(61, 159);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 29);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += number_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(161, 159);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 29);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += number_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(261, 159);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 29);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += number_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(361, 159);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(94, 29);
            btnMultiply.TabIndex = 0;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(61, 194);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += number_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(161, 194);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 29);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += number_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(261, 194);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 29);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += number_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(361, 194);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 29);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(61, 229);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += number_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(161, 229);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += number_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(261, 229);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += number_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(361, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnInvert
            // 
            btnInvert.Location = new Point(61, 264);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(94, 29);
            btnInvert.TabIndex = 0;
            btnInvert.Text = "+/-";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(161, 264);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 29);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += number_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.Location = new Point(261, 264);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(94, 29);
            btnDecimalPoint.TabIndex = 0;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = true;
            btnDecimalPoint.Click += btnDecimalPoint_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(361, 264);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(94, 29);
            btnEquals.TabIndex = 0;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(302, 77);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(125, 27);
            txtDisplay.TabIndex = 1;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDisplay);
            Controls.Add(btnEquals);
            Controls.Add(btnAdd);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnBackspace);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btnC);
            Controls.Add(btnInvert);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnCE);
            Name = "CalculatorForm";
            Text = "MyCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCE;
        private Button btnC;
        private Button btnBackspace;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnInvert;
        private Button btn0;
        private Button btnDecimalPoint;
        private Button btnEquals;
        private TextBox txtDisplay;
    }
}
