/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 02-12-2024
 * Descripción: Realiza una función recursiva que sume los números pares desde n (parámetro de la función) hasta 2.
Si el usuario introduce un número no par se debe sacar mensaje de error.
 * 
 */

using System;
public class SumarParesRecursiva
{
	public static int SumarPares(int numero)
	{
		if (numero == 0)
		{
			return 0;
		}
		return numero + SumarPares(numero - 2);
	}
	public static void Main()
	{
		Console.Write("Introduce un número: ");
		int numero = Convert.ToInt32(Console.ReadLine());
		if (numero % 2 != 0)
		{
			Console.WriteLine("El número no es par");
		}
		else
		{
			Console.WriteLine(SumarPares(10));
		}
	}
}
