/*
 * Autor: Gabriel Hernández Collado * Fecha: 17-09-2024 * Descripción: Crea un programa de C# que responda si un número 
 introducido por el usuario es par * o impar utilizando el operador condicional. Saca por pantalla un 2 si es par y un 
 1 si es impar. */

using System;
public class ParTernario
{
	public static void Main()
	{
		int num, parImpar;
		Console.Write("Introduce un número: ");
		num = Convert.ToInt32(Console.ReadLine());
		parImpar = num % 2 == 0 ? 2 : 1;
		Console.WriteLine(parImpar);
	}
}

