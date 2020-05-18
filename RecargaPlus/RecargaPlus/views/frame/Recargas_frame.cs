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
using Controller.cache;
using RecargaPlus.Moldes;

namespace RecargaPlus.src.views.frame
{
    public partial class Recargas_frame : UserControl
    {
        private List<Monto> _montos;
        private List<Compania> _companias;
        public Recargas_frame()
        {
            InitializeComponent();
            llenarTablaRecargas();
            llenarComboBox();
            saldo();
        }
        private void saldo()
        {
            lbl_saldo.Text = "Saldo: $" + Usuario_cache.Saldo;
        }
        private void llenarTablaRecargas()
        {
            var recargas = (new Operations()).getRecargas(Usuario_cache.IdPersona);
            var lista = new List<Recargas_colaborador>();
            foreach (var recarga in recargas)
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
            tablaRecargas.DataSource = lista;
        }
        private void llenarComboBox()
        {
            _montos = (new Operations()).getMontos();
            foreach (var monto in _montos)
            {
                this.cb_monto.Items.Add((monto.ID + 1) + " - " + monto.monto);
            }
            this.cb_monto.SelectedIndex = 0;
            _companias = (new Operations()).getCompanias();
            foreach (var compania in _companias)
            {
                this.cb_compania.Items.Add((compania.ID + 1) + " - " + compania.compania);   
            }
            this.cb_compania.SelectedIndex = 0;
        }

        private void btn_realizarRecarga_Click(object sender, EventArgs e)
        {
            String numero = txt_numero.Text;
            double saldo = Usuario_cache.Saldo - _montos.ElementAt(cb_monto.SelectedIndex).monto;
            if (saldo >= 0)
            {
                Usuario_cache.Saldo = saldo;
                int idMonto = _montos.ElementAt(cb_monto.SelectedIndex).ID;
                int idCompania = _companias.ElementAt(cb_compania.SelectedIndex).ID;
                var bonificacion = (new Operations()).getBonificacion(idCompania, idMonto);
                var resultado = (new Operations()).setRecarga(numero, Usuario_cache.IdPersona, bonificacion.ID, idMonto, idCompania);
                var actualizacion = (new Operations()).updateColaborador(Usuario_cache.IdPersona, Usuario_cache.Nombre, Usuario_cache.Apepat, Usuario_cache.Apemat, Usuario_cache.Usuario, Usuario_cache.Clave, Usuario_cache.Saldo);
                if (resultado)
                    MessageBox.Show("La recarga fue hecha con exito");
                else
                    MessageBox.Show("La recarga no ha sido realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llenarTablaRecargas();
                var colaborador = (new Operations()).getColaborador(Usuario_cache.IdPersona);
                Usuario_cache.Saldo = colaborador.Saldo;
                this.saldo();
            }else
                MessageBox.Show("No tienes saldo suficiente para realizar esta recarga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
