/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-12-2024
 * Descripción: Realiza una función llamada CuentaParImpar que reciba tres enteros como parámetro, uno
 *  será un entero del que se tendrá que contar cuantas cifras tiene pares y cuantas impares.
 *  Y esos valores se devolverán en los otros dos parámetros.
 *  
 */

using System;
public class ContarParesImparesArgs
{
	public static void CuentaParImpar(int numero, out int pares, out int impares)
	{
		pares = 0;
		impares = 0;
		while (numero > 0)
		{
			if ((numero % 10) % 2 == 0)
			{
				pares++;
			}
			else 
			{
				impares++;
			}
			numero /= 10;
		}	
	}
	public static void Main()
	{
		int pares = 0, impares = 0;
		CuentaParImpar(192332, out pares, out impares);
		Console.WriteLine("Pares: " + pares + " Impares: " + impares);
	}
}
