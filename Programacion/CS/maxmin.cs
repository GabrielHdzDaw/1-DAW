/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-11-2024
 * Descripción: Crea un programa que calcule y devuelva el máximo y el mínimo 
 * de los elementos de un array. Debe poder usarse así:


  int[] example = {20, 10, 5, 2 };

  MaxMin(example, ref max, ref min)
 * 
 */

using System;
public class MaxMinFuncion
{
	public static void MaxMin(int[] numeros, ref int max, ref int min)
	{
		max = numeros[0];
		min = numeros[0];
		for (int i = 0; i < numeros.Length; i++)
		{
			max = numeros[i] > max ? numeros[i] : max;
			min = numeros[i] < min ? numeros[i] : min;
		}
	}
	public static void Main()
	{
		int[] numeros = {5, 2, 14, 9, 32};
		int max = numeros[0];
		int min = numeros[0];
		
		MaxMin(numeros, ref max, ref min);
		Console.WriteLine("Max: {0}   Min: {1}", max, min);
	}
}
