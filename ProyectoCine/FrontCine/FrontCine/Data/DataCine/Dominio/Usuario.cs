﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Dominio
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
            Nombre = "";
            Clave  = "";
        }
    }
}
