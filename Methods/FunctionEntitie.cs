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

    public void Pregunta1(){
        var prod = _producto.ToList();
        prod.ForEach(tp => Console.WriteLine($"Nombre Producto {tp.Nombre}"));
    }

    public void Pregunta2(){
        var result = _producto.Where(mnr => mnr.Cantidad < mnr.StockMin).ToList();
        result.ForEach(r => Console.WriteLine($"-------Productos a punto de agotarse {r.Nombre}---------"));
    }

    public void Pregunta3(){
        var result = _producto.Where(mnr => mnr.Cantidad < mnr.StockMin).ToList();
        result.ForEach(r => Console.WriteLine($"Productos a comprar: {r.Nombre} ---- Cuantos hay que comprar: {r.StockMax - r.Cantidad}"));
    }

    public void Pregunta4(){
        var fact = _factura.Where(f => f.Fecha.Month == 01 && f.Fecha.Year == 2023).ToList();
        fact.ForEach(f => Console.WriteLine($"Nro: {f.NroFactura} -- Fecha: {f.Fecha} -- Total Factura: {f.TotalFactura}"));
    }
    public void Pregunta5(){
        var join = _producto.Join(
            _detalleFactura,
            prod => prod.Id,
            det => det.IdProductoFk,
            (prod, det) => new{
                producto = prod.Nombre,
                detalle = det.Valor,
                detalleF = det.Cantidad
            }
        ).ToList();

        join.ForEach(f => Console.WriteLine($"Nombre producto: {f.producto} -- Valor: {f.detalle} -- Cantidad: {f.detalleF}"));
    }
    public void Pregunta6(){
        var sum = (from v in _producto
        select v.PrecioUnit * v.Cantidad).Sum();

        Console.WriteLine($"Total: {sum}");
    }
}
