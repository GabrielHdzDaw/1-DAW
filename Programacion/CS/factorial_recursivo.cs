/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-11-2024
 * Descripción:
 * 
 */

using System;
public class FactorialRecursivo
{
	public static int Factorial(int num)
	{
		if (num == 1)
			return 1;
		return num * Factorial(num - 1);
	}
	public static void Main()
	{
		int n = 4;
		Console.WriteLine(Factorial(n));
	}
}
