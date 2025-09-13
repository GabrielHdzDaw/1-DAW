/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-11-2024
 * Descripción: Escribe una función en C# que devuelva si un número entero recibido 
 * como parámetro es emirp. Un número es Emirp si es Primo y además ese mismo número al revés también es primo.
 * 
 */

using System;
public class FuncionEsImperp
{
	public static bool EsPrimo(int numero)
	{
		bool esPrimo = true;
		for (int i  = 2; i <= numero/2 && esPrimo; i++)
		{
			esPrimo = numero % i != 0;
		}
		return esPrimo;
	}
	
	public static bool EsEmirp(int numero)
	{
		return EsPrimo(numero) && EsPrimo(DarVuelta(numero));
		
	}
	
	public static int DarVuelta(int numero)
	{
		string numeroString = Convert.ToString(numero);
		char[] numeroArray = new char[numeroString.Length];
		for (int i = numeroArray.Length - 1; i > 0; i--)
		{
			numeroArray[i] = numeroString[i];
		}
		return Convert.ToInt32(numeroString);
	}
	
	public static void Main()
	{
		Console.WriteLine(EsEmirp(17) ? "Es emirp" : "No es emirp");
	}
}
