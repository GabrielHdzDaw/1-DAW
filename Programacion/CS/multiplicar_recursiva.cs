/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-11-2024
 * Descripción: Crea dos funciones, Multiplicar y MultiplicarR ,que calcule el producto de 2 
 * números enteros no negativos usando sumas. La primera versión será iterativa y la segunda debe ser recursiva.
 * 
 */

using System;
public class MultiplicarRecursiva
{
	public static int Multiplicar(int numero1, int numero2)
	{
		int resultado = 0;
		for (int i = 0; i < numero2; i++)
		{
			resultado += numero1;
		}
		return resultado;
	}
	
	public static int MultiplicarR(int numero1, int numero2)
	{
		if (numero2 == 0)
		{
			return 0;
		}
		return numero1 + MultiplicarR(numero1, numero2 - 1);
		
	}
	public static void Main()
	{
		Console.WriteLine(MultiplicarR(2,3));
	}
}
