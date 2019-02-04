namespace view
{
    partial class MainWindow
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
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtGridCALI = new System.Windows.Forms.DataGridView();
            this.txtBoxLatitud = new System.Windows.Forms.TextBox();
            this.txtBoxLongitud = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.cmBoxServicio = new System.Windows.Forms.ComboBox();
            this.cmBoxBarrio = new System.Windows.Forms.ComboBox();
            this.checkBoxMostrarInfo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCALI)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(860, 56);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(60, 20);
            this.lblBarrio.TabIndex = 1;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(860, 144);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(76, 20);
            this.lblServicio.TabIndex = 2;
            this.lblServicio.Text = "Servicio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(900, 242);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 37);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtGridCALI
            // 
            this.dtGridCALI.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtGridCALI.AllowUserToAddRows = false;
            this.dtGridCALI.AllowUserToDeleteRows = false;
            this.dtGridCALI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCALI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCALI.Location = new System.Drawing.Point(735, 327);
            this.dtGridCALI.Name = "dtGridCALI";
            this.dtGridCALI.ReadOnly = true;
            this.dtGridCALI.RowTemplate.Height = 24;
            this.dtGridCALI.Size = new System.Drawing.Size(335, 327);
            this.dtGridCALI.TabIndex = 7;
            this.dtGridCALI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionMarcador);
            // 
            // txtBoxLatitud
            // 
            this.txtBoxLatitud.Location = new System.Drawing.Point(735, 665);
            this.txtBoxLatitud.Name = "txtBoxLatitud";
            this.txtBoxLatitud.Size = new System.Drawing.Size(166, 22);
            this.txtBoxLatitud.TabIndex = 8;
            this.txtBoxLatitud.Text = "Latitud";
            // 
            // txtBoxLongitud
            // 
            this.txtBoxLongitud.Location = new System.Drawing.Point(907, 665);
            this.txtBoxLongitud.Name = "txtBoxLongitud";
            this.txtBoxLongitud.Size = new System.Drawing.Size(163, 22);
            this.txtBoxLongitud.TabIndex = 9;
            this.txtBoxLongitud.Text = "Longitud";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(754, 242);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(123, 37);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(13, 13);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(707, 678);
            this.gmap.TabIndex = 11;
            this.gmap.Zoom = 0D;
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // cmBoxServicio
            // 
            this.cmBoxServicio.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmBoxServicio.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxServicio.FormattingEnabled = true;
            this.cmBoxServicio.Location = new System.Drawing.Point(754, 180);
            this.cmBoxServicio.Name = "cmBoxServicio";
            this.cmBoxServicio.Size = new System.Drawing.Size(292, 30);
            this.cmBoxServicio.TabIndex = 12;
            // 
            // cmBoxBarrio
            // 
            this.cmBoxBarrio.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmBoxBarrio.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxBarrio.FormattingEnabled = true;
            this.cmBoxBarrio.Location = new System.Drawing.Point(754, 96);
            this.cmBoxBarrio.Name = "cmBoxBarrio";
            this.cmBoxBarrio.Size = new System.Drawing.Size(292, 30);
            this.cmBoxBarrio.TabIndex = 13;
            // 
            // checkBoxMostrarInfo
            // 
            this.checkBoxMostrarInfo.AutoSize = true;
            this.checkBoxMostrarInfo.Location = new System.Drawing.Point(754, 285);
            this.checkBoxMostrarInfo.Name = "checkBoxMostrarInfo";
            this.checkBoxMostrarInfo.Size = new System.Drawing.Size(155, 21);
            this.checkBoxMostrarInfo.TabIndex = 14;
            this.checkBoxMostrarInfo.Text = "Mostrar Información";
            this.checkBoxMostrarInfo.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.checkBoxMostrarInfo);
            this.Controls.Add(this.cmBoxBarrio);
            this.Controls.Add(this.cmBoxServicio);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.txtBoxLongitud);
            this.Controls.Add(this.txtBoxLatitud);
            this.Controls.Add(this.dtGridCALI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblBarrio);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de información de C.A.L.I.";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCALI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtGridCALI;
        private System.Windows.Forms.TextBox txtBoxLatitud;
        private System.Windows.Forms.TextBox txtBoxLongitud;
        private System.Windows.Forms.Button btnReiniciar;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ComboBox cmBoxServicio;
        private System.Windows.Forms.ComboBox cmBoxBarrio;
        private System.Windows.Forms.CheckBox checkBoxMostrarInfo;
    }
}

