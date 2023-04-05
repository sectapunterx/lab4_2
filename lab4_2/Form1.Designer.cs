namespace lab4_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCalc1 = new System.Windows.Forms.RadioButton();
            this.rbCalc2 = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCalc1
            // 
            this.rbCalc1.AutoSize = true;
            this.rbCalc1.Location = new System.Drawing.Point(9, 10);
            this.rbCalc1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCalc1.Name = "rbCalc1";
            this.rbCalc1.Size = new System.Drawing.Size(66, 17);
            this.rbCalc1.TabIndex = 0;
            this.rbCalc1.TabStop = true;
            this.rbCalc1.Text = "MyCalc1";
            this.rbCalc1.UseVisualStyleBackColor = true;
            // 
            // rbCalc2
            // 
            this.rbCalc2.AutoSize = true;
            this.rbCalc2.Location = new System.Drawing.Point(9, 32);
            this.rbCalc2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCalc2.Name = "rbCalc2";
            this.rbCalc2.Size = new System.Drawing.Size(66, 17);
            this.rbCalc2.TabIndex = 1;
            this.rbCalc2.TabStop = true;
            this.rbCalc2.Text = "MyCalc2";
            this.rbCalc2.UseVisualStyleBackColor = true;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 10);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "A";
            this.txtA.Enter += new System.EventHandler(this.txt_Enter);
            this.txtA.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(154, 10);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "B";
            this.txtB.Enter += new System.EventHandler(this.txt_Enter);
            this.txtB.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(234, 10);
            this.txtD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(76, 20);
            this.txtD.TabIndex = 4;
            this.txtD.Text = "D";
            this.txtD.Enter += new System.EventHandler(this.txt_Enter);
            this.txtD.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 32);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(234, 19);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(75, 55);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(235, 20);
            this.txtResult.TabIndex = 6;
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(9, 76);
            this.lblExpression.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(64, 13);
            this.lblExpression.TabIndex = 7;
            this.lblExpression.Text = "Expression: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 106);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rbCalc2);
            this.Controls.Add(this.rbCalc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton rbCalc1;
        private System.Windows.Forms.RadioButton rbCalc2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblExpression;
    }
}
