/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: 

Un programa que pida al usuario 10 enteros, los guarde en un array y calcule su media.

(Primero guardamos todos los datos en el array y luego lo volvemos a recorrer para calcular la media) 

y luego muestre los que están por encima de la media.

 * 
 */

using System;
public class PorEncimaMedia2
{
	public static void Main()
	{
		int[] numeros = new int[10];
		
		int suma = 0;
		double media;
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			suma += numeros[i];
		}
		media = suma / numeros.Length;
		
		Console.WriteLine("Media: {0}", media);
		
		Console.Write("Por encima de la media: ");
		for (int i = 0; i < numeros.Length; i++)
		{
			if (numeros[i] > media)
			
				Console.Write("{0} ", numeros[i]);
			}
		}
	}
