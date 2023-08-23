namespace HelloVisualWorld
{
    partial class HelloForm
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
            this.displayOutputButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.changeOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayOutputButton
            // 
            this.displayOutputButton.Location = new System.Drawing.Point(12, 12);
            this.displayOutputButton.Name = "displayOutputButton";
            this.displayOutputButton.Size = new System.Drawing.Size(359, 100);
            this.displayOutputButton.TabIndex = 0;
            this.displayOutputButton.Text = "Click here";
            this.displayOutputButton.UseVisualStyleBackColor = true;
            this.displayOutputButton.Click += new System.EventHandler(this.DisplayOutputButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(120, 221);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(139, 20);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Hello, Visual World!";
            this.helloLabel.Visible = false;
            // 
            // changeOutputButton
            // 
            this.changeOutputButton.Enabled = false;
            this.changeOutputButton.Location = new System.Drawing.Point(12, 118);
            this.changeOutputButton.Name = "changeOutputButton";
            this.changeOutputButton.Size = new System.Drawing.Size(359, 100);
            this.changeOutputButton.TabIndex = 2;
            this.changeOutputButton.Text = "Click me last";
            this.changeOutputButton.UseVisualStyleBackColor = true;
            this.changeOutputButton.Click += new System.EventHandler(this.changeOutputButton_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 318);
            this.Controls.Add(this.changeOutputButton);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.displayOutputButton);
            this.Name = "HelloForm";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button displayOutputButton;
        private Label helloLabel;
        private Button changeOutputButton;
    }
}