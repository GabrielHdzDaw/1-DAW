/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 19-09-2024
 * Descripción: Crea un programa que pida al usuario dos números enteros y diga si son
	iguales o, en caso contrario, cuál es el mayor de ellos. Hazlo 2 veces una con if else
	y otra con el operador condicional.
 */

using System;
public class IgualesOMayor
{
	public static void Main()
	{
		int num1, num2, mayor;
		Console.Write("Introduce un número: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		//if (num1 == num2)
		//{
			//Console.WriteLine("Son iguales.");
		//}
		//else if (num1 > num2)
		//{
			//Console.WriteLine("{0} es mayor que {1}.", num1, num2);
		//}
		//else
		//{
			//Console.WriteLine("{0} es menor que {1}.", num1, num2);
		//}
		
		
		Console.WriteLine(num1 == num2 ? "Son iguales" : num1 > num2 ? "{0} es mayor" : "{0} es menor", num1);
		
	}
}
