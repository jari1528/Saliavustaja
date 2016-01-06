namespace Saliavustaja
{
    partial class Saliavustaja
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
            this.Valikko = new System.Windows.Forms.ToolStripMenuItem();
            this.ValikkoUusiTilaus = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TilausLista = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Valikko});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Valikko
            // 
            this.Valikko.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ValikkoUusiTilaus,
            this.lopetaToolStripMenuItem});
            this.Valikko.Name = "Valikko";
            this.Valikko.Size = new System.Drawing.Size(69, 24);
            this.Valikko.Text = "Valikko";
            // 
            // ValikkoUusiTilaus
            // 
            this.ValikkoUusiTilaus.Name = "ValikkoUusiTilaus";
            this.ValikkoUusiTilaus.Size = new System.Drawing.Size(181, 26);
            this.ValikkoUusiTilaus.Text = "Uusi Tilaus";
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            // 
            // TilausLista
            // 
            this.TilausLista.Location = new System.Drawing.Point(12, 134);
            this.TilausLista.Name = "TilausLista";
            this.TilausLista.Size = new System.Drawing.Size(676, 373);
            this.TilausLista.TabIndex = 1;
            this.TilausLista.UseCompatibleStateImageBehavior = false;
            // 
            // Saliavustaja
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 519);
            this.Controls.Add(this.TilausLista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Saliavustaja";
            this.Text = "Saliavustaja v.01";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Valikko;
        private System.Windows.Forms.ToolStripMenuItem ValikkoUusiTilaus;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ListView TilausLista;
    }
}

