namespace PizzaToppings
{
    partial class Main
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
            this.toppings = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.pizzaSummary = new System.Windows.Forms.Label();
            this.pizzaPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toppings
            // 
            this.toppings.FormattingEnabled = true;
            this.toppings.Location = new System.Drawing.Point(41, 52);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(242, 40);
            this.toppings.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(643, 52);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(241, 68);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Toppings";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(643, 196);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(241, 68);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove Toppings";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // pizzaSummary
            // 
            this.pizzaSummary.AutoSize = true;
            this.pizzaSummary.Location = new System.Drawing.Point(41, 302);
            this.pizzaSummary.Name = "pizzaSummary";
            this.pizzaSummary.Size = new System.Drawing.Size(0, 32);
            this.pizzaSummary.TabIndex = 3;
            // 
            // pizzaPrice
            // 
            this.pizzaPrice.AutoSize = true;
            this.pizzaPrice.Location = new System.Drawing.Point(41, 427);
            this.pizzaPrice.Name = "pizzaPrice";
            this.pizzaPrice.Size = new System.Drawing.Size(0, 32);
            this.pizzaPrice.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 552);
            this.Controls.Add(this.pizzaPrice);
            this.Controls.Add(this.pizzaSummary);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.toppings);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox toppings;
        private Button addBtn;
        private Button removeBtn;
        private Label pizzaSummary;
        private Label pizzaPrice;
    }
}