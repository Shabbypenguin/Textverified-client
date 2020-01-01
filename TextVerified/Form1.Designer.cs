namespace TextVerified
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
            this.apiKey = new System.Windows.Forms.TextBox();
            this.apiSecret = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.getBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(19, 26);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(192, 20);
            this.apiKey.TabIndex = 0;
            this.apiKey.Text = "Api Client Key";
            // 
            // apiSecret
            // 
            this.apiSecret.Location = new System.Drawing.Point(19, 52);
            this.apiSecret.Name = "apiSecret";
            this.apiSecret.Size = new System.Drawing.Size(192, 20);
            this.apiSecret.TabIndex = 1;
            this.apiSecret.Text = "Api Client Secret";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(19, 99);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(192, 328);
            this.outputBox.TabIndex = 2;
            // 
            // getBalance
            // 
            this.getBalance.Location = new System.Drawing.Point(235, 24);
            this.getBalance.Name = "getBalance";
            this.getBalance.Size = new System.Drawing.Size(103, 21);
            this.getBalance.TabIndex = 3;
            this.getBalance.Text = "Get Balance";
            this.getBalance.UseVisualStyleBackColor = true;
            this.getBalance.Click += new System.EventHandler(this.getBalance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.getBalance);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.apiSecret);
            this.Controls.Add(this.apiKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.TextBox apiSecret;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button getBalance;
    }
}

