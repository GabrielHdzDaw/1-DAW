/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 19-09-2024
 * Descripción: Pide un número al usuario y devuelve el número de días del mes
 * 
 */

using System;
public class SwitchMes2
{
	public static void Main()
	{
		int num, dias;
		Console.Write("Introduce un número del 1 al 12: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		switch (num)
		{
			case 1: 
			case 3: 
			case 5: 
			case 7: 
			case 8: 
			case 10:
			case 12: dias = 31; break;
			case 2: dias = 28; break;
			case 4: 
			case 6: 
			case 9: 
			case 11: dias = 30; break;
		}
		Console.WriteLine(dias);
		
		if (num == 1 || num == 3 || num == 5 || num == 7 || num == 8 || num == 10 || num == 12)
		{
			Console.WriteLine("Tiene 31 días");
		}
		else
		{
			if (num == 4 || num == 6 || num == 9 || num == 11)
			{
				Console.WriteLine("Tiene 30 días");
			}
			else
			{
				if(num == 2)
				{
					Console.WriteLine("Tiene 28 días");
				}
				else
				{
					Console.WriteLine("Mes no válido");
				}
			}
		}
	}
}
