using System.Collections.Generic;

public abstract class Producto
{
    protected string nombre;

    public Producto(string nombre)
    {
        this.nombre = nombre;
    }

    public string Nombre => nombre;

    public abstract void Agregar(Producto p);
    public abstract IList<Producto> ObtenerHijos();
    public abstract double Precio { get; }
}