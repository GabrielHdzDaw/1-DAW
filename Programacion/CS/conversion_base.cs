/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 15-10-2024
 * Descripción: Realiza un programa en C# que pida al usuario
 *  un número y una base a la que se debe transformar ese número
 *  y devuelva ese número transformado a la base solicitada.
 * 
 */

using System;
public class ConversionDeBase
{
	public static void Main()
	{
		int numero, baseSeleccionada;
		
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce la base : ");
		baseSeleccionada = Convert.ToInt32(Console.ReadLine());
		
		if (baseSeleccionada != 2 && baseSeleccionada != 8 && baseSeleccionada != 16)
		{
			Console.WriteLine("Error");
		}
		else
		{
			Console.WriteLine(Convert.ToString(numero, baseSeleccionada));
		}
	}
}
