namespace frmAccesoDatos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListaCompleta = new System.Windows.Forms.Button();
            this.btnListaMayores = new System.Windows.Forms.Button();
            this.btnListaApellido = new System.Windows.Forms.Button();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.gbCuentas = new System.Windows.Forms.GroupBox();
            this.btnAltaCuentas = new System.Windows.Forms.Button();
            this.gbClientes.SuspendLayout();
            this.gbCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaCompleta
            // 
            this.btnListaCompleta.Location = new System.Drawing.Point(28, 45);
            this.btnListaCompleta.Name = "btnListaCompleta";
            this.btnListaCompleta.Size = new System.Drawing.Size(285, 68);
            this.btnListaCompleta.TabIndex = 0;
            this.btnListaCompleta.Text = "Lista Completa";
            this.btnListaCompleta.UseVisualStyleBackColor = true;
            this.btnListaCompleta.Click += new System.EventHandler(this.btnListaCompleta_Click);
            // 
            // btnListaMayores
            // 
            this.btnListaMayores.Location = new System.Drawing.Point(28, 144);
            this.btnListaMayores.Name = "btnListaMayores";
            this.btnListaMayores.Size = new System.Drawing.Size(285, 68);
            this.btnListaMayores.TabIndex = 1;
            this.btnListaMayores.Text = "Lista con mayores de 25 años";
            this.btnListaMayores.UseVisualStyleBackColor = true;
            this.btnListaMayores.Click += new System.EventHandler(this.btnListaMayores_Click);
            // 
            // btnListaApellido
            // 
            this.btnListaApellido.Location = new System.Drawing.Point(28, 239);
            this.btnListaApellido.Name = "btnListaApellido";
            this.btnListaApellido.Size = new System.Drawing.Size(285, 68);
            this.btnListaApellido.TabIndex = 2;
            this.btnListaApellido.Text = "Lista por Apellido";
            this.btnListaApellido.UseVisualStyleBackColor = true;
            this.btnListaApellido.Click += new System.EventHandler(this.btnListaApellido_Click);
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(28, 342);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(285, 68);
            this.btnInsertarCliente.TabIndex = 3;
            this.btnInsertarCliente.Text = "Insertar Cliente";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnInsertarCliente);
            this.gbClientes.Controls.Add(this.btnListaCompleta);
            this.gbClientes.Controls.Add(this.btnListaApellido);
            this.gbClientes.Controls.Add(this.btnListaMayores);
            this.gbClientes.Location = new System.Drawing.Point(13, 13);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(360, 439);
            this.gbClientes.TabIndex = 4;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // gbCuentas
            // 
            this.gbCuentas.Controls.Add(this.btnAltaCuentas);
            this.gbCuentas.Location = new System.Drawing.Point(408, 13);
            this.gbCuentas.Name = "gbCuentas";
            this.gbCuentas.Size = new System.Drawing.Size(318, 439);
            this.gbCuentas.TabIndex = 5;
            this.gbCuentas.TabStop = false;
            this.gbCuentas.Text = "Cuentas";
            // 
            // btnAltaCuentas
            // 
            this.btnAltaCuentas.Location = new System.Drawing.Point(17, 45);
            this.btnAltaCuentas.Name = "btnAltaCuentas";
            this.btnAltaCuentas.Size = new System.Drawing.Size(285, 68);
            this.btnAltaCuentas.TabIndex = 1;
            this.btnAltaCuentas.Text = "Alta de cuentas";
            this.btnAltaCuentas.UseVisualStyleBackColor = true;
            this.btnAltaCuentas.Click += new System.EventHandler(this.btnAltaCuentas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 464);
            this.Controls.Add(this.gbCuentas);
            this.Controls.Add(this.gbClientes);
            this.Name = "frmPrincipal";
            this.Text = "Opciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbCuentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaCompleta;
        private System.Windows.Forms.Button btnListaMayores;
        private System.Windows.Forms.Button btnListaApellido;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.GroupBox gbCuentas;
        private System.Windows.Forms.Button btnAltaCuentas;
    }
}

