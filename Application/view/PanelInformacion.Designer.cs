namespace view
{
    partial class PanelInformacion
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
            this.lblCALI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAdm = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtBoxCALI = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxAdm = new System.Windows.Forms.TextBox();
            this.txtBoxContacto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCALI
            // 
            this.lblCALI.AutoSize = true;
            this.lblCALI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCALI.Location = new System.Drawing.Point(86, 63);
            this.lblCALI.Name = "lblCALI";
            this.lblCALI.Size = new System.Drawing.Size(74, 20);
            this.lblCALI.TabIndex = 0;
            this.lblCALI.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(86, 154);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 20);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.Location = new System.Drawing.Point(86, 249);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(142, 20);
            this.lblAdm.TabIndex = 2;
            this.lblAdm.Text = "Administrador/a";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(86, 349);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(84, 20);
            this.lblContacto.TabIndex = 3;
            this.lblContacto.Text = "Contacto";
            // 
            // txtBoxCALI
            // 
            this.txtBoxCALI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCALI.Location = new System.Drawing.Point(265, 63);
            this.txtBoxCALI.Name = "txtBoxCALI";
            this.txtBoxCALI.ReadOnly = true;
            this.txtBoxCALI.Size = new System.Drawing.Size(454, 27);
            this.txtBoxCALI.TabIndex = 4;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDireccion.Location = new System.Drawing.Point(265, 147);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.ReadOnly = true;
            this.txtBoxDireccion.Size = new System.Drawing.Size(454, 27);
            this.txtBoxDireccion.TabIndex = 5;
            // 
            // txtBoxAdm
            // 
            this.txtBoxAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdm.Location = new System.Drawing.Point(265, 246);
            this.txtBoxAdm.Name = "txtBoxAdm";
            this.txtBoxAdm.ReadOnly = true;
            this.txtBoxAdm.Size = new System.Drawing.Size(454, 27);
            this.txtBoxAdm.TabIndex = 6;
            // 
            // txtBoxContacto
            // 
            this.txtBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContacto.Location = new System.Drawing.Point(265, 342);
            this.txtBoxContacto.Name = "txtBoxContacto";
            this.txtBoxContacto.ReadOnly = true;
            this.txtBoxContacto.Size = new System.Drawing.Size(454, 27);
            this.txtBoxContacto.TabIndex = 7;
            // 
            // PanelInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.txtBoxContacto);
            this.Controls.Add(this.txtBoxAdm);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.txtBoxCALI);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblAdm);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCALI);
            this.Name = "PanelInformacion";
            this.Text = "PanelInformacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCALI;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtBoxCALI;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxAdm;
        private System.Windows.Forms.TextBox txtBoxContacto;
    }
}