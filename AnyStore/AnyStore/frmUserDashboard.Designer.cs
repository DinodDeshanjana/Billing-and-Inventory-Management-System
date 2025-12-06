namespace AnyStore
{
    partial class frmUserDashboard
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAppheading = new System.Windows.Forms.Label();
            this.labelAppname2 = new System.Windows.Forms.Label();
            this.labelAppname = new System.Windows.Forms.Label();
            this.labelLoginuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.label1Footer = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1505, 28);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesFormsToolStripMenuItem
            // 
            this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.salesFormsToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // labelAppheading
            // 
            this.labelAppheading.AutoSize = true;
            this.labelAppheading.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppheading.ForeColor = System.Drawing.Color.Teal;
            this.labelAppheading.Location = new System.Drawing.Point(823, 420);
            this.labelAppheading.Name = "labelAppheading";
            this.labelAppheading.Size = new System.Drawing.Size(415, 32);
            this.labelAppheading.TabIndex = 12;
            this.labelAppheading.Text = "Billing and Inventory Management";
            // 
            // labelAppname2
            // 
            this.labelAppname2.AutoSize = true;
            this.labelAppname2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppname2.Location = new System.Drawing.Point(1004, 374);
            this.labelAppname2.Name = "labelAppname2";
            this.labelAppname2.Size = new System.Drawing.Size(124, 46);
            this.labelAppname2.TabIndex = 11;
            this.labelAppname2.Text = "STORE";
            // 
            // labelAppname
            // 
            this.labelAppname.AutoSize = true;
            this.labelAppname.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppname.Location = new System.Drawing.Point(923, 374);
            this.labelAppname.Name = "labelAppname";
            this.labelAppname.Size = new System.Drawing.Size(86, 46);
            this.labelAppname.TabIndex = 10;
            this.labelAppname.Text = "ANY";
            // 
            // labelLoginuser
            // 
            this.labelLoginuser.AutoSize = true;
            this.labelLoginuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginuser.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLoginuser.Location = new System.Drawing.Point(72, 41);
            this.labelLoginuser.Name = "labelLoginuser";
            this.labelLoginuser.Size = new System.Drawing.Size(185, 28);
            this.labelLoginuser.TabIndex = 9;
            this.labelLoginuser.Text = "Dinod Deshanjana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "User:";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelFooter.Controls.Add(this.label1Footer);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 657);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(1505, 43);
            this.PanelFooter.TabIndex = 7;
            // 
            // label1Footer
            // 
            this.label1Footer.AutoSize = true;
            this.label1Footer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Footer.ForeColor = System.Drawing.Color.White;
            this.label1Footer.Location = new System.Drawing.Point(913, 11);
            this.label1Footer.Name = "label1Footer";
            this.label1Footer.Size = new System.Drawing.Size(276, 23);
            this.label1Footer.TabIndex = 0;
            this.label1Footer.Text = "Developed By: Dinod Deshanjana";
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 700);
            this.Controls.Add(this.labelAppheading);
            this.Controls.Add(this.labelAppname2);
            this.Controls.Add(this.labelAppname);
            this.Controls.Add(this.labelLoginuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            this.PanelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label labelAppheading;
        private System.Windows.Forms.Label labelAppname2;
        private System.Windows.Forms.Label labelAppname;
        private System.Windows.Forms.Label labelLoginuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Label label1Footer;
    }
}