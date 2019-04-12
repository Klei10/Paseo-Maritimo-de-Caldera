namespace PaseoMaritimoCaldera2
{
    partial class FrmInicioSesion
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
            this.ctrInicioSesion1 = new Capa_Presentacion.CtrInicioSesion();
            this.SuspendLayout();
            // 
            // ctrInicioSesion1
            // 
            this.ctrInicioSesion1.BackColor = System.Drawing.Color.White;
            this.ctrInicioSesion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrInicioSesion1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrInicioSesion1.Location = new System.Drawing.Point(0, 0);
            this.ctrInicioSesion1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrInicioSesion1.Name = "ctrInicioSesion1";
            this.ctrInicioSesion1.Size = new System.Drawing.Size(854, 517);
            this.ctrInicioSesion1.TabIndex = 0;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 517);
            this.Controls.Add(this.ctrInicioSesion1);
            this.Name = "FrmInicioSesion";
            this.Opacity = 0.9D;
            this.Text = "FrmInicioSesion";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Presentacion.CtrInicioSesion ctrInicioSesion1;
    }
}