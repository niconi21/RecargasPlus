using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using RecargaPlus.Moldes;
using Controller.objects;
using Controller.cache;

namespace RecargaPlus.src.views.frame
{
    public partial class Ganancias_frame : UserControl
    {
        private List<Recarga> _recargas;
        public Ganancias_frame()
        {
            InitializeComponent();
            llenarTablaGanancias();
            graficarGanancias();
        }
        private void llenarTablaGanancias()
        {
            _recargas = (new Operations()).getRecargas(Usuario_cache.IdPersona);
            var lista = new List<Recargas_colaborador>();
            foreach (var recarga in _recargas)
            {
                lista.Add(new Recargas_colaborador
                {
                    ID = recarga.ID,
                    Numero = recarga.Numero,
                    Compania = recarga.Compania.compania,
                    Monto = recarga.Monto.monto,
                    Bonificacion = recarga.Bonificacion.bonificacion
                });
            }
            tablaGanancias.DataSource = lista;
        }
        private void graficarGanancias()
        {
            var companias = (new Operations()).getCompanias();
            var montos = new double[companias.Count];
            foreach (var recarga in _recargas)
            {
                for (int i = 0; i < companias.Count; i++)
                {
                    if (recarga.Compania.ID == companias.ElementAt(i).ID)
                    {
                        montos[i] += recarga.Monto.monto;
                    }
                }
            }
            for (int i = 0; i < companias.Count; i++)
            {
                graficaGanancias.Series.Add(companias[i].compania);
                graficaGanancias.Series[i].Points.AddY(montos[i]);
            }
        }
    }
}
