namespace WinFormsWEEK4Assignment
{
    partial class LoginForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AccountNumberText = new System.Windows.Forms.TextBox();
            this.PassWordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "SIGN IN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountNumberText
            // 
            this.AccountNumberText.Location = new System.Drawing.Point(143, 141);
            this.AccountNumberText.Multiline = true;
            this.AccountNumberText.Name = "AccountNumberText";
            this.AccountNumberText.Size = new System.Drawing.Size(340, 42);
            this.AccountNumberText.TabIndex = 2;
            this.AccountNumberText.Text = "sffdg";
            // 
            // PassWordText
            // 
            this.PassWordText.Location = new System.Drawing.Point(156, 343);
            this.PassWordText.Multiline = true;
            this.PassWordText.Name = "PassWordText";
            this.PassWordText.Size = new System.Drawing.Size(314, 34);
            this.PassWordText.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassWordText);
            this.Controls.Add(this.AccountNumberText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox AccountNumberText;
        private TextBox PassWordText;
    }
}