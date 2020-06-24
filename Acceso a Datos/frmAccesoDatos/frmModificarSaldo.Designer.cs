namespace frmAccesoDatos
{
    partial class frmModificarSaldo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeleccionCuenta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnVolverMSaldo = new System.Windows.Forms.Button();
            this.btnMSaldo = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionCuenta
            // 
            this.lblSeleccionCuenta.AutoSize = true;
            this.lblSeleccionCuenta.Location = new System.Drawing.Point(12, 61);
            this.lblSeleccionCuenta.Name = "lblSeleccionCuenta";
            this.lblSeleccionCuenta.Size = new System.Drawing.Size(133, 17);
            this.lblSeleccionCuenta.TabIndex = 0;
            this.lblSeleccionCuenta.Text = "Cuenta encontrada:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 102);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(136, 17);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Ingrese nuevo saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(160, 102);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(362, 22);
            this.txtSaldo.TabIndex = 3;
            // 
            // btnVolverMSaldo
            // 
            this.btnVolverMSaldo.Location = new System.Drawing.Point(15, 246);
            this.btnVolverMSaldo.Name = "btnVolverMSaldo";
            this.btnVolverMSaldo.Size = new System.Drawing.Size(507, 51);
            this.btnVolverMSaldo.TabIndex = 4;
            this.btnVolverMSaldo.Text = "< Volver";
            this.btnVolverMSaldo.UseVisualStyleBackColor = true;
            this.btnVolverMSaldo.Click += new System.EventHandler(this.btnVolverMSaldo_Click);
            // 
            // btnMSaldo
            // 
            this.btnMSaldo.Location = new System.Drawing.Point(15, 168);
            this.btnMSaldo.Name = "btnMSaldo";
            this.btnMSaldo.Size = new System.Drawing.Size(507, 51);
            this.btnMSaldo.TabIndex = 5;
            this.btnMSaldo.Text = "Modificar saldo de cuenta";
            this.btnMSaldo.UseVisualStyleBackColor = true;
            this.btnMSaldo.Click += new System.EventHandler(this.btnMSaldo_Click);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(12, 20);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(141, 17);
            this.lblIDCliente.TabIndex = 6;
            this.lblIDCliente.Text = "Ingrese ID de cliente:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(160, 20);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(233, 22);
            this.txtBuscarCliente.TabIndex = 7;
            // 
            // btnBuscarCuentas
            // 
            this.btnBuscarCuentas.Location = new System.Drawing.Point(399, 15);
            this.btnBuscarCuentas.Name = "btnBuscarCuentas";
            this.btnBuscarCuentas.Size = new System.Drawing.Size(123, 33);
            this.btnBuscarCuentas.TabIndex = 8;
            this.btnBuscarCuentas.Text = "Buscar cuentas";
            this.btnBuscarCuentas.UseVisualStyleBackColor = true;
            this.btnBuscarCuentas.Click += new System.EventHandler(this.btnBuscarCuentas_Click);
            // 
            // frmModificarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 311);
            this.Controls.Add(this.btnBuscarCuentas);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.btnMSaldo);
            this.Controls.Add(this.btnVolverMSaldo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSeleccionCuenta);
            this.Name = "frmModificarSaldo";
            this.Text = "Modificar Saldo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModificarSaldo_FormClosed);
            this.Load += new System.EventHandler(this.frmModificarSaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnVolverMSaldo;
        private System.Windows.Forms.Button btnMSaldo;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCuentas;
    }
}