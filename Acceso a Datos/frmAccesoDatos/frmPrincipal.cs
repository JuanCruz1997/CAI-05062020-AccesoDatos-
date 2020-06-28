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
using Negocio;

namespace frmAccesoDatos
{
    public partial class frmPrincipal : Form
    {
        private ClienteServicio _clienteServicio;
        private CuentaServicio _cuentaServicio;
        public ClienteServicio ClienteServicio
        {
            get
            {
                return this._clienteServicio;
            }
        }
        public CuentaServicio CuentaServicio
        {
            get
            {
                return this._cuentaServicio;
            }
        }
        public frmPrincipal(ClienteServicio cs, CuentaServicio cus)
        {
            this._clienteServicio = cs;
            this._cuentaServicio = cus;
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            frmListaCompleta f = new frmListaCompleta(this._clienteServicio);
            f.Owner = this;
            f.Show();
            this.Hide();
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnListaMayores_Click(object sender, EventArgs e)
        {
            frmListaMayores f = new frmListaMayores(this._clienteServicio);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnListaApellido_Click(object sender, EventArgs e)
        {
            frmListaApellido f = new frmListaApellido(this._clienteServicio);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            frmIngresoCliente f = new frmIngresoCliente(this._clienteServicio, this);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnAltaCuentas_Click(object sender, EventArgs e)
        {
            frmAltaCuenta f = new frmAltaCuenta(this._clienteServicio, this._cuentaServicio);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnModificarSaldo_Click(object sender, EventArgs e)
        {
            frmModificarSaldo f = new frmModificarSaldo(this._clienteServicio, this._cuentaServicio);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            frmVerCuentas f = new frmVerCuentas(this._clienteServicio, this._cuentaServicio);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void gbCuentas_Enter(object sender, EventArgs e)
        {

        }
    }
}
