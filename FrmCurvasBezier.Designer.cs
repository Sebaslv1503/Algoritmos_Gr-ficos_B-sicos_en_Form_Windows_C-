namespace AlgoritmosGraficos
{
    partial class FrmCurvasBezier
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
            this.lblTrackBar = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackBar
            // 
            this.lblTrackBar.AutoSize = true;
            this.lblTrackBar.Location = new System.Drawing.Point(317, 382);
            this.lblTrackBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrackBar.Name = "lblTrackBar";
            this.lblTrackBar.Size = new System.Drawing.Size(0, 13);
            this.lblTrackBar.TabIndex = 5;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar.Location = new System.Drawing.Point(355, 381);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar.Maximum = 45;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(78, 45);
            this.trackBar.TabIndex = 4;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(37, 28);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(723, 349);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            // 
            // FrmCurvasBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmCurvasBezier";
            this.Text = "FrmCurvasBezier";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackBar;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}