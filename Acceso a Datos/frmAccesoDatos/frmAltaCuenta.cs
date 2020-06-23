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
    public partial class frmAltaCuenta : Form
    {
        private ClienteServicio _clienteServicio;
        private CuentaServicio _cuentaServicio;
        private string tipoCuentaElegido;
        private int idClienteElegido;
        public frmAltaCuenta(ClienteServicio cs,CuentaServicio cus)
        {
            this._clienteServicio = cs;
            this._cuentaServicio = cus;
            InitializeComponent();
        }
        private void CargarListaClientesPropios(List<Cliente> clientes)
        {
            lstClientesPropios.DataSource = null;
            lstClientesPropios.DataSource = clientes;
        }
        private void CargarComboTipoCuenta()
        {
            List<String> tipos = new List<string>();
            tipos.Add("(Elija una opción)");
            tipos.Add("Caja de ahorro en $");
            tipos.Add("Caja de ahorro en USD");
            tipos.Add("Caja de ahorro en EUR");
            tipos.Add("Cuenta corriente");
            tipos.Add("Cuenta comitente");
            cmbTipoCuenta.DataSource = tipos;
        }
        private void ObtenerIDCliente(List<Cliente> clientes, int posicion)
        {
            Cliente elegido = clientes[posicion];
            idClienteElegido = elegido.Id;
        }
        private void frmAltaCuenta_Load(object sender, EventArgs e)
        {
            CargarComboTipoCuenta();
            CargarListaClientesPropios(_clienteServicio.TraerClientesPropios());
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoCuentaElegido = cmbTipoCuenta.Text;
        }

        private void frmAltaCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void btnVolverAltaCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void btnAltaCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                _cuentaServicio.AbrirCuenta(tipoCuentaElegido, idClienteElegido);
                MessageBox.Show("La cuenta se ha abierto con éxito.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al abrir cuenta:\n" + ex.Message);
            }
        }

        private void lstClientesPropios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerIDCliente(_clienteServicio.TraerClientesPropios(), lstClientesPropios.SelectedIndex);
        }
    }
}
