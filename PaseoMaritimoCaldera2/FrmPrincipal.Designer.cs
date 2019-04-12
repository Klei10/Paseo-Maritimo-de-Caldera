namespace PaseoMaritimoCaldera2
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.BtnInforme = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnServicios = new System.Windows.Forms.Button();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.TimerOcultar = new System.Windows.Forms.Timer(this.components);
            this.TimerMostrar = new System.Windows.Forms.Timer(this.components);
            this.TimerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.PanelPrincipal.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.PanelPrincipal.Controls.Add(this.PanelCentral);
            this.PanelPrincipal.Controls.Add(this.PanelInferior);
            this.PanelPrincipal.Controls.Add(this.PanelIzquierdo);
            this.PanelPrincipal.Controls.Add(this.PanelSuperior);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1100, 600);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.White;
            this.PanelCentral.Location = new System.Drawing.Point(230, 35);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(870, 465);
            this.PanelCentral.TabIndex = 4;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelInferior.Controls.Add(this.LblFecha);
            this.PanelInferior.Controls.Add(this.LblHora);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(230, 500);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(870, 100);
            this.PanelInferior.TabIndex = 3;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(553, 72);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(185, 22);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Martes, 1 enero 2019";
            this.LblFecha.TextChanged += new System.EventHandler(this.LblFecha_TextChanged);
            // 
            // LblHora
            // 
            this.LblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Transparent;
            this.LblHora.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Location = new System.Drawing.Point(547, 3);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(200, 55);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "21:49:45";
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PanelIzquierdo.Controls.Add(this.BtnInforme);
            this.PanelIzquierdo.Controls.Add(this.BtnInventario);
            this.PanelIzquierdo.Controls.Add(this.BtnVentas);
            this.PanelIzquierdo.Controls.Add(this.BtnServicios);
            this.PanelIzquierdo.Controls.Add(this.BtnIniciarSesion);
            this.PanelIzquierdo.Controls.Add(this.BtnMenu);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 35);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(230, 565);
            this.PanelIzquierdo.TabIndex = 2;
            this.PanelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelIzquierdo_Paint);
            // 
            // BtnInforme
            // 
            this.BtnInforme.BackColor = System.Drawing.Color.Transparent;
            this.BtnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInforme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInforme.ForeColor = System.Drawing.Color.White;
            this.BtnInforme.Image = ((System.Drawing.Image)(resources.GetObject("BtnInforme.Image")));
            this.BtnInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInforme.Location = new System.Drawing.Point(0, 388);
            this.BtnInforme.Name = "BtnInforme";
            this.BtnInforme.Size = new System.Drawing.Size(230, 77);
            this.BtnInforme.TabIndex = 4;
            this.BtnInforme.Text = " Informe Diario";
            this.BtnInforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInforme.UseVisualStyleBackColor = true;
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.White;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(0, 311);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(230, 77);
            this.BtnInventario.TabIndex = 3;
            this.BtnInventario.Text = " Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // BtnVentas
            // 
            this.BtnVentas.BackColor = System.Drawing.Color.Transparent;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = ((System.Drawing.Image)(resources.GetObject("BtnVentas.Image")));
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 234);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(230, 77);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = " Tienda";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = true;
            // 
            // BtnServicios
            // 
            this.BtnServicios.BackColor = System.Drawing.Color.Transparent;
            this.BtnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicios.ForeColor = System.Drawing.Color.White;
            this.BtnServicios.Image = ((System.Drawing.Image)(resources.GetObject("BtnServicios.Image")));
            this.BtnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServicios.Location = new System.Drawing.Point(0, 157);
            this.BtnServicios.Name = "BtnServicios";
            this.BtnServicios.Size = new System.Drawing.Size(230, 77);
            this.BtnServicios.TabIndex = 1;
            this.BtnServicios.Text = " Servicios";
            this.BtnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServicios.UseVisualStyleBackColor = true;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnIniciarSesion.Image")));
            this.BtnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(0, 80);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(230, 77);
            this.BtnIniciarSesion.TabIndex = 0;
            this.BtnIniciarSesion.Text = " Iniciar Sesión";
            this.BtnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(181, 2);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 37);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelSuperior.Controls.Add(this.label1);
            this.PanelSuperior.Controls.Add(this.pictureBox1);
            this.PanelSuperior.Controls.Add(this.BtnMinimizar);
            this.PanelSuperior.Controls.Add(this.BtnMaximizar);
            this.PanelSuperior.Controls.Add(this.BtnCerrar);
            this.PanelSuperior.Controls.Add(this.BtnRestaurar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1100, 35);
            this.PanelSuperior.TabIndex = 1;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Paseo Marítimo de Caldera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1001, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(1032, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1070, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(1032, 3);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.UseVisualStyleBackColor = true;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // TimerOcultar
            // 
            this.TimerOcultar.Tick += new System.EventHandler(this.TimerOcultar_Tick);
            // 
            // TimerMostrar
            // 
            this.TimerMostrar.Tick += new System.EventHandler(this.TimerMostrar_Tick);
            // 
            // TimerFechaHora
            // 
            this.TimerFechaHora.Enabled = true;
            this.TimerFechaHora.Tick += new System.EventHandler(this.TimerFechaHora_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.PanelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnRestaurar;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Timer TimerOcultar;
        private System.Windows.Forms.Timer TimerMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnServicios;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnInforme;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer TimerFechaHora;
    }
}

