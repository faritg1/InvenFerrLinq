using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvenFerrLinq.Entities
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double Valor { get; set; }
        
        public int IdProductoFk { get; set; }
        public string NroFacturaFk { get; set; }
    }
}