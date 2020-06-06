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
    public partial class frmListaMayores : Form
    {
        private ClienteServicio _clienteServicio;
        public frmListaMayores(ClienteServicio cs)
        {
            this._clienteServicio = cs;
            InitializeComponent();
        }
        private void CargarListaMayores(List<Cliente> clientesEdad)
        {
            lstMayores.DataSource = null;
            if (clientesEdad.Count == 0)
            {
                MessageBox.Show("No hay resultados para mostrar.");
            }
            else
            {
                lstMayores.DataSource = clientesEdad;
            }
        }
        private void frmListaMayores_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> clientesEdad = this._clienteServicio.TraerClientesMayoresA(Convert.ToInt32(txtEdad.Text));
                CargarListaMayores(clientesEdad);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDebe ingresar un número entero.");
            }
        }

        private void btnVolverMayores_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void frmListaMayores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }
    }
}
