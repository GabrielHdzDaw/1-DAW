/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-10-2024
 * Descripción: Realiza un programa en C# que pida al usuario si quiere calcular 
 * el área de un triángulo o de un círculo y le pida los datos correspondientes para
 *  calcular el área. Utiliza las funciones de Math que necesites.
 * 
 */

using System;
public class CalculadoraAreas
{
	public static void Main()
	{
		int eleccion;
		double anchura, altura, radio, area = 0;
		
		Console.WriteLine("Selecciona:\n(1) Área de triángulo\n(2) Área de círculo ");
		eleccion = Convert.ToInt32(Console.ReadLine());
		
		if (eleccion == 1)
		{
			Console.Write("Introduce base del triángulo: ");
			anchura = Convert.ToDouble(Console.ReadLine());
			Console.Write("Introduce altura del triángulo: ");
			altura = Convert.ToDouble(Console.ReadLine());
			
			area = (anchura * altura) / 2;
		}
		else
		{
			if (eleccion == 2)
			{
				Console.Write("Introduce radio del círculo: ");
				radio = Convert.ToDouble(Console.ReadLine());
				
				area = Math.PI * Math.Pow(radio, 2);
			}
		}
		Console.WriteLine("Área: {0}", area);
	}
}
