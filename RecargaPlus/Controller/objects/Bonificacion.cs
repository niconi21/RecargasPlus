﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.objects
{
    public class Bonificacion
    {
        public int ID { get; set; }
        public double bonificacion { get; set; }
        public Compania Compania { get; set; }
        public Monto Monto { get; set; }
    }
}
