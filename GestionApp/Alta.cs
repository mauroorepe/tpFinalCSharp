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
        public frmAlta()
        {
            InitializeComponent();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();   

            try
            {
                articulo.CodigoArticulo = tbCodigoArticulo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.UrlImagen = tbUrlImagen.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);

                negocio.agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
