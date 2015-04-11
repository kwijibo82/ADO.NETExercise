namespace PreparacionExamenExtraAD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEspecialitatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconnectatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEspecialitatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobToolStripMenuItem,
            this.desconnectatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cobToolStripMenuItem
            // 
            this.cobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarEspecialitatToolStripMenuItem});
            this.cobToolStripMenuItem.Name = "cobToolStripMenuItem";
            this.cobToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cobToolStripMenuItem.Text = "Connectat";
            // 
            // modificarEspecialitatToolStripMenuItem
            // 
            this.modificarEspecialitatToolStripMenuItem.Name = "modificarEspecialitatToolStripMenuItem";
            this.modificarEspecialitatToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modificarEspecialitatToolStripMenuItem.Text = "Modificar especialitat";
            this.modificarEspecialitatToolStripMenuItem.Click += new System.EventHandler(this.modificarEspecialitatToolStripMenuItem_Click);
            // 
            // desconnectatToolStripMenuItem
            // 
            this.desconnectatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarEspecialitatToolStripMenuItem1});
            this.desconnectatToolStripMenuItem.Name = "desconnectatToolStripMenuItem";
            this.desconnectatToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.desconnectatToolStripMenuItem.Text = "Desconnectat";
            // 
            // modificarEspecialitatToolStripMenuItem1
            // 
            this.modificarEspecialitatToolStripMenuItem1.Name = "modificarEspecialitatToolStripMenuItem1";
            this.modificarEspecialitatToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.modificarEspecialitatToolStripMenuItem1.Text = "Modificar especialitat";
            this.modificarEspecialitatToolStripMenuItem1.Click += new System.EventHandler(this.modificarEspecialitatToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 295);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Examen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEspecialitatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconnectatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEspecialitatToolStripMenuItem1;
    }
}

