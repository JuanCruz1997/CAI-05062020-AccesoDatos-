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
    public partial class frmVerCuentas : Form
    {
        private ClienteServicio _clienteServicio;
        private CuentaServicio _cuentaServicio;
        public frmVerCuentas(ClienteServicio cs, CuentaServicio cus)
        {
            this._clienteServicio = cs;
            this._cuentaServicio = cus;
            InitializeComponent();
        }
        private void CargarListaCuentas(List<Cliente> clientes)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            foreach(Cliente c in clientes)
            {
                cuentas.Add(_cuentaServicio.Traer(c.Id));
            }
            lstCuentas.DataSource = null;
            lstCuentas.DataSource = cuentas;
        }
        private void frmVerCuentas_Load(object sender, EventArgs e)
        {
            CargarListaCuentas(_clienteServicio.TraerClientesPropios());
        }

        private void btnVolverCuentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void frmVerCuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }
    }
}
