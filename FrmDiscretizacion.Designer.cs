namespace AlgoritmosGraficos
{
    partial class FrmDiscretizacion
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
            this.trkVelocidad = new System.Windows.Forms.TrackBar();
            this.lstPixeles = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // trkVelocidad
            // 
            this.trkVelocidad.LargeChange = 10;
            this.trkVelocidad.Location = new System.Drawing.Point(13, 374);
            this.trkVelocidad.Maximum = 200;
            this.trkVelocidad.Minimum = 1;
            this.trkVelocidad.Name = "trkVelocidad";
            this.trkVelocidad.Size = new System.Drawing.Size(226, 45);
            this.trkVelocidad.TabIndex = 32;
            this.trkVelocidad.TickFrequency = 10;
            this.trkVelocidad.Value = 20;
            // 
            // lstPixeles
            // 
            this.lstPixeles.FormattingEnabled = true;
            this.lstPixeles.Location = new System.Drawing.Point(13, 275);
            this.lstPixeles.Name = "lstPixeles";
            this.lstPixeles.Size = new System.Drawing.Size(226, 82);
            this.lstPixeles.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Radio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Centro:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(33, 164);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(166, 20);
            this.txtRadio.TabIndex = 25;
            // 
            // txtCentroY
            // 
            this.txtCentroY.Location = new System.Drawing.Point(144, 82);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(55, 20);
            this.txtCentroY.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "X1:";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(59, 222);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(132, 24);
            this.btnDibujar.TabIndex = 21;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // txtCentroX
            // 
            this.txtCentroX.Location = new System.Drawing.Point(59, 82);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(55, 20);
            this.txtCentroX.TabIndex = 20;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(251, 31);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(537, 388);
            this.picCanvas.TabIndex = 19;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // FrmDiscretizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trkVelocidad);
            this.Controls.Add(this.lstPixeles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtCentroY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txtCentroX);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmDiscretizacion";
            this.Text = "FrmDiscretizacion";
            ((System.ComponentModel.ISupportInitialize)(this.trkVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkVelocidad;
        private System.Windows.Forms.ListBox lstPixeles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.TextBox txtCentroX;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}