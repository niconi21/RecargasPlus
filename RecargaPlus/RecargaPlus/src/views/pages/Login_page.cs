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
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Inicio_page inicio = new Inicio_page();
            inicio.Show();
            this.Hide();
        }
    }
}
