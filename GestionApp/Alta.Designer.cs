namespace GestionApp
{
    partial class frmAlta
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
            this.lblCodigoArt = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbCodigoArticulo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbUrlImagen = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pbAlta = new System.Windows.Forms.PictureBox();
            this.btnAgregarAlta = new System.Windows.Forms.Button();
            this.btnModificarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoArt
            // 
            this.lblCodigoArt.AutoSize = true;
            this.lblCodigoArt.Location = new System.Drawing.Point(0, 18);
            this.lblCodigoArt.Name = "lblCodigoArt";
            this.lblCodigoArt.Size = new System.Drawing.Size(74, 13);
            this.lblCodigoArt.TabIndex = 0;
            this.lblCodigoArt.Text = "Codigo de Art.";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(0, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(0, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(0, 96);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(0, 122);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(0, 148);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(73, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "Imagen (URL)";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(0, 175);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // tbCodigoArticulo
            // 
            this.tbCodigoArticulo.Location = new System.Drawing.Point(80, 15);
            this.tbCodigoArticulo.Name = "tbCodigoArticulo";
            this.tbCodigoArticulo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoArticulo.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(80, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(80, 67);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 2;
            // 
            // tbUrlImagen
            // 
            this.tbUrlImagen.Location = new System.Drawing.Point(80, 145);
            this.tbUrlImagen.Name = "tbUrlImagen";
            this.tbUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.tbUrlImagen.TabIndex = 5;
            this.tbUrlImagen.Leave += new System.EventHandler(this.tbUrlImagen_Leave);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(80, 172);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 6;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(80, 93);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(100, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(80, 118);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(100, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // pbAlta
            // 
            this.pbAlta.Location = new System.Drawing.Point(196, 15);
            this.pbAlta.Name = "pbAlta";
            this.pbAlta.Size = new System.Drawing.Size(157, 146);
            this.pbAlta.TabIndex = 16;
            this.pbAlta.TabStop = false;
            // 
            // btnAgregarAlta
            // 
            this.btnAgregarAlta.Location = new System.Drawing.Point(12, 212);
            this.btnAgregarAlta.Name = "btnAgregarAlta";
            this.btnAgregarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAlta.TabIndex = 7;
            this.btnAgregarAlta.Text = "Agregar";
            this.btnAgregarAlta.UseVisualStyleBackColor = true;
            this.btnAgregarAlta.Click += new System.EventHandler(this.btnAgregarAlta_Click);
            // 
            // btnModificarAlta
            // 
            this.btnModificarAlta.Location = new System.Drawing.Point(93, 212);
            this.btnModificarAlta.Name = "btnModificarAlta";
            this.btnModificarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAlta.TabIndex = 8;
            this.btnModificarAlta.Text = "Modificar";
            this.btnModificarAlta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(278, 212);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAlta.TabIndex = 9;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 247);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnModificarAlta);
            this.Controls.Add(this.btnAgregarAlta);
            this.Controls.Add(this.pbAlta);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbUrlImagen);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigoArticulo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoArt);
            this.Name = "frmAlta";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoArt;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbCodigoArticulo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbUrlImagen;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox pbAlta;
        private System.Windows.Forms.Button btnAgregarAlta;
        private System.Windows.Forms.Button btnModificarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
    }
}

