namespace frmAccesoDatos
{
    partial class frmVerCuentas
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
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.btnVolverCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 16;
            this.lstCuentas.Location = new System.Drawing.Point(13, 13);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(461, 388);
            this.lstCuentas.TabIndex = 0;
            // 
            // btnVolverCuentas
            // 
            this.btnVolverCuentas.Location = new System.Drawing.Point(13, 407);
            this.btnVolverCuentas.Name = "btnVolverCuentas";
            this.btnVolverCuentas.Size = new System.Drawing.Size(75, 31);
            this.btnVolverCuentas.TabIndex = 1;
            this.btnVolverCuentas.Text = "< Volver";
            this.btnVolverCuentas.UseVisualStyleBackColor = true;
            this.btnVolverCuentas.Click += new System.EventHandler(this.btnVolverCuentas_Click);
            // 
            // frmVerCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.btnVolverCuentas);
            this.Controls.Add(this.lstCuentas);
            this.Name = "frmVerCuentas";
            this.Text = "frmVerCuentas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVerCuentas_FormClosed);
            this.Load += new System.EventHandler(this.frmVerCuentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnVolverCuentas;
    }
}