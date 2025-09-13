/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Crea un array con espacio para 6 números enteros, que deberán
 *  ser introducidos por el usuario. Encuentra y muestra el máximo valor del array.
 * 
 */

using System;
public class MaximoValorArray2
{
	public static void Main()
	{
		int[] numeros = new int[6];
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		int mayor = numeros[0];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			mayor = numeros[i] > mayor ? numeros[i] : mayor;
		}
		Console.WriteLine("Mayor: {0}", mayor);
	}
}

