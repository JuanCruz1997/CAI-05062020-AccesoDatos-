namespace frmAccesoDatos
{
    partial class frmListaMayores
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
            this.lstMayores = new System.Windows.Forms.ListBox();
            this.btnVolverMayores = new System.Windows.Forms.Button();
            this.lblListaMayores = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMayores
            // 
            this.lstMayores.FormattingEnabled = true;
            this.lstMayores.ItemHeight = 16;
            this.lstMayores.Location = new System.Drawing.Point(13, 45);
            this.lstMayores.Name = "lstMayores";
            this.lstMayores.Size = new System.Drawing.Size(425, 356);
            this.lstMayores.TabIndex = 0;
            // 
            // btnVolverMayores
            // 
            this.btnVolverMayores.Location = new System.Drawing.Point(12, 407);
            this.btnVolverMayores.Name = "btnVolverMayores";
            this.btnVolverMayores.Size = new System.Drawing.Size(84, 31);
            this.btnVolverMayores.TabIndex = 1;
            this.btnVolverMayores.Text = "< Volver";
            this.btnVolverMayores.UseVisualStyleBackColor = true;
            this.btnVolverMayores.Click += new System.EventHandler(this.btnVolverMayores_Click);
            // 
            // lblListaMayores
            // 
            this.lblListaMayores.AutoSize = true;
            this.lblListaMayores.Location = new System.Drawing.Point(13, 13);
            this.lblListaMayores.Name = "lblListaMayores";
            this.lblListaMayores.Size = new System.Drawing.Size(95, 17);
            this.lblListaMayores.TabIndex = 2;
            this.lblListaMayores.Text = "Ingrese edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(115, 13);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(59, 22);
            this.txtEdad.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(190, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmListaMayores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblListaMayores);
            this.Controls.Add(this.btnVolverMayores);
            this.Controls.Add(this.lstMayores);
            this.Name = "frmListaMayores";
            this.Text = "Lista de mayores de X años";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaMayores_FormClosed);
            this.Load += new System.EventHandler(this.frmListaMayores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMayores;
        private System.Windows.Forms.Button btnVolverMayores;
        private System.Windows.Forms.Label lblListaMayores;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnBuscar;
    }
}