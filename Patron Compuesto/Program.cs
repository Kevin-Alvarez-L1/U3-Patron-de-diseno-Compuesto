
class Program
{
    static void Main(string[] args)
    {
        Producto pc = new Compuesto("PC Personalizada");

        // CPU
        Producto cpu1 = new Pieza("Intel i3", 2000, "CPU", "Básico");
        Producto cpu2 = new Pieza("Ryzen 5", 3500, "CPU", "Intermedio");
        Producto cpu3 = new Pieza("Intel i9", 9000, "CPU", "Alto rendimiento");

        // RAM
        Producto ram1 = new Pieza("8GB", 800, "RAM", "Básico");
        Producto ram2 = new Pieza("16GB", 1200, "RAM", "Intermedio");
        Producto ram3 = new Pieza("32GB", 2500, "RAM", "Avanzado");

        // DISCO
        Producto d1 = new Pieza("1TB HDD", 900, "Disco", "Lento");
        Producto d2 = new Pieza("512GB SSD", 1500, "Disco", "Rápido");
        Producto d3 = new Pieza("1TB NVMe", 3000, "Disco", "Ultra rápido");

        // GPU
        Producto g1 = new Pieza("Integrada", 0, "GPU", "Incluida");
        Producto g2 = new Pieza("GTX 1660", 5000, "GPU", "Gaming medio");
        Producto g3 = new Pieza("RTX 4080", 15000, "GPU", "Gaming extremo");

        // MONITOR
        Producto m1 = new Pieza("HD", 1500, "Monitor", "Básico");
        Producto m2 = new Pieza("Full HD", 2500, "Monitor", "Bueno");
        Producto m3 = new Pieza("4K", 6000, "Monitor", "Premium");

        // ARMAR PC
        pc.Agregar(Elegir("CPU", cpu1, cpu2, cpu3));
        pc.Agregar(Elegir("RAM", ram1, ram2, ram3));
        pc.Agregar(Elegir("Disco", d1, d2, d3));
        pc.Agregar(Elegir("GPU", g1, g2, g3));
        pc.Agregar(Elegir("Monitor", m1, m2, m3));

        MostrarResumen(pc);

        Console.ReadLine();
    }

    static Producto Elegir(string tipo, Producto a, Producto b, Producto c)
    {
        Console.WriteLine($"\nSeleccione {tipo}:");
        Console.WriteLine($"1. {a.Nombre} - ${a.Precio}");
        Console.WriteLine($"2. {b.Nombre} - ${b.Precio}");
        Console.WriteLine($"3. {c.Nombre} - ${c.Precio}");
        Console.Write("Opción: ");

        int op;
        if (!int.TryParse(Console.ReadLine(), out op))
            return a;

        switch (op)
        {
            case 1: return a;
            case 2: return b;
            case 3: return c;
            default: return a;
        }
    }

    static void MostrarResumen(Producto pc)
    {
        Console.WriteLine("\n=== RESUMEN DE TU PC ===\n");

        foreach (var item in pc.ObtenerHijos())
        {
            Pieza p = item as Pieza;

            Console.WriteLine($"{p.Tipo}: {p.Nombre}");
            Console.WriteLine($"Descripción: {p.Descripcion}");
            Console.WriteLine($"Precio: ${p.Precio}\n");
        }

        Console.WriteLine($"1TOTAL: ${pc.Precio}");
    }
}