using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class PanelInformacion : Form
    {
        private MainWindow main;

        public PanelInformacion(MainWindow m)
        {
            InitializeComponent();
            main = m;
            ponerInformacion();
        }

        private void ponerInformacion()
        {
            string[] info = main.darInformacionCALI();
            txtBoxCALI.Text = info[0];
            txtBoxAdm.Text = info[2];
            txtBoxContacto.Text = info[3];
            txtBoxDireccion.Text = info[1];
        }

    }
}
