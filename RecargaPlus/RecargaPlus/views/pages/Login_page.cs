using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Controller.operations;

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
            String usuario = txt_Usuario.Text;
            String clave = txt_clave.Text;
            if (!usuario.Equals("") && !clave.Equals(""))
            {
                Login_operation operacion = new Login_operation();
                if (operacion.login(usuario, clave))
                {
                    Inicio_page inicio = new Inicio_page();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o clave incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor para el usuario y/o clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
