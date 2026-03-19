using System.Collections.Generic;

public class Compuesto : Producto
{
    private List<Producto> componentes = new List<Producto>();

    public Compuesto(string nombre) : base(nombre)
    {
    }

    public override void Agregar(Producto p)
    {
        componentes.Add(p);
    }

    public override IList<Producto> ObtenerHijos()
    {
        return componentes;
    }

    public override double Precio
    {
        get
        {
            double total = 0;
            foreach (var item in componentes)
            {
                total += item.Precio;
            }
            return total;
        }
    }
}