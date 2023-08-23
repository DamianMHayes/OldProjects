namespace WarCardGameGUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.DealButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.labelGame = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealButton
            // 
            this.DealButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DealButton.Location = new System.Drawing.Point(158, 232);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(129, 69);
            this.DealButton.TabIndex = 0;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.Deal_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(33, 232);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(119, 69);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Visible = false;
            this.PlayButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGame.Location = new System.Drawing.Point(12, 9);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(423, 210);
            this.labelGame.TabIndex = 2;
            this.labelGame.Text = resources.GetString("labelGame.Text");
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndButton.Location = new System.Drawing.Point(293, 232);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(119, 69);
            this.EndButton.TabIndex = 3;
            this.EndButton.Text = "END";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Visible = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(450, 328);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DealButton);
            this.Name = "Form2";
            this.Text = "War Card Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DealButton;
        private Button PlayButton;
        private Label labelGame;
        private Button EndButton;
    }
}