/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-09-2024
 * Descripción: Realiza un programa en C# que a pida un número al usuario
 *  y cuente los números pares hasta ese número, contando de 1 en 1 y contando de 2 en 2.
 * 
 */

using System;
public class Test
{
	public static void Main()
	{
		int numero, pares = 0;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		for(int i = 1; i<= numero; i++)
		{
			if (i % 2 == 0)
			{
				pares++;
			}
		}
		Console.WriteLine("Pares contando de 1 en 1: {0}", pares);
		
		pares = 0;
		
		for(int i = 2; i<= numero; i+=2)
		{	
			pares++;
		}
		Console.WriteLine("Pares contando de 2 en 2: {0}", pares);
	}
}
