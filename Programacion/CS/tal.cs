/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-09-2024
 * Descripción:
 * 
 */

using System;
public class Test
{
	public static void Main()
	{
		char caracter;
		caracter = Convert.ToChar(Console.ReadLine());
		if (caracter <= 'b')
		{
			Console.WriteLine("{0} es mayor que b", caracter);
		}
	}
}
