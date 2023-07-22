namespace Calculator
{
    partial class Form1
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
            btn6 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn9 = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            label1 = new Label();
            btnBackSpace = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(162, 140);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 1;
            btn6.Tag = "6";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(162, 209);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 2;
            btn3.Tag = "3";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 280);
            btn0.Name = "btn0";
            btn0.Size = new Size(200, 50);
            btn0.TabIndex = 3;
            btn0.Tag = "0";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 209);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 6;
            btn1.Tag = "1";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 140);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 5;
            btn4.Tag = "4";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(8, 73);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 4;
            btn7.Tag = "7";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(87, 209);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 9;
            btn2.Tag = "2";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(87, 140);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 8;
            btn5.Tag = "5";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(83, 73);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 7;
            btn8.Tag = "8";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(241, 280);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 12;
            btnMinus.Tag = "-";
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperation_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(241, 209);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 11;
            btnPlus.Tag = "+";
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperation_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(162, 73);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 10;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(315, 209);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(50, 50);
            btnDiv.TabIndex = 15;
            btnDiv.Tag = "/";
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnOperation_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(315, 140);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(50, 50);
            btnMult.TabIndex = 14;
            btnMult.Tag = "*";
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnOperation_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(315, 280);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(50, 50);
            btnEquals.TabIndex = 13;
            btnEquals.Tag = "=";
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(241, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 16;
            btnClear.Tag = "C";
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(353, 43);
            label1.TabIndex = 17;
            label1.Text = "0";
            // 
            // btnBackSpace
            // 
            btnBackSpace.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackSpace.Location = new Point(315, 73);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(50, 50);
            btnBackSpace.TabIndex = 18;
            btnBackSpace.Tag = "";
            btnBackSpace.Text = "<-";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(241, 73);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 19;
            button1.Tag = ",";
            button1.Text = ",";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOperation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 342);
            Controls.Add(button1);
            Controls.Add(btnBackSpace);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnEquals);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion
        private Button btn6;
        private Button btn3;
        private Button btn0;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnMinus;
        private Button btnPlus;
        private Button btn9;
        private Button btnDiv;
        private Button btnMult;
        private Button btnEquals;
        private Button btnClear;
        private Label label1;
        private Button btnBackSpace;
        private Button button1;
    }
}