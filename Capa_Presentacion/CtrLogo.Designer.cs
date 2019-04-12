namespace Capa_Presentacion
{
    partial class CtrLogo
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrLogo));
            this.PictLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictLogo
            // 
            this.PictLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictLogo.Image")));
            this.PictLogo.Location = new System.Drawing.Point(108, 70);
            this.PictLogo.Name = "PictLogo";
            this.PictLogo.Size = new System.Drawing.Size(218, 139);
            this.PictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictLogo.TabIndex = 0;
            this.PictLogo.TabStop = false;
            // 
            // CtrLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictLogo);
            this.Name = "CtrLogo";
            this.Size = new System.Drawing.Size(435, 278);
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictLogo;
    }
}
