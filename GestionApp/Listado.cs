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

        //Inicializacion del programa
        public frmListado()
        {
            InitializeComponent();
        }

        //Eventos Ventana
        private void Listado_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Seleccione");

        }
        //Eventos DGV
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        //Eventos Filtros
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            if (listaFiltrada.Count==0)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnDetalle.Enabled = false;
            }
            else
            {
                btnModificar.Enabled=true;
                btnEliminar.Enabled=true;
                btnDetalle.Enabled = true;
            }
            ocultarColumnas();
        }


        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }



        //Eventos CLICK (Botones)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.ShowDialog();
            cargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAlta modificar = new frmAlta(seleccionado);
                modificar.ShowDialog();
                cargarDatos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
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
        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (cboRequerido(cboCampo, lblCampo, cboCriterio, lblCriterio) || tbRequerido(tbFiltroAvanzado))
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = tbFiltroAvanzado.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAlta detalle = new frmAlta(seleccionado, true);
                detalle.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Restricciones sobre campos
        private void tbFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((string)cboCampo.SelectedItem == "Precio")
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }


        //FUNCIONES
        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargarImagen(string imagen)
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
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private bool cboRequerido(ComboBox cbo, Label lbl)
        {
            if (cbo.SelectedIndex <0)
            {
                MessageBox.Show("Complete los campos obligatorios");
                lbl.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else
            {
                lbl.ForeColor=System.Drawing.Color.Black;
                return false;
            }
        }

        private bool cboRequerido(ComboBox cbo, Label lbl, ComboBox cbo2, Label lbl2)
        {
            if (cbo.SelectedIndex < 0)
            {
                MessageBox.Show("Complete los campos obligatorios");
                lbl.ForeColor = System.Drawing.Color.Red;
                if (cbo2.SelectedIndex < 0)
                {
                    lbl2.ForeColor = System.Drawing.Color.Red;
                    return true;
                }
                return true;
            }
            else if (cbo2.SelectedIndex < 0)
            {
                MessageBox.Show("Complete los campos obligatorios");
                lbl2.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            else
            {
                lbl.ForeColor = System.Drawing.Color.Black;
                lbl2.ForeColor=System.Drawing.Color.Black;
                return false;
            }
        }

        private bool tbRequerido(TextBox tb)
        {
            if (tb.Text == "" && cboCampo.SelectedItem.ToString() == "Precio")
            {
                tb.BackColor = Color.Red;
                MessageBox.Show("Complete los campos obligatorios");
                return true;
            }
            
            tb.BackColor=Color.White;
            return false;
        }
    }
}
