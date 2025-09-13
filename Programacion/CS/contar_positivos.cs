/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-09-2024
 * Descripción:Pide al usuario números hasta que introduzca un 0 y respondes al final cuantos eran positivos.
 * 
 */

using System;
public class ContarPositivos
{
	public static void Main()
	{
		int numero = 1, contador = 0;
		while(numero != 0)
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			if (numero > 0)
			{
				contador++;
			}
		}
		Console.WriteLine("Números positivos: {0}", contador);	
	}
}
