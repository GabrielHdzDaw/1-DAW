/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 28-10-2024
 * Descripción:Crea un array que contenga 10 números enteros que introducirá el usuario.

Después de eso, pide al usuario un número y contesta si el número se encuentra o no en el array.
 * 
 * 
 */

using System;
public class BuscarArrayV2
{
	public static void Main()
	{
		int cantidadNumeros = 10;
		int[] numeros = new int[cantidadNumeros];
		int	numero;
		bool numeroPresente = false;
		
		for (int i = 0; i < cantidadNumeros; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.Write("Introduce un número para ver si está presente en el array: ");
		numero = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < cantidadNumeros; i++)
		{
			numeroPresente = numeros[i] == numero;
		}
		if (numeroPresente)
		{
			Console.WriteLine("{0} está presente en el array.", numero);
		}
	}
}
