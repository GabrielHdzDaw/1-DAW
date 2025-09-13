/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 19-11-2024
 * Descripción: Realiza una función llamada EsPrimoCircular que devuelva verdadero si un entero proporcionado
 *  como parámetro es primo circular.

http://en.wikipedia.org/wiki/Circular_prime
 * 
 */

using System;
public class PrimoCircular
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
	
	public static bool EsPrimoCircular(int numero) 
	{
		bool esPrimoCircular = true;
		int numeroOriginal = numero;
		
		do
		{
			esPrimoCircular = EsPrimo(numero);
		} while ((numero = Rotar(numero)) != numeroOriginal && esPrimoCircular);

		return esPrimoCircular;
	}
	public static int Rotar(int numero)
	{
		string numeroString = Convert.ToString(numero);
		return Convert.ToInt32(numeroString.Substring(1) + numeroString[0]);
	}
	public static void Main()
	{
		Console.Write("Introduce un número: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(EsPrimoCircular(numero) ? "Es primo circular" : "No es primo circular");
	}
}
