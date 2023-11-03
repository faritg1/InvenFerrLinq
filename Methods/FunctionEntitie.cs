using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
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
        var table = new ConsoleTable("Nombre Producto", "Cantidad");
        prod.ForEach(tp => table.AddRow(tp.Nombre,tp.Cantidad));
        table.Write();
    }

    public void Pregunta2(){
        var result = _producto.Where(mnr => mnr.Cantidad < mnr.StockMin).ToList();
        var table = new ConsoleTable("Productos a punto de agotarse");
        result.ForEach(r => table.AddRow(r.Nombre));
        table.Write();
    }

    public void Pregunta3(){
        var result = _producto.Where(mnr => mnr.Cantidad < mnr.StockMin).ToList();
        var table = new ConsoleTable("Comprar producto", "Comprar cantidad");
        result.ForEach(r => table.AddRow(r.Nombre,r.StockMax - r.Cantidad));
        table.Write();
    }

    public void Pregunta4(){
        var fact = _factura.Where(f => f.Fecha.Month == 01 && f.Fecha.Year == 2023).ToList();
        var table = new ConsoleTable("Nro", "Fecha", "Total Factura");
        fact.ForEach(f => table.AddRow(f.NroFactura,f.Fecha,f.TotalFactura));
        table.Write();
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

        var table = new ConsoleTable("Nombre producto", "Valor", "Cantidad");
        join.ForEach(f => table.AddRow(f.producto,f.detalle,f.detalleF));
        table.Write();
    }
    public void Pregunta6(){
        var sum = (from v in _producto
        select v.PrecioUnit * v.Cantidad).Sum();

        var table = new ConsoleTable("Total Inventario");
        table.AddRow(sum);
        table.Write();
    }
}
