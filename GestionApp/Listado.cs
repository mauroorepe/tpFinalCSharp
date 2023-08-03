using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace GestionApp
{
    public partial class frmListado : Form
    {
        private List<Articulo> listaArticulos;
        public frmListado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            cargarDatos();
            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarImagen(string imagen )
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbArticulos.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.ShowDialog();
            cargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAlta modificar = new frmAlta(seleccionado);
            modificar.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            

            try
            {
                DialogResult resultado = MessageBox.Show("El registro seleccionado sera eliminado permanentemente, ¿está seguro que desea continuar?", "Eliminar Permanentemente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado);
                    cargarDatos();
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
