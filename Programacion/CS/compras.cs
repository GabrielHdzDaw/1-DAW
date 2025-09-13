/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 22-10-2024
 * Descripción: Realiza un programa en C# que vaya pidiendo números 
 * reales de doble precisión correspondientes a la cantidad y precio
 *  de un producto.Cuando se introduzca "fin" en cantidad o precio se
 *  termina y se saca el total gastado, (suma de cantidades*precio),
 *  la media de los precios y el total de productos comprados.
Cantidad : 10  precio: 5,2
Cantidad: 3  precio: 15,6
...
Total 98,8  Media precios: 10,4   Cantidad comprada: 13
 * 
 */

using System;
public class Compras
{
	public static void Main()
	{
		double cantidad, precio = 0, precios = 0, totalPrecio= 0, totalGastado = 0, totalProductos = 0;
		string cantidadString, precioString;
		do
		{
			Console.Write("Introduce una cantidad: ");
			cantidadString = Console.ReadLine();
			Console.Write("Introduce un precio: ");
			precioString = Console.ReadLine();
			if (cantidadString != "fin" && precioString != "fin")
			{
				cantidad = Convert.ToDouble(cantidadString);
				precio = Convert.ToDouble(precioString);
				totalPrecio += precio;
				totalGastado += cantidad * precio;
				totalProductos += cantidad;
				precios++;
			}
			
		} while (cantidadString != "fin" && precioString != "fin");
		Console.WriteLine("Total: {0}  Media precios: {1}  Cantidad comprada: {2}", totalGastado, totalPrecio / precios, totalProductos);
	}
}
