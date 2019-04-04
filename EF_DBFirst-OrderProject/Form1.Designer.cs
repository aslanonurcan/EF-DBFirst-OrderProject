namespace EF_DBFirst_OrderProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişGirişToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDüzeltmeGörüntülemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişGirişToolStripMenuItem1,
            this.siparişDüzeltmeGörüntülemeToolStripMenuItem1});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // siparişGirişToolStripMenuItem1
            // 
            this.siparişGirişToolStripMenuItem1.Name = "siparişGirişToolStripMenuItem1";
            this.siparişGirişToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.siparişGirişToolStripMenuItem1.Text = "Sipariş Giriş";
            this.siparişGirişToolStripMenuItem1.Click += new System.EventHandler(this.siparişGirişToolStripMenuItem1_Click);
            // 
            // siparişDüzeltmeGörüntülemeToolStripMenuItem1
            // 
            this.siparişDüzeltmeGörüntülemeToolStripMenuItem1.Name = "siparişDüzeltmeGörüntülemeToolStripMenuItem1";
            this.siparişDüzeltmeGörüntülemeToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.siparişDüzeltmeGörüntülemeToolStripMenuItem1.Text = "Sipariş Düzeltme/Görüntüleme";
            this.siparişDüzeltmeGörüntülemeToolStripMenuItem1.Click += new System.EventHandler(this.siparişDüzeltmeGörüntülemeToolStripMenuItem1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(143, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişGirişToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem siparişDüzeltmeGörüntülemeToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

