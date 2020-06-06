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

namespace frmAccesoDatos
{
    public partial class frmPrincipal : Form
    {
        private ClienteServicio _clienteServicio;
        public ClienteServicio ClienteServicio
        {
            get
            {
                return this._clienteServicio;
            }
        }
        public frmPrincipal(ClienteServicio cs)
        {
            this._clienteServicio = cs;
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
    }
}
