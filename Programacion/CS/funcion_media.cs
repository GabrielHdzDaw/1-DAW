/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-11-2024
 * Descripción: Crea una función llamada Media, que devuelve un "double"
 *  que será el resultado de calcular la media de 3 doubles pasados como parámetro.
 * 
 */

using System;
public class Media
{
	public static double CalcularMedia(double n1, double n2, double n3)
	{
		return (n1 + n2 + n3) / 3;
	}
	public static void Main()
	{
		double numero1, numero2, numero3;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce un número: ");
		numero2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce un número: ");
		numero3 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(CalcularMedia(numero1, numero2, numero3));
	}
}
