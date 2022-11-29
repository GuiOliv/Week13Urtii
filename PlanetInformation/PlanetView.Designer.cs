namespace PlanetInformation
{
    partial class PlanetView
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
            this.MercuryBtn = new System.Windows.Forms.Button();
            this.VenusBtn = new System.Windows.Forms.Button();
            this.EarthBtn = new System.Windows.Forms.Button();
            this.MarsBtn = new System.Windows.Forms.Button();
            this.JupiterBtn = new System.Windows.Forms.Button();
            this.labelGravity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MercuryBtn
            // 
            this.MercuryBtn.Location = new System.Drawing.Point(54, 40);
            this.MercuryBtn.Name = "MercuryBtn";
            this.MercuryBtn.Size = new System.Drawing.Size(244, 46);
            this.MercuryBtn.TabIndex = 0;
            this.MercuryBtn.Text = "Mercury";
            this.MercuryBtn.UseVisualStyleBackColor = true;
            this.MercuryBtn.Click += new System.EventHandler(this.MercuryBtn_Click);
            // 
            // VenusBtn
            // 
            this.VenusBtn.Location = new System.Drawing.Point(54, 133);
            this.VenusBtn.Name = "VenusBtn";
            this.VenusBtn.Size = new System.Drawing.Size(244, 46);
            this.VenusBtn.TabIndex = 1;
            this.VenusBtn.Text = "Venus";
            this.VenusBtn.UseVisualStyleBackColor = true;
            this.VenusBtn.Click += new System.EventHandler(this.VenusBtn_Click);
            // 
            // EarthBtn
            // 
            this.EarthBtn.Location = new System.Drawing.Point(54, 226);
            this.EarthBtn.Name = "EarthBtn";
            this.EarthBtn.Size = new System.Drawing.Size(244, 46);
            this.EarthBtn.TabIndex = 2;
            this.EarthBtn.Text = "Earth";
            this.EarthBtn.UseVisualStyleBackColor = true;
            this.EarthBtn.Click += new System.EventHandler(this.EarthBtn_Click);
            // 
            // MarsBtn
            // 
            this.MarsBtn.Location = new System.Drawing.Point(54, 318);
            this.MarsBtn.Name = "MarsBtn";
            this.MarsBtn.Size = new System.Drawing.Size(244, 46);
            this.MarsBtn.TabIndex = 3;
            this.MarsBtn.Text = "Mars";
            this.MarsBtn.UseVisualStyleBackColor = true;
            this.MarsBtn.Click += new System.EventHandler(this.MarsBtn_Click);
            // 
            // JupiterBtn
            // 
            this.JupiterBtn.Location = new System.Drawing.Point(54, 413);
            this.JupiterBtn.Name = "JupiterBtn";
            this.JupiterBtn.Size = new System.Drawing.Size(244, 46);
            this.JupiterBtn.TabIndex = 4;
            this.JupiterBtn.Text = "Jupiter";
            this.JupiterBtn.UseVisualStyleBackColor = true;
            this.JupiterBtn.Click += new System.EventHandler(this.JupiterBtn_Click);
            // 
            // labelGravity
            // 
            this.labelGravity.AutoSize = true;
            this.labelGravity.Location = new System.Drawing.Point(434, 240);
            this.labelGravity.Name = "labelGravity";
            this.labelGravity.Size = new System.Drawing.Size(0, 32);
            this.labelGravity.TabIndex = 5;
            // 
            // PlanetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 561);
            this.Controls.Add(this.labelGravity);
            this.Controls.Add(this.JupiterBtn);
            this.Controls.Add(this.MarsBtn);
            this.Controls.Add(this.EarthBtn);
            this.Controls.Add(this.VenusBtn);
            this.Controls.Add(this.MercuryBtn);
            this.Name = "PlanetView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MercuryBtn;
        private Button VenusBtn;
        private Button EarthBtn;
        private Button MarsBtn;
        private Button JupiterBtn;
        private Label labelGravity;
    }
}