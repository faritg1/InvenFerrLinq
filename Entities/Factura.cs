using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvenFerrLinq.Entities
{
    public class Factura
    {
        public string NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public double TotalFactura { get; set; }

        public int IdClienteFk { get; set; }
    }
}