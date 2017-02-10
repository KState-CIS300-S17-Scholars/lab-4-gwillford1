namespace Lab_4
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
            this.uxFindPrimes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxEntryBox = new System.Windows.Forms.TextBox();
            this.uxResultsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxFindPrimes
            // 
            this.uxFindPrimes.Location = new System.Drawing.Point(65, 32);
            this.uxFindPrimes.Name = "uxFindPrimes";
            this.uxFindPrimes.Size = new System.Drawing.Size(75, 23);
            this.uxFindPrimes.TabIndex = 0;
            this.uxFindPrimes.Text = "Find Primes";
            this.uxFindPrimes.UseVisualStyleBackColor = true;
            this.uxFindPrimes.Click += new System.EventHandler(this.uxFindPrimes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter positive bound: ";
            // 
            // uxEntryBox
            // 
            this.uxEntryBox.Location = new System.Drawing.Point(125, 6);
            this.uxEntryBox.Name = "uxEntryBox";
            this.uxEntryBox.Size = new System.Drawing.Size(100, 20);
            this.uxEntryBox.TabIndex = 2;
            // 
            // uxResultsBox
            // 
            this.uxResultsBox.Location = new System.Drawing.Point(12, 61);
            this.uxResultsBox.Multiline = true;
            this.uxResultsBox.Name = "uxResultsBox";
            this.uxResultsBox.ReadOnly = true;
            this.uxResultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResultsBox.Size = new System.Drawing.Size(213, 174);
            this.uxResultsBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxResultsBox);
            this.Controls.Add(this.uxEntryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxFindPrimes);
            this.Name = "Form1";
            this.Text = "Sieve of Erasthones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxFindPrimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxEntryBox;
        private System.Windows.Forms.TextBox uxResultsBox;
    }
}

