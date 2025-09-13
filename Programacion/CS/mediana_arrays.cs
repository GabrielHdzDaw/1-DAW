/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-11-2024
 * Descripción: Realiza un programa que pida al usuario el número de números a procesar y 
 * a continuación le pida los números y los guarde en un array, los ordene (Array.Sort(nombreArray)) 
 * y saque por pantalla el mínimo, el máximo, la mediana y la media.
La mediana cuando la muestra de datos es par es la media de los dos elementos centrales.
 * 
 */

using System;
public class MedianaArrays
{
	public static void Main()
	{
		int cantidadNumeros;
		int numero, suma = 0, mediana;
		
		Console.Write("Introduce cantidad de números a procesar: ");
		cantidadNumeros = Convert.ToInt32(Console.ReadLine());
		
		int[] numeros = new int[cantidadNumeros];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			numeros[i] = numero;
		}
		
		Array.Sort(numeros);
		
		for (int i = 0; i < numeros.Length; i++)
		{
			suma += numeros[i];
		}
		if (cantidadNumeros % 2 != 0)
		{
			mediana = numeros[cantidadNumeros / 2];
		}
		else
		{
			mediana = (numeros[(cantidadNumeros / 2)] + numeros[(cantidadNumeros / 2) + 1]) / 2;
			
		}
		Console.WriteLine("Mínimo: {0}  máximo: {1}  mediana: {2}  media {3}", numeros[0], numeros[cantidadNumeros - 1], mediana , (double)((double)suma / numeros.Length));
	}
}
