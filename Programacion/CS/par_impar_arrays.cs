/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Pide 10 números enteros y guardalos en un array.

Después recorre ese array y cuenta cuantos hay pares y cuantos impares.(el 0 lo consideraremos par)
 * 
 */

using System;
public class ParImparArrays
{
	public static void Main()
	{
		int contadorPar = 0, contadorImpar = 0;
		int[] numeros = new int[10];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			if (numeros[i] % 2 == 0)
			{
				contadorPar++;
			}
			else
			{
				contadorImpar++;
			}
		}
		Console.Write("Pares: {0}  Impares:{1}", contadorPar, contadorImpar);
	}
}
