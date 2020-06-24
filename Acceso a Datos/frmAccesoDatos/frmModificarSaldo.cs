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
    public partial class frmModificarSaldo : Form
    {
        private ClienteServicio _clienteServicio;
        private CuentaServicio _cuentaServicio;
        private Cuenta cuentaCliente = new Cuenta();
        public frmModificarSaldo(ClienteServicio cs,CuentaServicio cus)
        {
            this._clienteServicio = cs;
            this._cuentaServicio = cus;
            InitializeComponent();
        }
        private void BuscarCuentas(int idCliente)
        {
            cuentaCliente = _cuentaServicio.Traer(idCliente);
            MostrarCuenta(cuentaCliente);
        }
        private void MostrarCuenta(Cuenta cuentaEncontrada)
        {
            lblSeleccionCuenta.Text = "Cuenta encontrada: " + cuentaEncontrada.NroCuenta + " - " + cuentaEncontrada.Descripcion;
        }

        private void frmModificarSaldo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarCuentas_Click(object sender, EventArgs e)
        {
            BuscarCuentas(Convert.ToInt32(txtBuscarCliente.Text));
        }

        private void btnMSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                _cuentaServicio.ModificarSaldo(cuentaCliente.Id, float.Parse(txtSaldo.Text));
                MessageBox.Show("El saldo de la cuenta se ha modificado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }
        }

        private void btnVolverMSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void frmModificarSaldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }
    }
}
