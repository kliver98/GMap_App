using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace view
{
    public partial class MainWindow : Form
    {

        private GMarkerGoogle marker;
        private GMarkerGoogle markerUser;
        private GMapOverlay markerOverlay;
        private DataTable dtCALI;

        public const double DEFAULT_LAT = 3.4113786;
        public const double DEFAULT_LONG = -76.5273724;
        private int filaSeleccionada;
        private double latitud;
        private double longitud;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dtCALI = new DataTable();
            dtCALI.Columns.Add(new DataColumn("Descripción: ",typeof(string)));
            dtCALI.Columns.Add(new DataColumn("Latitud ", typeof(string)));
            dtCALI.Columns.Add(new DataColumn("Longitud ", typeof(string)));

            dtCALI.Rows.Add("Ubicación x", DEFAULT_LAT, DEFAULT_LONG);
            dtGridCALI.DataSource = dtCALI;

            //Desactivando columnas para que no aparezcan lat y ling
            dtGridCALI.Columns[1].Visible = dtGridCALI.Columns[2].Visible = false;

            latitud = 3.3419134;
            longitud = -76.5306936;
            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new PointLatLng(DEFAULT_LAT, DEFAULT_LONG);
            gmap.MinZoom = 12;
            gmap.MaxZoom = 18;
            gmap.Zoom = gmap.MinZoom;
            gmap.AutoScroll = true;
            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latitud, longitud),GMarkerGoogleType.blue);
            markerUser = new GMarkerGoogle(new PointLatLng(DEFAULT_LAT, DEFAULT_LONG), GMarkerGoogleType.orange);
            markerOverlay.Markers.Add(marker); //Agregamos al mapa
            markerOverlay.Markers.Add(markerUser);
            cambiarCuadroTextoMarcadorUsuario(DEFAULT_LAT, DEFAULT_LONG);
            cambiarCuadroTextoMarcador(latitud, longitud);
            gmap.Overlays.Add(markerOverlay);
            gmap.UpdateMarkerLocalPosition(marker);
            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtBoxBarrio.Text = "";
            cmBoxServicio.Text = "";
            cambiarCuadroTextoMarcador(latitud, longitud);
            gmap.Position = new PointLatLng(DEFAULT_LAT, DEFAULT_LONG);
            gmap.Zoom = gmap.MinZoom;
            txtBoxLatitud.Text = Convert.ToString(latitud);
            txtBoxLongitud.Text = Convert.ToString(longitud);
        }

        private void seleccionMarcador(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            txtBoxLatitud.Text = dtGridCALI.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtBoxLongitud.Text = dtGridCALI.Rows[filaSeleccionada].Cells[2].Value.ToString();
            //Agregando el marcador
            double lat = Convert.ToDouble(txtBoxLatitud.Text);
            double lng = Convert.ToDouble(txtBoxLongitud.Text);
            cambiarCuadroTextoMarcador(lat, lng);
            gmap.Position = marker.Position;
        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Para colocar marcador de la ubicación del usuario (naranja)
            {
                double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
                cambiarCuadroTextoMarcadorUsuario(lat, lng);
            }
            /**if (e.Button.Equals(MouseButtons.Right))
            {
                //Obteniendo lat y long clickeables
                double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

                txtBoxLatitud.Text = lat.ToString();
                txtBoxLongitud.Text = lng.ToString();

                cambiarCuadroTextoMarcador(lat,lng);

            }**/
        }

        private void cambiarCuadroTextoMarcador(double lat, double lng)
        {
            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación \nLatitud: {0} \nLongitud: {1}", lat, lng);
        }

        private void cambiarCuadroTextoMarcadorUsuario(double lat, double lng)
        {
            markerUser.Position = new PointLatLng(lat, lng);
            markerUser.ToolTipText = string.Format("Posición actual\n({0},{1})",lat,lng);
        }
    }
}
