/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-09-2024
 * Descripción:Pide al usuario números hasta que introduzca un 0 y
 *  respondes al final cuantos eran positivos y cuantos negativos.
 * 
 */

using System;
public class ContarPositivosNegativos
{
	public static void Main()
	{
		int numero = 1, contadorPositivos = 0, contadorNegativos = 0;
		while(numero != 0)
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			if (numero > 0)
			{
				contadorPositivos++;
			}
			else
			{
				if (numero < 0)
				{
					contadorNegativos++;
				}
			}
			
			
		}
		Console.WriteLine("Números positivos: {0}\nNúmeros negativos: {1}", contadorPositivos, contadorNegativos);	
	}
}
