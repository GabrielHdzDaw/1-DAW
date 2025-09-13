/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17/09/2024
 * Descripción: Realiza un programa de C# que pedirá un número, si no es cero pedirá otro número y realizará la
 * multiplicación sacando el resultado. Si se introdujo un 0 se mostrará directamente "El producto es 0"
*/

using System;
public class MultiplicacionSinCero
{
	public static void Main()
	{
		int num1;
		Console.Write("Introduce un número: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		if (num1 != 0)
		{
			int num2, producto;
			Console.Write("Introduce otro número: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			producto = num1 * num2;
			Console.WriteLine("{0} X {1} = {2}", num1, num2, producto);
		}
		else
		{
			Console.Write("El producto es: 0");
		}
	}
}
