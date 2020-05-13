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
using Controller.cache;
using Controller.tools;

namespace RecargaPlus.src.views.pages
{
    public partial class Inicio_page : Form
    {
        public Inicio_page()
        {
            InitializeComponent();
            this.lbl_nombre.Text = Usuario_cache.Nombre + " " + Usuario_cache.Apepat + " " + Usuario_cache.Apemat;
            this.lbl_cargo.Text = Usuario_cache.Tipo;
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

        private void opcion_colaboradores(object sender, EventArgs e)
        {
            Colaboradores_frame colaboradores = new Colaboradores_frame();
            configurarContenedor(colaboradores);
        }

        private void opcion_bonificacion(object sender, EventArgs e)
        {
            Bonificaciones_frame bonificacion = new Bonificaciones_frame();
            configurarContenedor(bonificacion);
        }

        private void opcion_montoCompania(object sender, EventArgs e)
        {
            MontoCompania_frame companiaMonto = new MontoCompania_frame();
            configurarContenedor(companiaMonto);
        }

        private void cerrarsesion(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_cache.IdPersona = 0;
            Usuario_cache.Nombre = "";
            Usuario_cache.Apepat = "";
            Usuario_cache.Apemat = "";
            Usuario_cache.Usuario = "";
            Usuario_cache.Clave = "";
            Usuario_cache.Tipo = "";
            Login_page login = new Login_page();
            login.Show();
        }
    }
}
