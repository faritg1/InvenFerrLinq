using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvenFerrLinq.Entities;

namespace InvenFerrLinq.Methods;
public class FunctionEntitie
{
    static ListEntitie entitie = new ListEntitie();
    static List<Cliente> _cliente = entitie._cliente;
    static List<Producto> _producto = entitie._producto;
    static List<Factura> _factura = entitie._factura;
    static List<DetalleFactura> _detalleFactura = entitie._detalleFactura;

    public void pregunta1(){
        var studentAsc = _cliente.OrderBy(s => s.Nombre).ToList();
        studentAsc.ForEach(tp => Console.WriteLine($"Nombre Ascendente {tp.Nombre}"));
    }
}
