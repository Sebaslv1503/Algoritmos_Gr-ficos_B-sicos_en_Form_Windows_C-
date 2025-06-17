namespace AlgoritmosGraficos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDiscretizacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDDAToolStripMenuItem,
            this.algoritmoBresenhamToolStripMenuItem,
            this.algoritmoDiscretizacToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.algoritmoDDAToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem_Click);
            // 
            // algoritmoBresenhamToolStripMenuItem
            // 
            this.algoritmoBresenhamToolStripMenuItem.Name = "algoritmoBresenhamToolStripMenuItem";
            this.algoritmoBresenhamToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.algoritmoBresenhamToolStripMenuItem.Text = "Algoritmo Bresenham";
            this.algoritmoBresenhamToolStripMenuItem.Click += new System.EventHandler(this.algoritmoBresenhamToolStripMenuItem_Click);
            // 
            // algoritmoDiscretizacToolStripMenuItem
            // 
            this.algoritmoDiscretizacToolStripMenuItem.Name = "algoritmoDiscretizacToolStripMenuItem";
            this.algoritmoDiscretizacToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.algoritmoDiscretizacToolStripMenuItem.Text = "Circulo e Inundación";
            this.algoritmoDiscretizacToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDiscretizacToolStripMenuItem_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 24);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 426);
            this.panelContenedor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDiscretizacToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

