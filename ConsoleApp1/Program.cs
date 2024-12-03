
using Negocio;
using Entidad;



void GrabarComputo()
{

    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Juan Torrico",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 3000, Producto = "PC" });
    eDetalles.Add(new EDetalle { Cantidad = 2, Precio = 2000, Producto = "TV" });
    eDetalles.Add(new EDetalle { Cantidad = 4, Precio = 1000, Producto = "Equipo" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        
    }
}


void GrabarFerreteria()
{

    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Ronald Cuevas",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 10, Precio = 50, Producto = "Martillo" });
    eDetalles.Add(new EDetalle { Cantidad = 5, Precio = 2000, Producto = "Taladro" });
    eDetalles.Add(new EDetalle { Cantidad = 8, Precio = 1800, Producto = "Cortadora" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());

    }
}


void GrabarMercado()
{

    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Andrés Machaca",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 8, Precio = 10, Producto = "Limón" });
    eDetalles.Add(new EDetalle { Cantidad = 6, Precio = 8, Producto = "Manzana" });
    eDetalles.Add(new EDetalle { Cantidad = 10, Precio = 12, Producto = "Azúcar" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());

    }
}


void GrabarComputo2()
{

    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Pablo Cuevas",
        Fecha = DateTime.Now,
        Direccion = "Av. Internacional S/N"
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 4500, Producto = "Laptop LENOVO" });
    eDetalles.Add(new EDetalle { Cantidad = 2, Precio = 3000, Producto = "Proyector CANON" });
    eDetalles.Add(new EDetalle { Cantidad = 3, Precio = 2500, Producto = "UPS APC" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());

    }
}

//GrabarComputo();
//GrabarFerreteria();
//GrabarMercado();
GrabarComputo2();
Console.Read();

