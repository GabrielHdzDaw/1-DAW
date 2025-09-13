/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-11-2024
 * Descripción:
 *  Ahora vamos a hacer un array de 3 bloques pero se le pedirá al usuario el tamaño de cada uno de estos bloques.
Una vez definido el array, se pedirán los datos y se mostrará la media, el mayor y el menor de cada uno de estos bloques.

 */

using System;
public class ArrayDeArrays2
{
	public static void Main()
	{
		int[][] numeros = new int[3][];
		double[] suma = new double[numeros.Length];
		double mayores = new double[numeros.Length];
		double menores = new double[numeros.Length];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce tamaño array {0}: ", i);
			numeros[i] = new int[Convert.ToInt32(Console.ReadLine())];
		}
		
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
				suma[i] += numeros[i][j];
			}
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			
		}
		
		
	}
}
