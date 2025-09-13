/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: 1.- Pide 10 números enteros y guárdalos en un array.
2.- Recorre ese array y cuenta cuantos hay positivos, cuantos negativos y cuantos 0.
3.- Crea 2 arrays uno para los positivos y otro para los negativos.
4.-  Recorre el array original y copia los números positivos en el array de positivos y el
 de los negativos en el array de negativos.
 * 
 */

using System;
public class PositivosNegativosArrays2
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
		
		int[] positivos = new int[contadorPositivos];
		int[] negativos = new int[contadorNegativos];
		
		int indicePositivos = 0, indiceNegativos = 0;
		
		for (int i = 0; i < numeros.Length; i++)
		{
			if (numeros[i] > 0)
			{
				positivos[indicePositivos] = numeros[i];
				indicePositivos++;
			}
			else
			{
				if (numeros[i] < 0)
				{
					negativos[indiceNegativos] = numeros[i];
					indiceNegativos++;
				}
			}
		}
	}
}
