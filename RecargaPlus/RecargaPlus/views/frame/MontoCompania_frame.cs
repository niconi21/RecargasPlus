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
    public partial class MontoCompania_frame : UserControl
    {
        private List<Compania> _companias;
        private List<Monto> _montos;
        public MontoCompania_frame()
        {
            InitializeComponent();
            llenarTablas();
        }

        private void llenarTablas()
        {
            _companias = (new Operations()).getCompanias();
            _montos = (new Operations()).getMontos();
            tabla_montos.DataSource = _montos;
            tabla_companias.DataSource = _companias;
        }

        private void btn_AgregarCompania_Click(object sender, EventArgs e)
        {
            String compania = txt_compania.Text;
            if ((new Operations()).setCompania(compania))
                MessageBox.Show("La compañia ha sido agregada");
            else
                MessageBox.Show("La compañia no ha sido agregada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            llenarTablas();
        }

        private void btnAgregarMonto_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txt_monto.Text);
            if ((new Operations()).setMonto(monto))
                MessageBox.Show("El monto ha sido agregada");
            else
                MessageBox.Show("El monto no ha sido agregada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            llenarTablas();
        }
        
    }
}
