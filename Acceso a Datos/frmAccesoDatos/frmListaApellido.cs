using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAccesoDatos
{
    public partial class frmListaApellido : Form
    {
        private ClienteServicio _clienteServicio;
        public frmListaApellido(ClienteServicio cs)
        {
            this._clienteServicio = cs;
            InitializeComponent();
        }
        private void CargarListaApellido(List<Cliente> clientesApellido)
        {
            lstListaApellido.DataSource = null;
            if (clientesApellido.Count == 0)
            {
                MessageBox.Show("No hay resultados para mostrar.");
            }
            else
            {
                lstListaApellido.DataSource = clientesApellido;
            }
        }
        private void frmListaApellido_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> clientesApellido = _clienteServicio.TraerClientesPorApellido(txtApellido.Text);
                CargarListaApellido(clientesApellido);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDebe ingresar una cadena de texto.");
            }
        }

        private void btnVolverMayores_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void frmListaApellido_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }
    }
}
