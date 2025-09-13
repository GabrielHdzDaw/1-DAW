/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-11-2024
 * Descripción: Crea un programa que pida las notas de 2 cursos de 10 alumnos cada uno y muestre la media de cada curso.
 * 
 */

using System;
public class MediaDosCursosArraysDimensionales
{
	public static void Main()
	{
		double[,] notas = new double[2,10];
		double[] sumasNotas = new double[notas.GetLength(0)];
		for (int i = 0; i < notas.GetLength(0); i++)
		{
			for (int j = 0; j < notas.GetLength(1); j++)
			{
				Console.Write("Introduce nota: {0}, {1}: ", i+1, j+1);
				notas[i,j] = Convert.ToDouble(Console.ReadLine());
			}
		}
		
		for (int i = 0; i < notas.GetLength(0); i++)
		{
			for (int j = 0; j < notas.GetLength(1); j++)
			{
				sumasNotas[i] += notas[i,j];
			}
		}
		
		for (int i = 0; i < sumasNotas.Length; i++)
		{
			Console.WriteLine("Media curso {0}: {1}", i, sumasNotas[i] / notas.GetLength(1));
		}
	}
}
