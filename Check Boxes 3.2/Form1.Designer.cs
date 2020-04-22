namespace Check_Boxes_3._2
{
    partial class pizzaShopForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smallPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.largePizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toppingFourCheckBox = new System.Windows.Forms.CheckBox();
            this.toppingThreeCheckBox = new System.Windows.Forms.CheckBox();
            this.toppingTwoCheckBox = new System.Windows.Forms.CheckBox();
            this.toppingOneCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smallPizzaRadioButton);
            this.groupBox1.Controls.Add(this.mediumPizzaRadioButton);
            this.groupBox1.Controls.Add(this.largePizzaRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Type";
            // 
            // smallPizzaRadioButton
            // 
            this.smallPizzaRadioButton.AutoSize = true;
            this.smallPizzaRadioButton.Location = new System.Drawing.Point(26, 213);
            this.smallPizzaRadioButton.Name = "smallPizzaRadioButton";
            this.smallPizzaRadioButton.Size = new System.Drawing.Size(82, 29);
            this.smallPizzaRadioButton.TabIndex = 2;
            this.smallPizzaRadioButton.TabStop = true;
            this.smallPizzaRadioButton.Text = "Small";
            this.smallPizzaRadioButton.UseVisualStyleBackColor = true;
            this.smallPizzaRadioButton.CheckedChanged += new System.EventHandler(this.smallSelection);
            // 
            // mediumPizzaRadioButton
            // 
            this.mediumPizzaRadioButton.AutoSize = true;
            this.mediumPizzaRadioButton.Location = new System.Drawing.Point(26, 145);
            this.mediumPizzaRadioButton.Name = "mediumPizzaRadioButton";
            this.mediumPizzaRadioButton.Size = new System.Drawing.Size(103, 29);
            this.mediumPizzaRadioButton.TabIndex = 1;
            this.mediumPizzaRadioButton.TabStop = true;
            this.mediumPizzaRadioButton.Text = "Medium";
            this.mediumPizzaRadioButton.UseVisualStyleBackColor = true;
            this.mediumPizzaRadioButton.CheckedChanged += new System.EventHandler(this.mediumSelection);
            // 
            // largePizzaRadioButton
            // 
            this.largePizzaRadioButton.AutoSize = true;
            this.largePizzaRadioButton.Location = new System.Drawing.Point(26, 78);
            this.largePizzaRadioButton.Name = "largePizzaRadioButton";
            this.largePizzaRadioButton.Size = new System.Drawing.Size(83, 29);
            this.largePizzaRadioButton.TabIndex = 0;
            this.largePizzaRadioButton.TabStop = true;
            this.largePizzaRadioButton.Text = "Large";
            this.largePizzaRadioButton.UseVisualStyleBackColor = true;
            this.largePizzaRadioButton.CheckedChanged += new System.EventHandler(this.largeSelection);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toppingFourCheckBox);
            this.groupBox2.Controls.Add(this.toppingThreeCheckBox);
            this.groupBox2.Controls.Add(this.toppingTwoCheckBox);
            this.groupBox2.Controls.Add(this.toppingOneCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(333, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // toppingFourCheckBox
            // 
            this.toppingFourCheckBox.AutoSize = true;
            this.toppingFourCheckBox.Location = new System.Drawing.Point(57, 214);
            this.toppingFourCheckBox.Name = "toppingFourCheckBox";
            this.toppingFourCheckBox.Size = new System.Drawing.Size(123, 29);
            this.toppingFourCheckBox.TabIndex = 3;
            this.toppingFourCheckBox.Text = "Chocolate";
            this.toppingFourCheckBox.UseVisualStyleBackColor = true;
            this.toppingFourCheckBox.CheckedChanged += new System.EventHandler(this.toppingFourSelected);
            // 
            // toppingThreeCheckBox
            // 
            this.toppingThreeCheckBox.AutoSize = true;
            this.toppingThreeCheckBox.Location = new System.Drawing.Point(57, 165);
            this.toppingThreeCheckBox.Name = "toppingThreeCheckBox";
            this.toppingThreeCheckBox.Size = new System.Drawing.Size(243, 29);
            this.toppingThreeCheckBox.TabIndex = 2;
            this.toppingThreeCheckBox.Text = "Pepperoni and Vindaloo";
            this.toppingThreeCheckBox.UseVisualStyleBackColor = true;
            this.toppingThreeCheckBox.CheckedChanged += new System.EventHandler(this.toppingThreeSelected);
            // 
            // toppingTwoCheckBox
            // 
            this.toppingTwoCheckBox.AutoSize = true;
            this.toppingTwoCheckBox.Location = new System.Drawing.Point(57, 111);
            this.toppingTwoCheckBox.Name = "toppingTwoCheckBox";
            this.toppingTwoCheckBox.Size = new System.Drawing.Size(220, 29);
            this.toppingTwoCheckBox.TabIndex = 1;
            this.toppingTwoCheckBox.Text = "Rhubarb and Custard";
            this.toppingTwoCheckBox.UseVisualStyleBackColor = true;
            this.toppingTwoCheckBox.CheckedChanged += new System.EventHandler(this.toppingTwoSelected);
            // 
            // toppingOneCheckBox
            // 
            this.toppingOneCheckBox.AutoSize = true;
            this.toppingOneCheckBox.Location = new System.Drawing.Point(57, 59);
            this.toppingOneCheckBox.Name = "toppingOneCheckBox";
            this.toppingOneCheckBox.Size = new System.Drawing.Size(260, 29);
            this.toppingOneCheckBox.TabIndex = 0;
            this.toppingOneCheckBox.Text = "Pineapple and Cauliflower";
            this.toppingOneCheckBox.UseVisualStyleBackColor = true;
            this.toppingOneCheckBox.CheckedChanged += new System.EventHandler(this.toppingOneSelected);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.costLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 106);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pizza Cost";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(44, 47);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 25);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "£ ";
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(607, 398);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(159, 56);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // pizzaShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 516);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "pizzaShopForm";
            this.Text = "Pizza Shop Selection Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton smallPizzaRadioButton;
        private System.Windows.Forms.RadioButton mediumPizzaRadioButton;
        private System.Windows.Forms.RadioButton largePizzaRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.CheckBox toppingFourCheckBox;
        private System.Windows.Forms.CheckBox toppingThreeCheckBox;
        private System.Windows.Forms.CheckBox toppingTwoCheckBox;
        private System.Windows.Forms.CheckBox toppingOneCheckBox;
    }
}

