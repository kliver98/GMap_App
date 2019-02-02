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
        private GMapOverlay markerOverlay;
        private DataTable dtCALI;

        private int filaSeleccionada;
        private double latitud;
        private double longitud;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            latitud = 3.4113786;
            longitud = -76.5273724;
            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new PointLatLng(latitud,longitud);
            gmap.MinZoom = 12;
            gmap.MaxZoom = 18;
            gmap.Zoom = gmap.MinZoom;
            gmap.AutoScroll = true;

        }
    }
}
