/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-11-2024
 * Descripción: Crea un programa que pida al usuario 10 enteros, los guarde en un
 *  array bidimensional de 2x5, y muestre el número mayor de cada mitad del array y el mayor de todos.
 * 
 */

using System;
public class MaximoValorArrayBidimensional
{
	public static void Main()
	{
		double[,] datos = new double[2,5];
		double[] mayores = new double[datos.GetLength(0)];
		
		for (int i = 0; i < datos.GetLength(0); i++)
		{
			for (int j = 0; j < datos.GetLength(1); j++)
			{
				Console.Write("Introduce el número {0}, {1}: ", i+1, j+1);
				datos[i,j] = Convert.ToDouble(Console.ReadLine());
			}
		}
	
		mayores[0] = datos[0,0];
		mayores[1] = datos[1,0];
		
		for (int i = 0; i < datos.GetLength(0); i++)
		{
			for (int j = 0; j < datos.GetLength(1); j++)
			{
				mayores[i] = datos[i,j] > mayores[i] ? datos[i,j] : mayores[i];
			}
		}
		
		Console.WriteLine("Mayor dimesión 1: {0}  mayor dimensión 2: {1}  Mayor de todos: {2}", mayores[0], mayores[1], mayores[0] > mayores[1] ? mayores[0] : mayores[1] );
	}
}
