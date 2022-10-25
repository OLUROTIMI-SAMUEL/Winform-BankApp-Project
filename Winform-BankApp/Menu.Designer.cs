namespace WinFormsWEEK4Assignment
{
    partial class Menu
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
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.toolStriMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositTolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthdrwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranferTolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuIte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItm5 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chagePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.AutoSize = false;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriMenuItem1,
            this.transctionToolStripMenuItem,
            this.viewToolStripMenuIte,
            this.logoutToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(894, 24);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "ACCOUNT";
            this.menu1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStriMenuItem1
            // 
            this.toolStriMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStripMenuItem2,
            this.toolStripMenuItem,
            this.alCustomersToolStripMenuItem});
            this.toolStriMenuItem1.Name = "toolStriMenuItem1";
            this.toolStriMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.toolStriMenuItem1.Text = "ACCOUNT";
            this.toolStriMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tolStripMenuItem2
            // 
            this.tolStripMenuItem2.Name = "tolStripMenuItem2";
            this.tolStripMenuItem2.Size = new System.Drawing.Size(200, 22);
            this.tolStripMenuItem2.Text = "NEW ACCOUNT";
            this.tolStripMenuItem2.Click += new System.EventHandler(this.tolStripMenuItem2_Click);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem.Text = "Update/Search Account";
            this.toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // alCustomersToolStripMenuItem
            // 
            this.alCustomersToolStripMenuItem.Name = "alCustomersToolStripMenuItem";
            this.alCustomersToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.alCustomersToolStripMenuItem.Text = "All Customers";
            // 
            // transctionToolStripMenuItem
            // 
            this.transctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositTolStripMenuItem,
            this.widthdrwToolStripMenuItem,
            this.tranferTolStripMenuItem});
            this.transctionToolStripMenuItem.Name = "transctionToolStripMenuItem";
            this.transctionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transctionToolStripMenuItem.Text = "Transaction";
            // 
            // depositTolStripMenuItem
            // 
            this.depositTolStripMenuItem.Name = "depositTolStripMenuItem";
            this.depositTolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.depositTolStripMenuItem.Text = "Deposit";
            // 
            // widthdrwToolStripMenuItem
            // 
            this.widthdrwToolStripMenuItem.Name = "widthdrwToolStripMenuItem";
            this.widthdrwToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.widthdrwToolStripMenuItem.Text = "Widthdraw";
            // 
            // tranferTolStripMenuItem
            // 
            this.tranferTolStripMenuItem.Name = "tranferTolStripMenuItem";
            this.tranferTolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tranferTolStripMenuItem.Text = "Transfer";
            // 
            // viewToolStripMenuIte
            // 
            this.viewToolStripMenuIte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIt,
            this.toolStripMenuItm5});
            this.viewToolStripMenuIte.Name = "viewToolStripMenuIte";
            this.viewToolStripMenuIte.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuIte.Text = "View";
            this.viewToolStripMenuIte.Click += new System.EventHandler(this.viewToolStripMenuIte_Click);
            // 
            // toolStripMenuIt
            // 
            this.toolStripMenuIt.Name = "toolStripMenuIt";
            this.toolStripMenuIt.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuIt.Text = "Balance Sheet";
            this.toolStripMenuIt.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItm5
            // 
            this.toolStripMenuItm5.Name = "toolStripMenuItm5";
            this.toolStripMenuItm5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItm5.Text = "toolStripMenuItem5";
            this.toolStripMenuItm5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutStripMenuItem1,
            this.chagePasswordToolStripMenuItem,
            this.existToolStripnuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.logoutToolStripMenuItem.Text = "Others";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutStripMenuItem1
            // 
            this.logoutStripMenuItem1.Name = "logoutStripMenuItem1";
            this.logoutStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.logoutStripMenuItem1.Text = "Logout";
            // 
            // chagePasswordToolStripMenuItem
            // 
            this.chagePasswordToolStripMenuItem.Name = "chagePasswordToolStripMenuItem";
            this.chagePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chagePasswordToolStripMenuItem.Text = "Change Password";
            this.chagePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // existToolStripnuItem
            // 
            this.existToolStripnuItem.Name = "existToolStripnuItem";
            this.existToolStripnuItem.Size = new System.Drawing.Size(168, 22);
            this.existToolStripnuItem.Text = "Exist";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.menu1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menu1;
        private ToolStripMenuItem toolStriMenuItem1;
        private ToolStripMenuItem tolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem alCustomersToolStripMenuItem;
        private ToolStripMenuItem transctionToolStripMenuItem;
        private ToolStripMenuItem depositTolStripMenuItem;
        private ToolStripMenuItem widthdrwToolStripMenuItem;
        private ToolStripMenuItem tranferTolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuIte;
        private ToolStripMenuItem toolStripMenuIt;
        private ToolStripMenuItem toolStripMenuItm5;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem1;
        private ToolStripMenuItem chagePasswordToolStripMenuItem;
        private ToolStripMenuItem existToolStripnuItem;
    }
}