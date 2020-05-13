using RecargaPlus.src.views.frame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecargaPlus.src.views.pages
{
    public partial class Inicio_page : Form
    {
        public Inicio_page()
        {
            InitializeComponent();
            Recargas_frame recargas = new Recargas_frame();
            configurarContenedor(recargas);
        }

        private void configurarContenedor(Control c)
        {
            c.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Clear();
            this.panel_contenedor.Controls.Add(c);
        }

        private void opcion_regargas(object sender, EventArgs e)
        {
            Recargas_frame recargas = new Recargas_frame();
            configurarContenedor(recargas);
        }

        private void opcion_ganancias(object sender, EventArgs e)
        {
            Ganancias_frame ganancias = new Ganancias_frame();
            configurarContenedor(ganancias);
        }
    }
}
