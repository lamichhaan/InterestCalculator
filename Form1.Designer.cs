namespace InterestCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.principleTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(83, 169);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(334, 171);
            this.displayTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(342, 55);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // principleTextBox
            // 
            this.principleTextBox.Location = new System.Drawing.Point(143, 55);
            this.principleTextBox.Name = "principleTextBox";
            this.principleTextBox.Size = new System.Drawing.Size(100, 20);
            this.principleTextBox.TabIndex = 4;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(143, 88);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Years";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(143, 123);
            this.yearUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(100, 20);
            this.yearUpDown.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 352);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principleTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculate Your Interest";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox principleTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yearUpDown;
    }
}

