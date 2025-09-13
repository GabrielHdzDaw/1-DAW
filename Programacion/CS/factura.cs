/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-09-2024
 * Descripción: Crea un programa en C# que vaya pidiendo cantidades y precios hasta 
 * que se introduzca un 0 o en cantidad o en precio. Nos tendrá que ir mostrando el 
 * total de cada artículo y al final nos tendrá que mostrar el total final.

	Introduzca cantidad: 5

	Introduzca precio: 10

	Total: 50

	Introduzca cantidad: 7

	Introduzca precio: 2

	Total: 14

	Introduzca cantidad: 2

	Introduzca precio: 0

	Total Final: 64
 * 
 */

using System;
public class Factura
{
	public static void Main()
	{
		int cantidad = 1, precio = 1, total = 0, totalFinal = 0;
		while(cantidad != 0 || precio != 0)
		{
			Console.Write("Introduce una cantidad de artículos: ");
			cantidad = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce el precio del artículo: ");
			precio = Convert.ToInt32(Console.ReadLine());
			total = cantidad * precio;
			totalFinal += total;
			Console.WriteLine("Total: {0}", total);
		}
		Console.WriteLine("Total final: {0}", totalFinal);
	}
}
