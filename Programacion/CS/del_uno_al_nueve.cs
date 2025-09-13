/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 30-09-2024
 * Descripción: Escribe en una misma línea los números del 1 al 9, 5 veces:
123456789123456789123456789123456789123456789
 */ 
 


using System;
public class DelUnoAl9
{
	public static void Main()
	{
		for(int i = 0; i < 5; i++)
		{
			for(int j = 1; j <= 9; j++)
			{
				Console.Write(j);
			}
		}
	}
}
