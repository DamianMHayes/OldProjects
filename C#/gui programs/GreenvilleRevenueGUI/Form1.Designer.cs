namespace GreenvilleRevenueGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.labelComparison = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Greenville Revenue Calculator";
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(12, 95);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 23);
            this.textBoxLast.TabIndex = 1;
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Location = new System.Drawing.Point(12, 151);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(100, 23);
            this.textBoxCurrent.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter number of contestants last year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter number of contestants this year";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCount.Location = new System.Drawing.Point(12, 220);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(419, 15);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Last year\'s competition had {0} contestants, and this year\'s has {1} contestants." +
    "";
            this.labelCount.Visible = false;
            // 
            // labelRevenue
            // 
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Location = new System.Drawing.Point(12, 245);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(178, 15);
            this.labelRevenue.TabIndex = 8;
            this.labelRevenue.Text = "Revenue expected this year is {0}";
            this.labelRevenue.Visible = false;
            // 
            // labelComparison
            // 
            this.labelComparison.AutoSize = true;
            this.labelComparison.Location = new System.Drawing.Point(12, 270);
            this.labelComparison.Name = "labelComparison";
            this.labelComparison.Size = new System.Drawing.Size(321, 15);
            this.labelComparison.TabIndex = 9;
            this.labelComparison.Text = "It is {0} that this year\'s competition is bigger than last year\'s.";
            this.labelComparison.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 347);
            this.Controls.Add(this.labelComparison);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCurrent);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Greenville Revenue Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxLast;
        private TextBox textBoxCurrent;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label labelCount;
        private Label labelRevenue;
        private Label labelComparison;
    }
}