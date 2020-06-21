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
    public partial class frmIngresoCliente : Form
    {
        private ClienteServicio _clienteServicio;
        public frmIngresoCliente(ClienteServicio cs, Form formPropietario)
        {
            this._clienteServicio = cs;
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (txtApellido.Text == string.Empty || txtNombre.Text == string.Empty || txtDireccion.Text == string.Empty)
            {
                msg = "Debe completar al menos los siguientes datos:\nNombre\nApellido\nDirección";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
            return valido;
        }

        private void frmIngresoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverIngreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void frmIngresoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    _clienteServicio.InsertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtMail.Text, txtTelefono.Text, dtpFechaNac.Value);
                    MessageBox.Show("Se ha añadido el cliente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
