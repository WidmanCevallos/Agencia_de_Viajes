namespace Agencia_de_Viajes.Views.Dasboard
{
    partial class frm_Dashboard
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
            this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destinosToolStripMenuItem,
            this.guíasToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.turistasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(832, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // destinosToolStripMenuItem
            // 
            this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            this.destinosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.destinosToolStripMenuItem.Text = "Destinos";
            this.destinosToolStripMenuItem.Click += new System.EventHandler(this.destinosToolStripMenuItem_Click);
            // 
            // guíasToolStripMenuItem
            // 
            this.guíasToolStripMenuItem.Name = "guíasToolStripMenuItem";
            this.guíasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.guíasToolStripMenuItem.Text = "Guías";
            this.guíasToolStripMenuItem.Click += new System.EventHandler(this.guíasToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.viajesToolStripMenuItem.Text = "Viajes";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // turistasToolStripMenuItem
            // 
            this.turistasToolStripMenuItem.Name = "turistasToolStripMenuItem";
            this.turistasToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.turistasToolStripMenuItem.Text = "Turistas";
            this.turistasToolStripMenuItem.Click += new System.EventHandler(this.turistasToolStripMenuItem_Click);
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 455);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Dashboard";
            this.Text = "frm_Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem destinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turistasToolStripMenuItem;
    }
}