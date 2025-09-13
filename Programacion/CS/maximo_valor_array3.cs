/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Crea un array. A continuación pregunta al usuario cuantos 
 * números va a introducir. Reserva la memoria adecuada y pide a continuación los números 
 * al usuario que se introducirán en el array. Por último, encuentra y muestra el máximo valor del array.
 *  
 */

using System;
public class MaximoValorArray3
{
	public static void Main()
	{
		int[] numeros;
		int longitudArray;
		Console.Write("Introduce longitud de array: ");
		longitudArray = Convert.ToInt32(Console.ReadLine());
		numeros = new int[longitudArray];
		
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
