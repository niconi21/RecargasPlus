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
using Controller.objects;
using RecargaPlus.Moldes;

namespace RecargaPlus.src.views.frame
{
    public partial class Bonificaciones_frame : UserControl
    {
        private List<Bonificacion> _bonificaciones;
        private List<Compania> _companias;
        private List<Monto> _montos;
        private int _index;
        public Bonificaciones_frame()
        {
            InitializeComponent();
            llenarComboBox();
            llenarTablaBonificaciones();
        }

        private void llenarTablaBonificaciones()
        {
            _bonificaciones = (new Operations()).getBonificaciones();
            var lista = new List<Bonificacoines_administrador>();
            foreach (var bonificacion in _bonificaciones)
            {
                lista.Add(new Bonificacoines_administrador
                {
                    ID = bonificacion.ID,
                    bonificacion = bonificacion.bonificacion,
                    Compania = bonificacion.Compania.compania,
                    Monto = bonificacion.Monto.monto
                });
            }
            tabla_bonificaciones.DataSource = lista;
        }
        private void llenarComboBox()
        {
            _montos = (new Operations()).getMontos();
            foreach (var monto in _montos)
            {
                this.cb_monto.Items.Add(monto.monto);
            }
            this.cb_monto.SelectedIndex = 0;
            _companias = (new Operations()).getCompanias();
            foreach (var compania in _companias)
            {
                this.cb_compania.Items.Add(compania.compania);
            }
            this.cb_compania.SelectedIndex = 0;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            double bonificacion = double.Parse(txt_bonificacion.Text);
            int idCompania = _companias.ElementAt(cb_compania.SelectedIndex).ID;
            int idMonto = _montos.ElementAt(cb_monto.SelectedIndex).ID;
            if ((new Operations()).setBonificacion(bonificacion, idMonto, idCompania))
                MessageBox.Show("La bonificacion fué agregada con exito");
            else
                MessageBox.Show("La bonificacion no pudo ser agregada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            llenarTablaBonificaciones();
        }

        private void tabla_bonificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
            txt_bonificacion.Text = _bonificaciones.ElementAt(_index).bonificacion.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            double bonificacion = double.Parse(txt_bonificacion.Text);
            int idCompania = _companias.ElementAt(cb_compania.SelectedIndex).ID;
            int idMonto = _montos.ElementAt(cb_monto.SelectedIndex).ID;
            if ((new Operations()).updateBonificacion(_bonificaciones.ElementAt(_index).ID, bonificacion, idMonto, idCompania))
                MessageBox.Show("La bonificacion fué actualizada con exito");
            else
                MessageBox.Show("La bonificacion no pudo ser actualizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            llenarTablaBonificaciones();
        }
    }
}
