/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Pide 10 números enteros y guardalos en un array.

Después recorre ese array y cuenta cuantos hay positivos, negativos y ceros.
 * 
 */

using System;
public class PositivosNegativosArrays
{
	public static void Main()
	{
		int[] numeros = new int[10];
		int contadorPositivos = 0, contadorNegativos = 0, contadorCeros = 0;
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		for (int i = 0; i < numeros.Length; i++)
		{
			if (numeros[i] > 0)
			{
				contadorPositivos++;
			}
			else
			{
				if (numeros[i] < 0)
				{
					contadorNegativos++;
				}
				else
				{
					contadorCeros++;
				}
			}
		}
		Console.WriteLine("Positivos: {0} Negativos: {1} Ceros: {2}", contadorPositivos, contadorNegativos, contadorCeros);
	}
}
