/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-09-2024
 * Descripción: Crea un programa que le pida un número al usuario y calcule su factorial.
 *  El factorial de un número se calcula multiplicando todos los números que van desde el
 *  1 hasta dicho número. Por ejemplo, el factorial de 6 se calcularía multiplicando 6·5·4·3·2·1
 * 
 */

using System;
public class Factorial
{
	public static void Main()
	{
		int numero, factorial = 1;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		for (int i = numero; i>=1; i--)
		{
			factorial = factorial * i;
		}
		Console.WriteLine(factorial);
	}
}
