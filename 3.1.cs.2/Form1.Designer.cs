namespace _3._1.cs._2
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
            this.beginningTextBox = new System.Windows.Forms.TextBox();
            this.endingTextBox = new System.Windows.Forms.TextBox();
            this.cogTextBox = new System.Windows.Forms.TextBox();
            this.beginningLabel = new System.Windows.Forms.Label();
            this.endingLabel = new System.Windows.Forms.Label();
            this.cogLabel = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.turnoverTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.turnoverLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.beginningTextBox2 = new System.Windows.Forms.TextBox();
            this.beginningTextBox3 = new System.Windows.Forms.TextBox();
            this.endingTextBox2 = new System.Windows.Forms.TextBox();
            this.endingTextBox3 = new System.Windows.Forms.TextBox();
            this.cogTextBox2 = new System.Windows.Forms.TextBox();
            this.cogTextBox3 = new System.Windows.Forms.TextBox();
            this.averageTextBox2 = new System.Windows.Forms.TextBox();
            this.averageTextBox3 = new System.Windows.Forms.TextBox();
            this.turnoverTextBox2 = new System.Windows.Forms.TextBox();
            this.turnoverTextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // beginningTextBox
            // 
            this.beginningTextBox.Location = new System.Drawing.Point(49, 78);
            this.beginningTextBox.Name = "beginningTextBox";
            this.beginningTextBox.Size = new System.Drawing.Size(100, 22);
            this.beginningTextBox.TabIndex = 0;
            // 
            // endingTextBox
            // 
            this.endingTextBox.Location = new System.Drawing.Point(205, 78);
            this.endingTextBox.Name = "endingTextBox";
            this.endingTextBox.Size = new System.Drawing.Size(100, 22);
            this.endingTextBox.TabIndex = 1;
            // 
            // cogTextBox
            // 
            this.cogTextBox.Location = new System.Drawing.Point(336, 78);
            this.cogTextBox.Name = "cogTextBox";
            this.cogTextBox.Size = new System.Drawing.Size(100, 22);
            this.cogTextBox.TabIndex = 2;
            // 
            // beginningLabel
            // 
            this.beginningLabel.AutoSize = true;
            this.beginningLabel.Location = new System.Drawing.Point(46, 51);
            this.beginningLabel.Name = "beginningLabel";
            this.beginningLabel.Size = new System.Drawing.Size(133, 17);
            this.beginningLabel.TabIndex = 3;
            this.beginningLabel.Text = "Beginning Inventory";
            // 
            // endingLabel
            // 
            this.endingLabel.AutoSize = true;
            this.endingLabel.Location = new System.Drawing.Point(202, 51);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(114, 17);
            this.endingLabel.TabIndex = 4;
            this.endingLabel.Text = "Ending Inventory";
            // 
            // cogLabel
            // 
            this.cogLabel.AutoSize = true;
            this.cogLabel.Location = new System.Drawing.Point(333, 51);
            this.cogLabel.Name = "cogLabel";
            this.cogLabel.Size = new System.Drawing.Size(130, 17);
            this.cogLabel.TabIndex = 5;
            this.cogLabel.Text = "Cost of Goods Sold";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(495, 78);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(100, 22);
            this.averageTextBox.TabIndex = 6;
            // 
            // turnoverTextBox
            // 
            this.turnoverTextBox.Location = new System.Drawing.Point(641, 78);
            this.turnoverTextBox.Name = "turnoverTextBox";
            this.turnoverTextBox.Size = new System.Drawing.Size(100, 22);
            this.turnoverTextBox.TabIndex = 7;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(492, 51);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(123, 17);
            this.averageLabel.TabIndex = 8;
            this.averageLabel.Text = "Average Inventory";
            // 
            // turnoverLabel
            // 
            this.turnoverLabel.AutoSize = true;
            this.turnoverLabel.Location = new System.Drawing.Point(638, 51);
            this.turnoverLabel.Name = "turnoverLabel";
            this.turnoverLabel.Size = new System.Drawing.Size(66, 17);
            this.turnoverLabel.TabIndex = 9;
            this.turnoverLabel.Text = "Turnover";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(536, 354);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(536, 383);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(666, 354);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(666, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // beginningTextBox2
            // 
            this.beginningTextBox2.Location = new System.Drawing.Point(50, 115);
            this.beginningTextBox2.Name = "beginningTextBox2";
            this.beginningTextBox2.Size = new System.Drawing.Size(100, 22);
            this.beginningTextBox2.TabIndex = 14;
            // 
            // beginningTextBox3
            // 
            this.beginningTextBox3.Location = new System.Drawing.Point(49, 143);
            this.beginningTextBox3.Name = "beginningTextBox3";
            this.beginningTextBox3.Size = new System.Drawing.Size(100, 22);
            this.beginningTextBox3.TabIndex = 15;
            // 
            // endingTextBox2
            // 
            this.endingTextBox2.Location = new System.Drawing.Point(205, 115);
            this.endingTextBox2.Name = "endingTextBox2";
            this.endingTextBox2.Size = new System.Drawing.Size(100, 22);
            this.endingTextBox2.TabIndex = 16;
            // 
            // endingTextBox3
            // 
            this.endingTextBox3.Location = new System.Drawing.Point(205, 143);
            this.endingTextBox3.Name = "endingTextBox3";
            this.endingTextBox3.Size = new System.Drawing.Size(100, 22);
            this.endingTextBox3.TabIndex = 17;
            // 
            // cogTextBox2
            // 
            this.cogTextBox2.Location = new System.Drawing.Point(336, 115);
            this.cogTextBox2.Name = "cogTextBox2";
            this.cogTextBox2.Size = new System.Drawing.Size(100, 22);
            this.cogTextBox2.TabIndex = 18;
            // 
            // cogTextBox3
            // 
            this.cogTextBox3.Location = new System.Drawing.Point(336, 143);
            this.cogTextBox3.Name = "cogTextBox3";
            this.cogTextBox3.Size = new System.Drawing.Size(100, 22);
            this.cogTextBox3.TabIndex = 19;
            // 
            // averageTextBox2
            // 
            this.averageTextBox2.Location = new System.Drawing.Point(495, 115);
            this.averageTextBox2.Name = "averageTextBox2";
            this.averageTextBox2.Size = new System.Drawing.Size(100, 22);
            this.averageTextBox2.TabIndex = 20;
            // 
            // averageTextBox3
            // 
            this.averageTextBox3.Location = new System.Drawing.Point(495, 143);
            this.averageTextBox3.Name = "averageTextBox3";
            this.averageTextBox3.Size = new System.Drawing.Size(100, 22);
            this.averageTextBox3.TabIndex = 21;
            // 
            // turnoverTextBox2
            // 
            this.turnoverTextBox2.Location = new System.Drawing.Point(641, 115);
            this.turnoverTextBox2.Name = "turnoverTextBox2";
            this.turnoverTextBox2.Size = new System.Drawing.Size(100, 22);
            this.turnoverTextBox2.TabIndex = 22;
            // 
            // turnoverTextBox3
            // 
            this.turnoverTextBox3.Location = new System.Drawing.Point(641, 143);
            this.turnoverTextBox3.Name = "turnoverTextBox3";
            this.turnoverTextBox3.Size = new System.Drawing.Size(100, 22);
            this.turnoverTextBox3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.turnoverTextBox3);
            this.Controls.Add(this.turnoverTextBox2);
            this.Controls.Add(this.averageTextBox3);
            this.Controls.Add(this.averageTextBox2);
            this.Controls.Add(this.cogTextBox3);
            this.Controls.Add(this.cogTextBox2);
            this.Controls.Add(this.endingTextBox3);
            this.Controls.Add(this.endingTextBox2);
            this.Controls.Add(this.beginningTextBox3);
            this.Controls.Add(this.beginningTextBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.turnoverLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.turnoverTextBox);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.cogLabel);
            this.Controls.Add(this.endingLabel);
            this.Controls.Add(this.beginningLabel);
            this.Controls.Add(this.cogTextBox);
            this.Controls.Add(this.endingTextBox);
            this.Controls.Add(this.beginningTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beginningTextBox;
        private System.Windows.Forms.TextBox endingTextBox;
        private System.Windows.Forms.TextBox cogTextBox;
        private System.Windows.Forms.Label beginningLabel;
        private System.Windows.Forms.Label endingLabel;
        private System.Windows.Forms.Label cogLabel;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.TextBox turnoverTextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label turnoverLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox beginningTextBox2;
        private System.Windows.Forms.TextBox beginningTextBox3;
        private System.Windows.Forms.TextBox endingTextBox2;
        private System.Windows.Forms.TextBox endingTextBox3;
        private System.Windows.Forms.TextBox cogTextBox2;
        private System.Windows.Forms.TextBox cogTextBox3;
        private System.Windows.Forms.TextBox averageTextBox2;
        private System.Windows.Forms.TextBox averageTextBox3;
        private System.Windows.Forms.TextBox turnoverTextBox2;
        private System.Windows.Forms.TextBox turnoverTextBox3;
    }
}

