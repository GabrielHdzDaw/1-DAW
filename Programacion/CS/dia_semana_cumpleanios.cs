/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-12-2024
 * Descripción: Muestra el día de la semana del cumpleaños del usuario
 * 
 */

using System;
public class DiaSemanaCumpleanios
{
	public static void Main()
	{
		Console.Write("Introduce el día de tu cumpleaños: ");
		int dia = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el mes de tu cumpleaños: ");
		int mes = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el año de tu cumpleaños: ");
		int anio = Convert.ToInt32(Console.ReadLine());
		
		DateTime fechaCumpleanios = new DateTime(anio, mes, dia);
		
		Console.WriteLine(fechaCumpleanios.DayOfWeek);
	}
}
