/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 28-10-2024
 * Descripción: Crea un array que contenga 10 números enteros que introducirá el usuario.
 * 
 */

using System;
public class BuscarArrayV1
{
	public static void Main()
	{
		int cantidadNumeros = 10;
		int[] numeros = new int[cantidadNumeros];
		
		for (int i = 0; i < cantidadNumeros; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
	}
}
