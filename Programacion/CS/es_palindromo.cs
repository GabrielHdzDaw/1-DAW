/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 19-11-2024
 * Descripción: Crea una función llamada EsPalindromo que devolverá true si el entero recibido como parámetro es
 *  palíndromo y false si no lo es. Un número o cadena palíndromo es cuando se lee igual de derecha a izquierda 
 * que de izquierda a derecha. Por ejemplo 686 es palíndromo.


 * 
 */

using System;
public class Palindromo
{
	public static bool EsPalindromo(int numero)
	{
		return numero == DarVuelta(numero);
	}
	
	public static int DarVuelta(int numero)
	{
		string numeroString = Convert.ToString(numero);
		string numeroReves = "";
		for (int i = numeroString.Length - 1; i >= 0; i--)
		{
			numeroReves += numeroString[i];
		}
		
		return Convert.ToInt32(numeroReves);
	}
	public static void Main()
	{
		Console.Write("Introduce un número: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(EsPalindromo(numero) ? "Es palíndromo" : "No es palíndromo");
	}
}
