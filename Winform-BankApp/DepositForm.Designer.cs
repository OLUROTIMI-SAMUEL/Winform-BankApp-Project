namespace WinFormsWEEK4Assignment
{
    partial class DepositForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the amount in Naira you wish to deposit";
            // 
            // textBoxes
            // 
            this.textBoxes.Location = new System.Drawing.Point(187, 123);
            this.textBoxes.Multiline = true;
            this.textBoxes.Name = "textBoxes";
            this.textBoxes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxes.Size = new System.Drawing.Size(402, 39);
            this.textBoxes.TabIndex = 1;
            this.textBoxes.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thank you. Your money \"accountBalance\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxes);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxes;
        private Label label2;
        private Button button1;
    }
}