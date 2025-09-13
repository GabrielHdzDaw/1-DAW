
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 22-10-2024
 * Descripción: -- Vamos a dibujar un calendario de un mes. Pediremos
 *  al usuario los días que tiene el mes (28,29,30 o 31) y el día en
 *  el que comienza el mes (lunes,martes...) y dibujaremos: (delante
 *  de los días menores  de diez dibujaremos un espacio en blanco)
Días del mes: 31
Día de comienzo del mes: jueves
          1  2  3  4
 5  6  7  8  9  10 11
 12 13 14 15 16 17 18
...
 */

using System;
public class Calendario
{
	public static void Main()
	{
		int numeroDias, numeroDia = 0;
		string nombreDia;
		Console.Write("Introduce número de días: ");
		numeroDias = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el día en el que comienza el mes: ");
		nombreDia = Console.ReadLine();
		
		switch (nombreDia)
		{
			case "lunes":
				numeroDia = 0;
				break;
			case "martes":
				numeroDia = 1;
				break;
			case "miercoles":
				numeroDia = 2;
				break;
			case "jueves":
				numeroDia = 3;
				break;
			case "viernes":
				numeroDia = 4;
				break;
			case "sabado":
				numeroDia = 5;
				break;
			case "domingo":
				numeroDia = 6;
				break;
			default:
				Console.WriteLine("Día no válido.");
				break;
		}
		
		for (int i = 0; i < numeroDia; i++)
		{
			Console.Write("   ");
		}
		
		for (int i  = 1; i <= numeroDias; i++)
		{	
			if (i < 10 )
			{
				Console.Write(" {0} ", i);
			}
			else
			{
				Console.Write("{0} ", i);
			}
			
			if ((i + numeroDia) % 7 == 0)
			{
				Console.WriteLine();
			}
		}
		
	}
	
}
