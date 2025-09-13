/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 28-10-2024
 * Descripción: Crea un programa en C# que pregunte al usuario el número de un mes 
 * (por ejemplo, 4 significará abril) y muestre el número de días que tiene ese mes.

Se debe hacer sin utilizar if ni switch, únicamente con un array de enteros.
 * 
 */

using System;
public class Test
{
	public static void Main()
	{
		int[] diasMes = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int mes; 
		Console.Write("Introduce un mes (en número): ");
		mes = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("El mes {0} tiene {1} días.", mes, diasMes[mes - 1]);
	}
}
