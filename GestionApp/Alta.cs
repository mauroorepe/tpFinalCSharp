using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Drawing.Text;

namespace GestionApp
{
    public partial class frmAlta : Form
    {
        private Articulo articulo = null;
        private bool flag = false;

        //Constructores y Sobrecargas
        public frmAlta()
        {
            InitializeComponent();
        }

         public frmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        public frmAlta(Articulo articulo, bool flag)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo";
            this.flag = flag;
        }

        //Eventos
        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            string imagen = tbUrlImagen.Text;
            cargarImagen(imagen);
        }


        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void frmAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";

            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();

                if (articulo != null && flag == true)
                {
                    mostrarControles();
                    cargarModificar();
                    cargarDetalle();
                    desactivarEscritura();
                }else if(articulo != null) 
                {
                    cargarModificar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //Eventos Botones
        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validacion())
                    return;
                if (articulo == null )
                {
                    articulo = new Articulo();
                }
                articulo.CodigoArticulo = tbCodigoArticulo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.UrlImagen = tbUrlImagen.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);

                if (articulo.Id != 0 && flag == true)
                {
                    esconderControles();
                    reactivarEscritura();
                    this.Close();
                }
                else if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                despintar();    
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            if(articulo == null)
            {
                this.Close();
            }else if(articulo.Id != 0 && flag == true)
            {
                esconderControles();
                reactivarEscritura();
            }
            despintar();
            this.Close();
        }

       

        //FUNCIONES
        private void cargarImagen(string imagen)
        {
            try
            {
                pbAlta.Load(imagen);
            }
            catch (Exception)
            {
                pbAlta.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private void esconderControles()
        {
            lblIdCategoria.Visible = false;
            lblIdMarca.Visible = false;
            lblIdProducto.Visible = false;
            tbIdCategoria.Visible = false;
            tbIdMarca.Visible = false;
            tbIdProducto.Visible = false;
        }

        private void reactivarEscritura()
        {
            tbCodigoArticulo.Enabled = true;
            tbNombre.Enabled = true;
            tbDescripcion.Enabled = true;
            tbUrlImagen.Enabled = true;
            tbPrecio.Enabled = true;
            cboCategoria.Enabled = true;
            cboMarca.Enabled = true;
        }

        private void desactivarEscritura()
        {
            tbCodigoArticulo.Enabled = false;
            tbNombre.Enabled = false;
            tbDescripcion.Enabled = false;
            tbUrlImagen.Enabled = false;
            tbPrecio.Enabled = false;
            cboCategoria.Enabled = false;
            cboMarca.Enabled = false;
            tbIdCategoria.Enabled = false;
            tbIdMarca.Enabled = false;
            tbIdProducto.Enabled = false;
        }

        private void mostrarControles()
        {
            lblIdCategoria.Visible = true;
            lblIdMarca.Visible = true;
            lblIdProducto.Visible = true;
            tbIdCategoria.Visible = true;
            tbIdMarca.Visible = true;
            tbIdProducto.Visible = true;
        }

        private void cargarModificar()
        {
            tbCodigoArticulo.Text = articulo.CodigoArticulo;
            tbNombre.Text = articulo.Nombre;
            tbDescripcion.Text = articulo.Descripcion;
            tbUrlImagen.Text = articulo.UrlImagen;
            tbPrecio.Text = articulo.Precio.ToString();
            cargarImagen(articulo.UrlImagen);
            cboCategoria.SelectedValue = articulo.Categoria.Id;
            cboMarca.SelectedValue = articulo.Marca.Id;
        }
        
        private void cargarDetalle()
        {
            tbIdCategoria.Text = articulo.Categoria.Id.ToString();
            tbIdMarca.Text = articulo.Marca.Id.ToString();
            tbIdProducto.Text = articulo.Id.ToString();
        }

        private bool validacion()
        {
            if (tbCodigoArticulo.Text == "" || tbNombre.Text == "" || tbDescripcion.Text == "" || tbUrlImagen.Text == "" || tbPrecio.Text == "")
            {
                pintarRojo(tbCodigoArticulo);
                pintarRojo(tbNombre);
                pintarRojo(tbDescripcion);
                pintarRojo(tbUrlImagen);
                pintarRojo(tbPrecio);
                    return true;
            }
            return false;
        }

        private void pintarRojo(TextBox tb)
        {
            if (tb.Text == "")
            {
                tb.BackColor = Color.Red;
            }
        }

        private void despintar()
        {
            tbCodigoArticulo.BackColor = Color.White;
            tbNombre.BackColor = Color.White;
            tbDescripcion.BackColor = Color.White;
            tbUrlImagen.BackColor = Color.White;
            tbPrecio.BackColor = Color.White;
        }
    }
}
