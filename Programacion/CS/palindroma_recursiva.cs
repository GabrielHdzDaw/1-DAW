/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 02-12-2024
 * Descripción: Realiza una función que devuelva si una cadena es palíndroma de forma recursiva
 * 
 */

using System;
public class PalindromaRecursiva
{
	public static bool EsPalindromo(string cadena)
	{
		if (cadena.Length == 0 ||cadena.Length == 1)
		{
			return true;
		}
		return cadena[0] == cadena[cadena.Length - 1] && EsPalindromo(cadena.Substring(1, cadena.Length - 2));
	}
	public static void Main()
	{
		Console.Write(EsPalindromo("abba"));
	}
}
