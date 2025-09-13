/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Realiza un programa que asigne a una variable string el valor
 *  "positivo", "negativo" o "cero", dependiendo de si un número entero n 
 * (introducido por el usuario) es positivo, negativo o cero.

Hazlo de dos formas diferentes, usando "if" y usando el operador condicional (?).
 * 
 */

using System;
public class CadenasCondicional
{
	public static void Main()
	{
		string entero;
		int numero;
		
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		if(numero < 0)
		{
			entero = "negativo";
		}
		else
		{
			if (numero > 0)
			{
				entero = "positivo";
			}
			else
			{
				entero = "cero";
			}
		}
		Console.WriteLine(entero);
		
		entero = numero < 0 ? "negativo" : numero > 0 ? "positivo" : "cero";
		Console.WriteLine(entero);
	}
}
