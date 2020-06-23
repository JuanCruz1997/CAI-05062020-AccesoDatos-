namespace frmAccesoDatos
{
    partial class frmAltaCuenta
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
            this.lblSeleccionarCliente = new System.Windows.Forms.Label();
            this.lstClientesPropios = new System.Windows.Forms.ListBox();
            this.lblSeleccionarTipoCuenta = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.btnVolverAltaCuenta = new System.Windows.Forms.Button();
            this.btnAltaCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionarCliente
            // 
            this.lblSeleccionarCliente.AutoSize = true;
            this.lblSeleccionarCliente.Location = new System.Drawing.Point(13, 13);
            this.lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            this.lblSeleccionarCliente.Size = new System.Drawing.Size(122, 17);
            this.lblSeleccionarCliente.TabIndex = 0;
            this.lblSeleccionarCliente.Text = "Seleccione cliente";
            // 
            // lstClientesPropios
            // 
            this.lstClientesPropios.FormattingEnabled = true;
            this.lstClientesPropios.ItemHeight = 16;
            this.lstClientesPropios.Location = new System.Drawing.Point(16, 33);
            this.lstClientesPropios.Name = "lstClientesPropios";
            this.lstClientesPropios.Size = new System.Drawing.Size(375, 388);
            this.lstClientesPropios.TabIndex = 1;
            this.lstClientesPropios.SelectedIndexChanged += new System.EventHandler(this.lstClientesPropios_SelectedIndexChanged);
            // 
            // lblSeleccionarTipoCuenta
            // 
            this.lblSeleccionarTipoCuenta.AutoSize = true;
            this.lblSeleccionarTipoCuenta.Location = new System.Drawing.Point(398, 33);
            this.lblSeleccionarTipoCuenta.Name = "lblSeleccionarTipoCuenta";
            this.lblSeleccionarTipoCuenta.Size = new System.Drawing.Size(175, 17);
            this.lblSeleccionarTipoCuenta.TabIndex = 2;
            this.lblSeleccionarTipoCuenta.Text = "Seleccione tipo de cuenta:";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(401, 54);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(248, 24);
            this.cmbTipoCuenta.TabIndex = 3;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // btnVolverAltaCuenta
            // 
            this.btnVolverAltaCuenta.Location = new System.Drawing.Point(401, 370);
            this.btnVolverAltaCuenta.Name = "btnVolverAltaCuenta";
            this.btnVolverAltaCuenta.Size = new System.Drawing.Size(248, 50);
            this.btnVolverAltaCuenta.TabIndex = 4;
            this.btnVolverAltaCuenta.Text = "< Volver";
            this.btnVolverAltaCuenta.UseVisualStyleBackColor = true;
            this.btnVolverAltaCuenta.Click += new System.EventHandler(this.btnVolverAltaCuenta_Click);
            // 
            // btnAltaCuenta
            // 
            this.btnAltaCuenta.Location = new System.Drawing.Point(401, 314);
            this.btnAltaCuenta.Name = "btnAltaCuenta";
            this.btnAltaCuenta.Size = new System.Drawing.Size(248, 50);
            this.btnAltaCuenta.TabIndex = 5;
            this.btnAltaCuenta.Text = "Abrir cuenta";
            this.btnAltaCuenta.UseVisualStyleBackColor = true;
            this.btnAltaCuenta.Click += new System.EventHandler(this.btnAltaCuenta_Click);
            // 
            // frmAltaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.btnAltaCuenta);
            this.Controls.Add(this.btnVolverAltaCuenta);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.lblSeleccionarTipoCuenta);
            this.Controls.Add(this.lstClientesPropios);
            this.Controls.Add(this.lblSeleccionarCliente);
            this.Name = "frmAltaCuenta";
            this.Text = "Alta Cuenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAltaCuenta_FormClosed);
            this.Load += new System.EventHandler(this.frmAltaCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarCliente;
        private System.Windows.Forms.ListBox lstClientesPropios;
        private System.Windows.Forms.Label lblSeleccionarTipoCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Button btnVolverAltaCuenta;
        private System.Windows.Forms.Button btnAltaCuenta;
    }
}