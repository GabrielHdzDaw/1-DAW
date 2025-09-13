/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 19-11-2024
 * Descripción: Crea una función llamada EsPrimoPalindromo que devolverá true si el entero recibido
 *  como parámetro es palíndromo y primo y false si no lo es. Utiliza las dos funciones anteriores. 
 * La función será una sóla línea
 * 
 */

using System;
public class Test
{
	public static bool EsPrimoPalindromo(int numero)
	{
		return EsPrimo(numero) && EsPalindromo(numero);
	}
	
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
	
	public static bool EsPrimo(int numero)
	{
		bool esPrimo = true;
		for (int i  = 2; i <= numero/2 && esPrimo; i++)
		{
			esPrimo = numero % i != 0;
		}
		return esPrimo;
	}
	
	public static void Main()
	{
		Console.Write("Introduce un número: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(EsPrimoPalindromo(numero) ? "Es primo palíndromo" : "No es primo palíndromo");
	}
}
