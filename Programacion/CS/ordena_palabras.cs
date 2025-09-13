/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 15-11-2024
 * Descripción: Realiza un programa que le pida al usuario una lista de palabras
 *  separadas por comas y después las muestre ordenadas alfabéticamente.
 * 
 */

using System;
public class OrdenaPalabras
{
	public static void Main()
	{
		string palabras;
		string[] palabrasSplit;
		
		Console.Write("Introduce palabras separadas por coma: ");
		palabras = Console.ReadLine();
		palabrasSplit = palabras.Split(',');
		
		for (int i = 0; i < palabrasSplit.Length; i++)
		{
			palabrasSplit[i] = palabrasSplit[i].Trim();
		}
		
		Array.Sort(palabrasSplit);
		
		Console.WriteLine(String.Join(", ", palabrasSplit));
	}
}
