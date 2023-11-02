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
        new Producto(){Id = 1, Nombre = "Acetaminofe", PrecioUnit = 12.000, Cantidad = 4, StockMin = 5, StockMax = 10},
        new Producto(){Id = 2, Nombre = "Acitromicina", PrecioUnit = 15.000, Cantidad = 6, StockMin = 3, StockMax = 12},
        new Producto(){Id = 3, Nombre = "Mecarbajol", PrecioUnit = 20.000, Cantidad = 10, StockMin = 5, StockMax = 20},
        new Producto(){Id = 4, Nombre = "Termanal", PrecioUnit = 25.000, Cantidad = 24, StockMin = 12, StockMax = 30}
    };

    public List<Factura> _factura = new List<Factura>(){
        new Factura(){NroFactura = "a1", Fecha = new DateTime(01/03/2020), TotalFactura = 30.000, IdClienteFk = 1},
        new Factura(){NroFactura = "b1", Fecha = new DateTime(01/03/2021), TotalFactura = 40.000, IdClienteFk = 1},
        new Factura(){NroFactura = "c1", Fecha = new DateTime(01/03/2022), TotalFactura = 50.000, IdClienteFk = 1},
        new Factura(){NroFactura = "d1", Fecha = new DateTime(01/03/2023), TotalFactura = 60.000, IdClienteFk = 1}
    };

    public List<DetalleFactura> _detalleFactura = new List<DetalleFactura>(){
        new DetalleFactura(){Id = 1, Cantidad = 5, Valor = 50.000, IdProductoFk = 1, NroFacturaFk = "a1"},
        new DetalleFactura(){Id = 2, Cantidad = 10, Valor = 60.000, IdProductoFk = 2, NroFacturaFk = "b1"},
        new DetalleFactura(){Id = 3, Cantidad = 15, Valor = 70.000, IdProductoFk = 3, NroFacturaFk = "c1"},
        new DetalleFactura(){Id = 4, Cantidad = 20, Valor = 80.000, IdProductoFk = 4, NroFacturaFk = "d1"}
    };
}
