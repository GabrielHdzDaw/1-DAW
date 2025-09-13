/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 01-10-2024
 * Descripción: Escribe los números del 1 al 9, después del 1 al 8, del 1 al 7,
 *  y así sucesivamente en líneas diferentes.
123456789
12345678
1234567
123456
12345
1234
123
12
1
 */ 
 


using System;
public class TrianguloNumeros
{
	public static void Main()
	{
		for(int i = 9; i >= 1; i--)
		{
			for(int j = 1; j <= i; j++)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}
}
