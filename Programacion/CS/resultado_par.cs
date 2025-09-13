/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17/09/2024
 * Descripción: Realiza un programa de C# que pedirá un número,
 *  si no es cero pedirá otro número y realizará la multiplicación sacando un mensaje
 *  indicando el resultado de la operación y si ese resultado es par o impar.
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
			if (producto % 2 == 0)
			{
				Console.WriteLine("{0} es par", producto);
			}
			else
			{
				Console.WriteLine("{0} es impar", producto);
			}
		}
		else
		{
			Console.WriteLine("El producto es: 0");
		}
	}
}
