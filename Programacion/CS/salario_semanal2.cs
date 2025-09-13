/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-10-2024
 * Descripción: Realiza un programa en C# que pida las horas trabajadas durante cada
 *  uno de los días de la semana y mostrará lo que se deberá cobrar esa semana teniendo
 *  en cuenta que si algún día trabaja más de 8 horas debe cobrar un plus por cada hora extra realizada.
Ejemplo de funcionamiento para un precio por hora de 20 y un plus de 50%
Horas trabajadas:
Lunes: 8
Martes: 9
Miércoles: 8
Jueves:9
Viernes:9
Horas trabajadas: 43. Horas extras: 3
Total a cobrar: 890
 * 
 */

using System;
public class SalarioSemanal
{
	const int PRECIO_HORA = 20;
	const double PORCENTAJE_HORA_EXTRA = 0.5;
	
	public static void Main()
	{
		double horas = 0, totalHoras = 0, extras = 0;
		double salarioTotal = 0;
		string dia = "";
		
		for (int i = 0; i <= 4; i++)
		{
			switch (i)
			{
				case 0:
					dia = "lunes";
					break;
				case 1:
					dia = "martes";
					break;
				case 2:
					dia = "miércoles";
					break;
				case 3:
					dia = "jueves";
					break;
				case 4:
					dia = "viernes";
					break;
			}
			Console.Write("{0}: ", dia);
			horas = Convert.ToDouble(Console.ReadLine());
			
			if (horas > 8)
			{
				salarioTotal += (horas * PRECIO_HORA) + ((horas - 8) * PRECIO_HORA + PRECIO_HORA * PORCENTAJE_HORA_EXTRA);
				extras += horas - 8;
				totalHoras += horas;
			}
			else
			{
				salarioTotal += horas * PRECIO_HORA;
				totalHoras += horas;
			}
		}
		Console.WriteLine("Horas trabajadas: {0}. Horas extras: {1}\nTotal a cobrar: {2}", totalHoras, extras, salarioTotal);
	}
}
