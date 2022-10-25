namespace WinFormsWEEK4Assignment
{
    partial class NewAccount
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
            this.labelfirst = new System.Windows.Forms.Label();
            this.labelED = new System.Windows.Forms.Label();
            this.labelFOURTH = new System.Windows.Forms.Label();
            this.labeling = new System.Windows.Forms.Label();
            this.textBoxFIRST = new System.Windows.Forms.TextBox();
            this.textBoxFOURTH = new System.Windows.Forms.TextBox();
            this.textBoxTHIRD = new System.Windows.Forms.TextBox();
            this.textBoxSECOND = new System.Windows.Forms.TextBox();
            this.buttonFIRST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(352, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information Form";
            // 
            // labelfirst
            // 
            this.labelfirst.AutoSize = true;
            this.labelfirst.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelfirst.Location = new System.Drawing.Point(124, 94);
            this.labelfirst.Name = "labelfirst";
            this.labelfirst.Size = new System.Drawing.Size(119, 25);
            this.labelfirst.TabIndex = 1;
            this.labelfirst.Text = "FULLNAME :";
            // 
            // labelED
            // 
            this.labelED.AutoSize = true;
            this.labelED.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelED.Location = new System.Drawing.Point(124, 179);
            this.labelED.Name = "labelED";
            this.labelED.Size = new System.Drawing.Size(128, 25);
            this.labelED.TabIndex = 2;
            this.labelED.Text = "USER NAME :";
            // 
            // labelFOURTH
            // 
            this.labelFOURTH.AutoSize = true;
            this.labelFOURTH.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFOURTH.Location = new System.Drawing.Point(124, 249);
            this.labelFOURTH.Name = "labelFOURTH";
            this.labelFOURTH.Size = new System.Drawing.Size(143, 25);
            this.labelFOURTH.TabIndex = 3;
            this.labelFOURTH.Text = "ACCUNT TYPE :";
            this.labelFOURTH.Click += new System.EventHandler(this.label4_Click);
            // 
            // labeling
            // 
            this.labeling.AutoSize = true;
            this.labeling.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeling.Location = new System.Drawing.Point(124, 331);
            this.labeling.Name = "labeling";
            this.labeling.Size = new System.Drawing.Size(150, 25);
            this.labeling.TabIndex = 4;
            this.labeling.Text = "FIRST DEPOSIT :";
            this.labeling.Click += new System.EventHandler(this.labeling_Click);
            // 
            // textBoxFIRST
            // 
            this.textBoxFIRST.Location = new System.Drawing.Point(287, 94);
            this.textBoxFIRST.Multiline = true;
            this.textBoxFIRST.Name = "textBoxFIRST";
            this.textBoxFIRST.Size = new System.Drawing.Size(469, 35);
            this.textBoxFIRST.TabIndex = 5;
            this.textBoxFIRST.TextChanged += new System.EventHandler(this.textBoxFIRST_TextChanged);
            // 
            // textBoxFOURTH
            // 
            this.textBoxFOURTH.Location = new System.Drawing.Point(287, 322);
            this.textBoxFOURTH.Multiline = true;
            this.textBoxFOURTH.Name = "textBoxFOURTH";
            this.textBoxFOURTH.Size = new System.Drawing.Size(469, 37);
            this.textBoxFOURTH.TabIndex = 6;
            this.textBoxFOURTH.TextChanged += new System.EventHandler(this.textBoxFOURTH_TextChanged);
            // 
            // textBoxTHIRD
            // 
            this.textBoxTHIRD.Location = new System.Drawing.Point(287, 249);
            this.textBoxTHIRD.Multiline = true;
            this.textBoxTHIRD.Name = "textBoxTHIRD";
            this.textBoxTHIRD.Size = new System.Drawing.Size(469, 37);
            this.textBoxTHIRD.TabIndex = 7;
            this.textBoxTHIRD.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxSECOND
            // 
            this.textBoxSECOND.Location = new System.Drawing.Point(287, 167);
            this.textBoxSECOND.Multiline = true;
            this.textBoxSECOND.Name = "textBoxSECOND";
            this.textBoxSECOND.Size = new System.Drawing.Size(469, 37);
            this.textBoxSECOND.TabIndex = 8;
            // 
            // buttonFIRST
            // 
            this.buttonFIRST.Location = new System.Drawing.Point(396, 385);
            this.buttonFIRST.Name = "buttonFIRST";
            this.buttonFIRST.Size = new System.Drawing.Size(160, 39);
            this.buttonFIRST.TabIndex = 9;
            this.buttonFIRST.Text = "CREATE ACCOUNT ";
            this.buttonFIRST.UseVisualStyleBackColor = true;
            this.buttonFIRST.Click += new System.EventHandler(this.buttonFIRST_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.buttonFIRST);
            this.Controls.Add(this.textBoxSECOND);
            this.Controls.Add(this.textBoxTHIRD);
            this.Controls.Add(this.textBoxFOURTH);
            this.Controls.Add(this.textBoxFIRST);
            this.Controls.Add(this.labeling);
            this.Controls.Add(this.labelFOURTH);
            this.Controls.Add(this.labelED);
            this.Controls.Add(this.labelfirst);
            this.Controls.Add(this.label1);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelfirst;
        private Label labelED;
        private Label labelFOURTH;
        private Label labeling;
        private TextBox textBoxFIRST;
        private TextBox textBoxFOURTH;
        private TextBox textBoxTHIRD;
        private TextBox textBoxSECOND;
        private Button buttonFIRST;
    }
}