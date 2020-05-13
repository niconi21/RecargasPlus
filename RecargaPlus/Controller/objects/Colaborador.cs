using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.objects
{
    public class Colaborador
    {
        public int IdPersona { get; set; }
        public int IdColaborador { get; set; }
        public String Nombre { get; set; }
        public String Apepat { get; set; }
        public String Apemat { get; set; }
        public String Usuario { get; set; }
        public String Clave { get; set; }
        public byte Tipo { get; set; }
        public int Saldo { get; set; }
    }
}
