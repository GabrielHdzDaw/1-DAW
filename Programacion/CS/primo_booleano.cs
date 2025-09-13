/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Realiza un programa que usando una variable booleana indique 
 * si un número introducido por el usuario es primo o no. Utiliza 
 * la variable esPrimo de tipo bool para terminar el bucle.
 * 
 */

using System;
public class EsPrimoBool
{
	public static void Main()
	{
		int numero;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		bool esPrimo = true;
		for (int i = 2; i <= numero/2 && esPrimo ; i++)
		{
			esPrimo = numero % i != 0;
		}
		Console.WriteLine(esPrimo);
	}
}
