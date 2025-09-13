/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 02-12-2024
 * Descripción: Realiza una función recursiva que muestre el contenido de un array. 
 * La función recursiva recibirá el array y un índice.
 * 
 */

using System;
public class ArraysRecursiva
{
	public static void MostrarArray(string[] array, int indice)
	{
		if (indice == array.Length - 1)
		{
			Console.WriteLine(array[indice]);
		}
		else
		{
			Console.WriteLine(array[indice]);
			MostrarArray(array, indice + 1);
		}
	}
	public static void Main()
	{
		string[] array = {"Patatas", "Lentejas", "Habichuelas", "Zanahorias", "Espinacas"};
		MostrarArray(array, 0);
	}
}
