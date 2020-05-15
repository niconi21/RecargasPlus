using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.objects
{
    public class Recarga
    {
        public int ID { get; set; }
        public String Numero { get; set; }
        public Colaborador Colaborador { get; set; }
        public Bonificacion Bonificacion { get; set; }
        public Compania Compania { get; set; }
        public Monto Monto { get; set; }
    }
}
