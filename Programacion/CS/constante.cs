/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: Pide al usuario un número de millas y muestra por pantalla cuantos metros son:

1 milla=1609 metros

Usa una constante para guardar el valor anterior y usarlo en los cálculos
 * 
 */

using System;
public class Constantes
{
	public static void Main()
	{
		const double MILLA = 1609;
		double numero;
		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.Write("Introduce un número: ");
		Console.ForegroundColor = ConsoleColor.Blue;
		numero = Convert.ToDouble(Console.ReadLine());
		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.WriteLine("{0} millas en metros son: {1}", numero, numero * MILLA);
	}
}
