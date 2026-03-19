using System.Collections.Generic;

public class Pieza : Producto
{
    private double precio;
    private string tipo;
    private string descripcion;

    public Pieza(string nombre, double precio, string tipo, string descripcion)
        : base(nombre)
    {
        this.precio = precio;
        this.tipo = tipo;
        this.descripcion = descripcion;
    }

    public string Tipo => tipo;
    public string Descripcion => descripcion;

    public override void Agregar(Producto p)
    {
        // No hace nada (es hoja)
    }

    public override IList<Producto> ObtenerHijos()
    {
        return null;
    }

    public override double Precio => precio;
}