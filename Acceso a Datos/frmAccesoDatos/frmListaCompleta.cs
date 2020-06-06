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
using Entidades;

namespace frmAccesoDatos
{
    public partial class frmListaCompleta : Form
    {
        private ClienteServicio _clienteServicio;
        public frmListaCompleta(ClienteServicio cs)
        {
            this._clienteServicio = cs;
            InitializeComponent();
        }
        private void CargarListaClientes(List<Cliente> clientes)
        {
            lstListaCompleta.DataSource = null;
            lstListaCompleta.DataSource = clientes;
        }
        private void frmListaCompleta_Load(object sender, EventArgs e)
        {
            CargarListaClientes(_clienteServicio.TraerClientes());
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void frmListaCompleta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }
    }
}
