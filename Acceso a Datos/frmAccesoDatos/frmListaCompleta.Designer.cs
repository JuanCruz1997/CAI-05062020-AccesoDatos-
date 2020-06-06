namespace frmAccesoDatos
{
    partial class frmListaCompleta
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
            this.lstListaCompleta = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaCompleta
            // 
            this.lstListaCompleta.FormattingEnabled = true;
            this.lstListaCompleta.ItemHeight = 16;
            this.lstListaCompleta.Location = new System.Drawing.Point(13, 13);
            this.lstListaCompleta.Name = "lstListaCompleta";
            this.lstListaCompleta.Size = new System.Drawing.Size(425, 388);
            this.lstListaCompleta.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 407);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 31);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstListaCompleta);
            this.Name = "frmListaCompleta";
            this.Text = "Lista Completa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaCompleta_FormClosed);
            this.Load += new System.EventHandler(this.frmListaCompleta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListaCompleta;
        private System.Windows.Forms.Button btnVolver;
    }
}