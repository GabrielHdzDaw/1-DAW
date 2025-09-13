/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-10-2024
 * Descripción: Crea un programa que devuelva el cambio de una compra, 
 * utilizando monedas (o billetes) del mayor valor posible. Supondremos 
 * que tenemos una cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1,
 *  y que no hay decimales. La ejecución podría ser algo como:
Precio? 44

Pagado? 100 

Su cambio es de 56: 50 5 1

Precio? 1

Pagado? 100

Su cambio es de 99: 50 20 20 5 2 2
 */ 
 


using System;
public class Cambio
{
	public static void Main()
	{
		int precio, pagado, cambio;
		Console.Write("Precio: ");
		precio = Convert.ToInt32(Console.ReadLine());
		Console.Write("Pagado: ");
		pagado = Convert.ToInt32(Console.ReadLine());
		
		cambio = pagado - precio;
		Console.Write("Su cambio es de {0}: ", cambio);
		
		while(cambio != 0)
		{
			while (cambio >= 100)
			{
				Console.Write("100 ");
				cambio -= 100;
			}
			while (cambio >= 50)
			{
				Console.Write("50 ");
				cambio -= 50;
			}
			while (cambio >= 20)
			{
				Console.Write("20 ");
				cambio -= 20;
			}
			while (cambio >= 10)
			{
				Console.Write("10 ");
				cambio -= 10;
			}
			while (cambio >= 5)
			{
				Console.Write("5 ");
				cambio -= 5;
			}
			while (cambio >= 2)
			{
				Console.Write("2 ");
				cambio -= 2;
			}
			while (cambio >= 1)
			{
				Console.Write("1 ");
				cambio -= 1;
			}
		}
	}
}
