/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-11-2024
 * Descripción: Crea un programa que pida al usuario 10 números reales, 
 * los guarde en un array bidimensional llamado datos de 2x5, y después muestre 
 * los valores almacenados primero los de la primera mitad y después los de la segunda mitad.
 *  
 */

using System;
public class ValoresArrayBidimensional
{
	public static void Main()
	{
		double[,] datos = new double[2,5];
		
		
		for (int i = 0; i < datos.GetLength(0); i++)
		{
			for (int j = 0; j < datos.GetLength(1); j++)
			{
				Console.Write("Introduce el número {0}, {1}: ", i+1, j+1);
				datos[i,j] = Convert.ToDouble(Console.ReadLine());
			}
		}
		
		for (int i = 0; i < datos.GetLength(0); i++)
		{
			for (int j = 0; j < datos.GetLength(1); j++)
			{
				Console.Write(datos[i,j]);
			}
		}
	}
}
