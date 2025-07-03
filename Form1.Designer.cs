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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.rasterizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDDAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBresenhamLineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBresenhamElipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBresenhamElipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCohenSutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSutherlandHodgmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasParamétricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasDeBézierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rasterizacionToolStripMenuItem,
            this.rellenoToolStripMenuItem,
            this.recorteToolStripMenuItem,
            this.curvasParamétricosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 24);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 426);
            this.panelContenedor.TabIndex = 1;
            // 
            // rasterizacionToolStripMenuItem
            // 
            this.rasterizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDDAToolStripMenuItem1,
            this.aBresenhamLineasToolStripMenuItem,
            this.aBresenhamElipsesToolStripMenuItem,
            this.aBresenhamElipseToolStripMenuItem});
            this.rasterizacionToolStripMenuItem.Name = "rasterizacionToolStripMenuItem";
            this.rasterizacionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.rasterizacionToolStripMenuItem.Text = "Rasterizacion";
            // 
            // algoritmoDDAToolStripMenuItem1
            // 
            this.algoritmoDDAToolStripMenuItem1.Name = "algoritmoDDAToolStripMenuItem1";
            this.algoritmoDDAToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.algoritmoDDAToolStripMenuItem1.Text = "A. DDA";
            this.algoritmoDDAToolStripMenuItem1.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem1_Click);
            // 
            // aBresenhamLineasToolStripMenuItem
            // 
            this.aBresenhamLineasToolStripMenuItem.Name = "aBresenhamLineasToolStripMenuItem";
            this.aBresenhamLineasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aBresenhamLineasToolStripMenuItem.Text = "A. Bresenham Lineas";
            this.aBresenhamLineasToolStripMenuItem.Click += new System.EventHandler(this.aBresenhamLineasToolStripMenuItem_Click);
            // 
            // aBresenhamElipsesToolStripMenuItem
            // 
            this.aBresenhamElipsesToolStripMenuItem.Name = "aBresenhamElipsesToolStripMenuItem";
            this.aBresenhamElipsesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBresenhamElipsesToolStripMenuItem.Text = "A. Bresenham Circunferencias";
            this.aBresenhamElipsesToolStripMenuItem.Click += new System.EventHandler(this.aBresenhamElipsesToolStripMenuItem_Click);
            // 
            // aBresenhamElipseToolStripMenuItem
            // 
            this.aBresenhamElipseToolStripMenuItem.Name = "aBresenhamElipseToolStripMenuItem";
            this.aBresenhamElipseToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBresenhamElipseToolStripMenuItem.Text = "A. Bresenham Elipse";
            this.aBresenhamElipseToolStripMenuItem.Click += new System.EventHandler(this.aBresenhamElipseToolStripMenuItem_Click);
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floodFillToolStripMenuItem,
            this.scanlineToolStripMenuItem});
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floodFillToolStripMenuItem.Text = "Flood Fill";
            this.floodFillToolStripMenuItem.Click += new System.EventHandler(this.floodFillToolStripMenuItem_Click);
            // 
            // scanlineToolStripMenuItem
            // 
            this.scanlineToolStripMenuItem.Name = "scanlineToolStripMenuItem";
            this.scanlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scanlineToolStripMenuItem.Text = "Scanline";
            this.scanlineToolStripMenuItem.Click += new System.EventHandler(this.scanlineToolStripMenuItem_Click);
            // 
            // recorteToolStripMenuItem
            // 
            this.recorteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCohenSutherlandToolStripMenuItem,
            this.aSutherlandHodgmanToolStripMenuItem});
            this.recorteToolStripMenuItem.Name = "recorteToolStripMenuItem";
            this.recorteToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.recorteToolStripMenuItem.Text = "Recorte";
            // 
            // aCohenSutherlandToolStripMenuItem
            // 
            this.aCohenSutherlandToolStripMenuItem.Name = "aCohenSutherlandToolStripMenuItem";
            this.aCohenSutherlandToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aCohenSutherlandToolStripMenuItem.Text = "A. Cohen-Sutherland";
            // 
            // aSutherlandHodgmanToolStripMenuItem
            // 
            this.aSutherlandHodgmanToolStripMenuItem.Name = "aSutherlandHodgmanToolStripMenuItem";
            this.aSutherlandHodgmanToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aSutherlandHodgmanToolStripMenuItem.Text = "A. Sutherland-Hodgman";
            // 
            // curvasParamétricosToolStripMenuItem
            // 
            this.curvasParamétricosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvasDeBézierToolStripMenuItem,
            this.bsplineToolStripMenuItem});
            this.curvasParamétricosToolStripMenuItem.Name = "curvasParamétricosToolStripMenuItem";
            this.curvasParamétricosToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.curvasParamétricosToolStripMenuItem.Text = "Curvas Paramétricos";
            // 
            // curvasDeBézierToolStripMenuItem
            // 
            this.curvasDeBézierToolStripMenuItem.Name = "curvasDeBézierToolStripMenuItem";
            this.curvasDeBézierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.curvasDeBézierToolStripMenuItem.Text = "Curvas de Bézier";
            // 
            // bsplineToolStripMenuItem
            // 
            this.bsplineToolStripMenuItem.Name = "bsplineToolStripMenuItem";
            this.bsplineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bsplineToolStripMenuItem.Text = "B-spline";
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
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem rasterizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBresenhamLineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBresenhamElipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBresenhamElipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCohenSutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSutherlandHodgmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasParamétricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasDeBézierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bsplineToolStripMenuItem;
    }
}

