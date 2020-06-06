namespace frmAccesoDatos
{
    partial class frmListaApellido
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
            this.lstListaApellido = new System.Windows.Forms.ListBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            this.btnVolverMayores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaApellido
            // 
            this.lstListaApellido.FormattingEnabled = true;
            this.lstListaApellido.ItemHeight = 16;
            this.lstListaApellido.Location = new System.Drawing.Point(13, 45);
            this.lstListaApellido.Name = "lstListaApellido";
            this.lstListaApellido.Size = new System.Drawing.Size(425, 356);
            this.lstListaApellido.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 13);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(112, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Ingrese apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(132, 13);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(225, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.Location = new System.Drawing.Point(363, 9);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(75, 30);
            this.btnBuscarApellido.TabIndex = 3;
            this.btnBuscarApellido.Text = "Buscar";
            this.btnBuscarApellido.UseVisualStyleBackColor = true;
            this.btnBuscarApellido.Click += new System.EventHandler(this.btnBuscarApellido_Click);
            // 
            // btnVolverMayores
            // 
            this.btnVolverMayores.Location = new System.Drawing.Point(12, 407);
            this.btnVolverMayores.Name = "btnVolverMayores";
            this.btnVolverMayores.Size = new System.Drawing.Size(84, 31);
            this.btnVolverMayores.TabIndex = 4;
            this.btnVolverMayores.Text = "< Volver";
            this.btnVolverMayores.UseVisualStyleBackColor = true;
            this.btnVolverMayores.Click += new System.EventHandler(this.btnVolverMayores_Click);
            // 
            // frmListaApellido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnVolverMayores);
            this.Controls.Add(this.btnBuscarApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lstListaApellido);
            this.Name = "frmListaApellido";
            this.Text = "Lista de Clientes por Apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaApellido_FormClosed);
            this.Load += new System.EventHandler(this.frmListaApellido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListaApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscarApellido;
        private System.Windows.Forms.Button btnVolverMayores;
    }
}