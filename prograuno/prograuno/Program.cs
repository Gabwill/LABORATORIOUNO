using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("PROGRAMA");
        Console.WriteLine ("Ingrese el nombre del Cliente: ");
        string nombre_usuario= Console.ReadLine();

        string[] productos = new string[5];
        int[] cantidades = new int[5];
        double[] precios = new double[5];
        double total = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nProducto {i + 1}");

            Console.Write("Nombre: ");
            productos[i] = Console.ReadLine();

            Console.Write("Cantidad: ");
            cantidades[i] = int.Parse(Console.ReadLine());

            Console.Write("Precio: ");
            precios[i] = double.Parse(Console.ReadLine());

            double subtotal = cantidades[i] * precios[i];
            total += subtotal;
        }
        Console.WriteLine("\n========== RESUMEN DEL PEDIDO ==========");
        Console.WriteLine("Cliente: " + nombre_usuario);
        Console.WriteLine("----------------------------------------");

        for (int i = 0; i < 5; i++)
        {
            double subtotal = cantidades[i] * precios[i];
            Console.WriteLine("Producto: " + productos[i]);
            Console.WriteLine("Cantidad: " + cantidades[i]);
            Console.WriteLine("Precio:   " + precios[i]);
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("----------------------------------------");
        }

        Console.WriteLine("TOTAL GENERAL: " + total);
        Console.WriteLine("========================================");
    }



}