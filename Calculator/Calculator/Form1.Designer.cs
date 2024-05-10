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
            btn1 = new Button();
            txtTotal = new TextBox();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnEql = new Button();
            btnPlus = new Button();
            btnMin = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(43, 149);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 46);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(12, 23);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(762, 78);
            txtTotal.TabIndex = 1;
            // 
            // btn2
            // 
            btn2.Location = new Point(225, 149);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 46);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(403, 149);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 46);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(43, 234);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 46);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(225, 234);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 46);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(403, 234);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 46);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(43, 313);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 46);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(225, 313);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 46);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(403, 313);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 46);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(43, 392);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 46);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(225, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 11;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEql
            // 
            btnEql.Location = new Point(403, 392);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(150, 46);
            btnEql.TabIndex = 12;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(602, 149);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(150, 46);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(602, 234);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(150, 46);
            btnMin.TabIndex = 14;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(602, 313);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(150, 46);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(602, 392);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(150, 46);
            btnMul.TabIndex = 16;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(786, 450);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btnEql);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(txtTotal);
            Controls.Add(btn1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox txtTotal;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnClear;
        private Button btnEql;
        private Button btnPlus;
        private Button btnMin;
        private Button btnDiv;
        private Button btnMul;
    }
}
