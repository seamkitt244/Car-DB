namespace CarInventory
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
            this.idInput = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.colourInput = new System.Windows.Forms.TextBox();
            this.mileageInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.yearButton = new System.Windows.Forms.RadioButton();
            this.makeButton = new System.Windows.Forms.RadioButton();
            this.colourButton = new System.Windows.Forms.RadioButton();
            this.mileageButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(194, 18);
            this.idInput.Margin = new System.Windows.Forms.Padding(6);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(250, 31);
            this.idInput.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(74, 369);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(600, 265);
            this.outputLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mileage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(194, 61);
            this.yearInput.Margin = new System.Windows.Forms.Padding(6);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(250, 31);
            this.yearInput.TabIndex = 12;
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(194, 113);
            this.makeInput.Margin = new System.Windows.Forms.Padding(6);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(250, 31);
            this.makeInput.TabIndex = 13;
            // 
            // colourInput
            // 
            this.colourInput.Location = new System.Drawing.Point(194, 163);
            this.colourInput.Margin = new System.Windows.Forms.Padding(6);
            this.colourInput.Name = "colourInput";
            this.colourInput.Size = new System.Drawing.Size(250, 31);
            this.colourInput.TabIndex = 14;
            // 
            // mileageInput
            // 
            this.mileageInput.Location = new System.Drawing.Point(194, 219);
            this.mileageInput.Margin = new System.Windows.Forms.Padding(6);
            this.mileageInput.Name = "mileageInput";
            this.mileageInput.Size = new System.Drawing.Size(250, 31);
            this.mileageInput.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(74, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 48);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(205, 277);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(125, 48);
            this.listButton.TabIndex = 17;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(336, 277);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(125, 48);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(467, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 58);
            this.label6.TabIndex = 19;
            this.label6.Text = "To remove a car enter its ID";
            // 
            // idButton
            // 
            this.idButton.AutoSize = true;
            this.idButton.Location = new System.Drawing.Point(472, 37);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(63, 29);
            this.idButton.TabIndex = 20;
            this.idButton.TabStop = true;
            this.idButton.Text = "ID";
            this.idButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sort By:";
            // 
            // yearButton
            // 
            this.yearButton.AutoSize = true;
            this.yearButton.Location = new System.Drawing.Point(472, 72);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(89, 29);
            this.yearButton.TabIndex = 22;
            this.yearButton.TabStop = true;
            this.yearButton.Text = "Year";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // makeButton
            // 
            this.makeButton.AutoSize = true;
            this.makeButton.Location = new System.Drawing.Point(472, 107);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(96, 29);
            this.makeButton.TabIndex = 23;
            this.makeButton.TabStop = true;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            // 
            // colourButton
            // 
            this.colourButton.AutoSize = true;
            this.colourButton.Location = new System.Drawing.Point(472, 142);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(106, 29);
            this.colourButton.TabIndex = 24;
            this.colourButton.TabStop = true;
            this.colourButton.Text = "Colour";
            this.colourButton.UseVisualStyleBackColor = true;
            // 
            // mileageButton
            // 
            this.mileageButton.AutoSize = true;
            this.mileageButton.Location = new System.Drawing.Point(472, 177);
            this.mileageButton.Name = "mileageButton";
            this.mileageButton.Size = new System.Drawing.Size(119, 29);
            this.mileageButton.TabIndex = 25;
            this.mileageButton.TabStop = true;
            this.mileageButton.Text = "Mileage";
            this.mileageButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 704);
            this.Controls.Add(this.mileageButton);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mileageInput);
            this.Controls.Add(this.colourInput);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.idInput);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Car Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.TextBox colourInput;
        private System.Windows.Forms.TextBox mileageInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton idButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton yearButton;
        private System.Windows.Forms.RadioButton makeButton;
        private System.Windows.Forms.RadioButton colourButton;
        private System.Windows.Forms.RadioButton mileageButton;
    }
}

