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
            this.smsMode = new System.Windows.Forms.ComboBox();
            this.getNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(12, 12);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(192, 20);
            this.apiKey.TabIndex = 0;
            this.apiKey.Text = "Api Client Key";
            // 
            // apiSecret
            // 
            this.apiSecret.Location = new System.Drawing.Point(12, 38);
            this.apiSecret.Name = "apiSecret";
            this.apiSecret.Size = new System.Drawing.Size(192, 20);
            this.apiSecret.TabIndex = 1;
            this.apiSecret.Text = "Api Client Secret";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 91);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(301, 47);
            this.outputBox.TabIndex = 2;
            // 
            // getBalance
            // 
            this.getBalance.Location = new System.Drawing.Point(210, 11);
            this.getBalance.Name = "getBalance";
            this.getBalance.Size = new System.Drawing.Size(103, 21);
            this.getBalance.TabIndex = 3;
            this.getBalance.Text = "Get Balance";
            this.getBalance.UseVisualStyleBackColor = true;
            this.getBalance.Click += new System.EventHandler(this.getBalance_Click);
            // 
            // smsMode
            // 
            this.smsMode.FormattingEnabled = true;
            this.smsMode.Items.AddRange(new object[] {
            "Redeem",
            "Unlock"});
            this.smsMode.Location = new System.Drawing.Point(12, 64);
            this.smsMode.Name = "smsMode";
            this.smsMode.Size = new System.Drawing.Size(192, 21);
            this.smsMode.TabIndex = 4;
            this.smsMode.Text = "Select SMS mode";
            this.smsMode.SelectedIndexChanged += new System.EventHandler(this.smsMode_SelectedIndexChanged);
            // 
            // getNumber
            // 
            this.getNumber.Location = new System.Drawing.Point(210, 38);
            this.getNumber.Name = "getNumber";
            this.getNumber.Size = new System.Drawing.Size(103, 47);
            this.getNumber.TabIndex = 5;
            this.getNumber.Text = "Get Number";
            this.getNumber.UseVisualStyleBackColor = true;
            this.getNumber.Click += new System.EventHandler(this.getNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 154);
            this.Controls.Add(this.getNumber);
            this.Controls.Add(this.smsMode);
            this.Controls.Add(this.getBalance);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.apiSecret);
            this.Controls.Add(this.apiKey);
            this.Name = "Form1";
            this.Text = "TextVerified API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.TextBox apiSecret;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button getBalance;
        private System.Windows.Forms.ComboBox smsMode;
        private System.Windows.Forms.Button getNumber;
    }
}

