/*
 * Gabriel Hernández Collado
 * 16/09/2024
 * Comprueba qué número entero es mayor
 */

using System;
public class MayorOMenor
{
	public static void Main()
	{
		int num1, num2;
		Console.Write("Introduce un número: ");
		num1  = Convert.ToInt32(Console.ReadLine());


		Console.Write("Introduce otro número: ");
		num2  = Convert.ToInt32(Console.ReadLine());
		if (num1 >  num2)
		{
			Console.WriteLine("{0} es mayor que {1}.", num1, num2);
		} 
		else
		{
			Console.WriteLine("{0} es menor que {1}.", num1, num2);
		}
	}
}
