/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-11-2024
 * Descripción: Crea un array de 3 bloques de números enteros.
El primer bloque contendrá 3 elementos, el segundo 6 y el tercero 4.
Pide los datos y después muétralos.
 * 
 */

using System;
public class ArrayDeArrays
{
	public static void Main()
	{
		int[][] numeros = new int[3][];
		numeros[0] = new int[3];
		numeros[1] = new int[6];
		numeros[2] = new int[4];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			for (int j = 0; j < numeros[i].Length; j++)
			{
				Console.Write("Introduce un número {0}, {1}: ", i+1, j+1);
				numeros[i][j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			for (int j = 0; j < numeros[i].Length; j++)
			{
				Console.Write("{0} ", numeros[i][j]);
			}
			Console.WriteLine();
		}
	}
}
