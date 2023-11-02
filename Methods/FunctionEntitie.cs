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
        var prod = _producto.ToList();
        prod.ForEach(tp => Console.WriteLine($"Nombre Producto {tp.Nombre}"));
    }

    public void pregunta2(){
        var result = _producto.Where(mnr => mnr.Cantidad < mnr.StockMin).ToList();
        result.ForEach(r => Console.WriteLine($"-------Productos a punto de agotarse {r.Nombre}---------"));
    }

    public void pregunta3(){
        var e = from x in _producto 
                where x.Cantidad < x.StockMin 
                select new { x.StockMax - x.Cantidad };   
        foreach (var item in e){
            Console.WriteLine($"Menores {item}");
        }
    }
}
