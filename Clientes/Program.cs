using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Clientes 
{
    public static void Main(string[] args)
    {
        decimal[,] compras = new decimal[5, 5]
        {
            { 50, 80, 120, 150, 200 },
            { 100, 200, 300, 400, 500 },
            { 150, 250, 350, 450, 550 },
            { 200, 300, 400, 500, 600 },
            { 250, 350, 450, 550, 650 }
        };

        for (int i = 0; i < compras.GetLength(0); i++)
        {
            decimal total = 0;
            for (int j = 0; j < compras.GetLength(1); j++)
            {
                total += compras[i, j];
            }

            decimal descuento = 0;
            if (total >= 1000)
            {
                descuento = total * 0.2m;
            }
            else if (total >= 100)
            {
                descuento = total * 0.1m;
            }

            Console.WriteLine($"Cliente {i + 1}:");
            Console.WriteLine($"\tTotal: {total:C2}");
            Console.WriteLine($"\tDescuento: {descuento:C2}");
            Console.WriteLine($"\tTotal a pagar: {(total - descuento):C2}");
            Console.WriteLine();
        }
    }
}

