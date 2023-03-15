using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double[,,] ventas = new double[12, 4, 3];

        // Asignar valores aleatorios a la matriz
        Random rand = new Random();
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    ventas[i, j, k] = rand.Next(10000, 100000);
                }
            }
        }

        // Calcular el total de ventas por mes
        double[] ventasPorMes = new double[12];
        for (int i = 0; i < 12; i++)
        {
            double total = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    total += ventas[i, j, k];
                }
            }
            ventasPorMes[i] = total;
        }

        // Imprimir el total de ventas por mes
        Console.WriteLine("Ventas por mes:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine("Mes " + (i + 1) + ": " + ventasPorMes[i].ToString("C"));
        }

        // Calcular el total de ventas por categoría de producto
        double[] ventasPorCategoria = new double[4];
        for (int j = 0; j < 4; j++)
        {
            double total = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    total += ventas[i, j, k];
                }
            }
            ventasPorCategoria[j] = total;
        }

        // Imprimir el total de ventas por categoría de producto
        Console.WriteLine("Ventas por categoría de producto:");
        Console.WriteLine("Electrónica: " + ventasPorCategoria[0].ToString("C"));
        Console.WriteLine("Ropa: " + ventasPorCategoria[1].ToString("C"));
        Console.WriteLine("Juguetes: " + ventasPorCategoria[2].ToString("C"));
        Console.WriteLine("Hogar: " + ventasPorCategoria[3].ToString("C"));

        // Calcular el total de ventas por tienda
        double[] ventasPorTienda = new double[3];
        for (int k = 0; k < 3; k++)
        {
            double total = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total += total;
            }
                }
        }
    }
}

