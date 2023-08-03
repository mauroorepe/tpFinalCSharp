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

namespace GestionApp
{
    public partial class frmAlta : Form
    {
        private Articulo articulo = null;
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

                if (articulo != null )
                {
                    tbCodigoArticulo.Text = articulo.CodigoArticulo;
                    tbNombre.Text = articulo.Nombre;
                    tbDescripcion.Text = articulo.Descripcion;
                    tbUrlImagen.Text= articulo.UrlImagen;
                    tbPrecio.Text =articulo.Precio.ToString();
                    cargarImagen(articulo.UrlImagen);
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            { 
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

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                    
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            string imagen = tbUrlImagen.Text;
            cargarImagen(imagen);
        }

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

        
    }
}
