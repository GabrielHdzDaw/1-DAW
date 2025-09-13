/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-10-2024
 * Descripción:Pide al usuario las horas trabajadas. Si trabaja más de 40 horas,
 *  aplica una tarifa extra (% adicional) para las horas adicionales. El preci
 * o por hora será una constante y el extra será otra constante. 
Muestra el salario final.
Ejemplo de funcionamiento para 20 el precio por hora y 50% de extra:
Horas trabajadas: 45
Total a cobrar: 950 (40*20 + 5 *30)
 *  
 */

using System;
public class SalarioSemanal
{
	const int PRECIO_HORA = 20;
	const double PORCENTAJE_HORA_EXTRA = 0.5;
	
	public static void Main()
	{
		double horas;
		double salario;
		
		Console.Write("Introduce número de horas: ");
		horas = Convert.ToInt32(Console.ReadLine());
		
		if (horas > 40)
		{
			salario = (40 * PRECIO_HORA) + ((horas - 40) * PRECIO_HORA + PRECIO_HORA * PORCENTAJE_HORA_EXTRA);
			Console.WriteLine("Horas trabajadas: {0}\nTotal a cobrar: {1} (40 * {2} + {3} * {4})", horas, salario, PRECIO_HORA, horas - 40, PRECIO_HORA + PRECIO_HORA * PORCENTAJE_HORA_EXTRA);
		}
		else
		{
			salario = horas * PRECIO_HORA;
			Console.WriteLine("Horas trabajadas: {0}\nTotal a cobrar: {1}  ({2} * {3})", horas, salario, horas, PRECIO_HORA);
		}
		
	}
}
