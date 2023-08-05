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
            this.btnAceptarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.tbIdMarca = new System.Windows.Forms.TextBox();
            this.tbIdCategoria = new System.Windows.Forms.TextBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
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
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
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
            // btnAceptarAlta
            // 
            this.btnAceptarAlta.Location = new System.Drawing.Point(196, 250);
            this.btnAceptarAlta.Name = "btnAceptarAlta";
            this.btnAceptarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAlta.TabIndex = 7;
            this.btnAceptarAlta.Text = "Aceptar";
            this.btnAceptarAlta.UseVisualStyleBackColor = true;
            this.btnAceptarAlta.Click += new System.EventHandler(this.btnAceptarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(277, 250);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAlta.TabIndex = 9;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(80, 250);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(100, 20);
            this.tbIdProducto.TabIndex = 17;
            this.tbIdProducto.Visible = false;
            // 
            // tbIdMarca
            // 
            this.tbIdMarca.Location = new System.Drawing.Point(80, 224);
            this.tbIdMarca.Name = "tbIdMarca";
            this.tbIdMarca.Size = new System.Drawing.Size(100, 20);
            this.tbIdMarca.TabIndex = 18;
            this.tbIdMarca.Visible = false;
            // 
            // tbIdCategoria
            // 
            this.tbIdCategoria.Location = new System.Drawing.Point(80, 198);
            this.tbIdCategoria.Name = "tbIdCategoria";
            this.tbIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbIdCategoria.TabIndex = 19;
            this.tbIdCategoria.Visible = false;
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(0, 201);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(64, 13);
            this.lblIdCategoria.TabIndex = 20;
            this.lblIdCategoria.Text = "Id Categoria";
            this.lblIdCategoria.Visible = false;
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(0, 227);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(49, 13);
            this.lblIdMarca.TabIndex = 21;
            this.lblIdMarca.Text = "Id Marca";
            this.lblIdMarca.Visible = false;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(0, 253);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(62, 13);
            this.lblIdProducto.TabIndex = 22;
            this.lblIdProducto.Text = "Id Producto";
            this.lblIdProducto.Visible = false;
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 283);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.tbIdCategoria);
            this.Controls.Add(this.tbIdMarca);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnAceptarAlta);
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
        private System.Windows.Forms.Button btnAceptarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.TextBox tbIdMarca;
        private System.Windows.Forms.TextBox tbIdCategoria;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblIdProducto;
    }
}

