using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appTekStore.ADO
{
    public class Pedido
    {
        public long id_Fabarca { get; set; }
        public string nombre_Fabarca { get; set; }
        public long rut_Fabarca { get; set; }
        public string direccion_Fabarca { get; set; }
        public long telefono_Fabarca { get; set; }
        public int cantidad_Fabarca { get; set; }
        public long id_prod_Fabarca { get; set; }

    }
}