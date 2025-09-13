/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Crea un array que contenga los números 20,35,50,17,5,32. Encuentra y muestra el máximo valor en el array.

 * 
 */

using System;
public class MaximoValorArray
{
	public static void Main()
	{
		int[] numeros = {20, 35, 50, 17, 5, 32};
		
		int mayor = numeros[0];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			mayor = numeros[i] > mayor ? numeros[i] : mayor;
		}
		Console.WriteLine("Mayor: {0}", mayor);
	}
}
