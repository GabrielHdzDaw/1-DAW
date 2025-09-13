/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-12-2024
 * Descripción: Crea un programa que pregunte al usuario el día y mes en que nació, y le
diga cuántos días faltan hasta su próximo cumpleaños.
 * 
 */

using System;
public class Cumpleanios
{
	public static void Main()
	{
		Console.Write("Introduce el día de tu cumpleaños: ");
		int dia = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el mes de tu cumpleaños: ");
		int mes = Convert.ToInt32(Console.ReadLine());
		
		DateTime fechaCumpleanios = new DateTime(2024, mes, dia);
		DateTime fechaActual = DateTime.Now;
		
		if (fechaCumpleanios.Subtract(fechaActual).Days < 0)
		{
			fechaCumpleanios = fechaCumpleanios.AddYears(1);
		}
			
		Console.WriteLine(fechaCumpleanios.Subtract(fechaActual).Days);
	}
}
