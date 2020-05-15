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

namespace RecargaPlus.src.views.frame
{
    public partial class Colaboradores_frame : UserControl
    {
        private List<Colaborador> _colaboradores;
        private int _index;
        public Colaboradores_frame()
        {
            InitializeComponent();
            llenarTablaColaboradores();
        }
        private void llenarTablaColaboradores()
        {
            _colaboradores = (new Operations()).getColaboradores();
            tabla_colaboradores.DataSource = _colaboradores;
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            String nombre = txt_nombre.Text;
            String apepat = txt_apepat.Text;
            String apemat = txt_apemat.Text;
            String usuario = txt_usuario.Text;
            String clave = txt_clave.Text;
            double saldo = double.Parse(txt_saldo.Text);
            if ((new Operations()).setColaborador(nombre, apemat, apemat, usuario, clave, saldo))
                MessageBox.Show("El colaborador fue agregado");
            else
                MessageBox.Show("El colaborador no puse ser agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            llenarTablaColaboradores();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if ((new Operations()).updateColaborador(_colaboradores.ElementAt(_index).IdPersona,
                                                    txt_nombre.Text,
                                                    txt_apepat.Text,
                                                    txt_apemat.Text,
                                                    txt_usuario.Text,
                                                    txt_clave.Text,
                                                    double.Parse(txt_saldo.Text)))
                MessageBox.Show("Informacion del colaborador actualizado");
            else
                MessageBox.Show("la informacion del colaborador no pudo ser actualizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            llenarTablaColaboradores();
        }
        private void tabla_colaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
            txt_nombre.Text = _colaboradores.ElementAt(_index).Nombre;
            txt_apepat.Text = _colaboradores.ElementAt(_index).Apepat;
            txt_apemat.Text = _colaboradores.ElementAt(_index).Apemat;
            txt_usuario.Text = _colaboradores.ElementAt(_index).Usuario;
            txt_clave.Text = _colaboradores.ElementAt(_index).Clave;
            txt_saldo.Text = _colaboradores.ElementAt(_index).Saldo.ToString();
            
        }

    }
}
