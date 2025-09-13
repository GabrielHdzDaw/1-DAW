/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-11-2024
 * Descripción: Crea un programa que pida al usuario el nombre de un mes
 *  en minúsculas y le muestre el número de dias de ese mes en un año no bisiesto.
No hacerlo con if, ni switch.
Por ejemplo:
Introduzca el mes: abril
abril tiene 30 días
 * 
 */

using System;
public class DiasDelMesArray
{
	public static void Main()
	{
		string[] nombresMeses = {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio",
			 "septiembre", "octubre", "noviembre", "diciembre"};
		int[] diasMeses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		string mes;
		
		Console.Write("Introduce el nombre de un mes en minúsculas: ");
		mes = Console.ReadLine();
		int i = 0;
		while (nombresMeses[i] != mes)
		{
			i++;
		}
		
		Console.WriteLine("{0} tiene {1} días.", mes, diasMeses[i]);
	}
}
