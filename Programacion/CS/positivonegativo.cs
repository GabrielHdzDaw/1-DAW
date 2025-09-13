/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-09-2024
 * Descripción: Crea un programa en C# que asigne a una variable llamada 
 * signo el valor -1 si el valor del número introducido por el usuario es negativo, 
 * un 1 si es positivo. Muestra esta variable al final.
 */

using System;
public class PositivoNegativo
{
	public static void Main()
	{
		int num, signo;
		Console.Write("Introduce un número: ");
		num = Convert.ToInt32(Console.ReadLine());
		signo = (num < 0) ? -1 : (num > 0) ? 1 : 0;
		Console.WriteLine("Número: {0}. Signo {1}.", num, signo);
	}
}
