using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvenFerrLinq.Entities;

namespace InvenFerrLinq.Methods;
public class ListEntitie
{
    public List<Cliente> _cliente = new List<Cliente>(){
        new Cliente(){Id = 1, Nombre = "Carlos", Email = "testone@example.com"},
        new Cliente(){Id = 2, Nombre = "Farit", Email = "testtwo@example.com"},
        new Cliente(){Id = 3, Nombre = "Juan", Email = "testthree@example.com"},
        new Cliente(){Id = 4, Nombre = "Cesar", Email = "testfour@example.com"},
    };

    public List<Producto> _producto = new List<Producto>(){
        new Producto(){Id = 1, Nombre = "Tornillos", PrecioUnit = 12000, Cantidad = 4, StockMin = 5, StockMax = 10},
        new Producto(){Id = 2, Nombre = "Martillo", PrecioUnit = 15000, Cantidad = 6, StockMin = 3, StockMax = 12},
        new Producto(){Id = 3, Nombre = "Tuerca", PrecioUnit = 20000, Cantidad = 10, StockMin = 5, StockMax = 20},
        new Producto(){Id = 4, Nombre = "Roscas", PrecioUnit = 25000, Cantidad = 24, StockMin = 12, StockMax = 30}
    };

    public List<Factura> _factura = new List<Factura>(){
        new Factura(){NroFactura = "a1", Fecha = new DateOnly(2020,01,01), TotalFactura = 30000, IdClienteFk = 1},
        new Factura(){NroFactura = "b1", Fecha = new DateOnly(2021,03,03), TotalFactura = 40000, IdClienteFk = 1},
        new Factura(){NroFactura = "c1", Fecha = new DateOnly(2022,03,03), TotalFactura = 50000, IdClienteFk = 1},
        new Factura(){NroFactura = "d1", Fecha = new DateOnly(2023,01,23), TotalFactura = 60000, IdClienteFk = 1}
    };

    public List<DetalleFactura> _detalleFactura = new List<DetalleFactura>(){
        new DetalleFactura(){Id = 1, Cantidad = 4, Valor = 20000, IdProductoFk = 1, NroFacturaFk = "a1"},
        new DetalleFactura(){Id = 2, Cantidad = 6, Valor = 30000, IdProductoFk = 2, NroFacturaFk = "b1"},
        new DetalleFactura(){Id = 3, Cantidad = 8, Valor = 40000, IdProductoFk = 3, NroFacturaFk = "c1"},
        new DetalleFactura(){Id = 4, Cantidad = 20, Valor = 50000, IdProductoFk = 4, NroFacturaFk = "d1"}
    };
}
