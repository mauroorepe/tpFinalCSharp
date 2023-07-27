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
    public partial class Listado : Form
    {
        private List<Articulo> listaArticulos;
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.Listar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvArticulos.CurrentRow != null)
            //{
            //    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //    cargarImagen(seleccionado.UrlImagen);
            //}
        }
    }
}
