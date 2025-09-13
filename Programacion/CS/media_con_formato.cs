/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 15-10-2024
 * Descripción: Modifica el programa anterior para sacar el resultado de la media con 2 decimales
 * 
 */

using System;
public class MediaDecimales3
{
	public static void Main()
	{
		double totalNotas = 0, media;
		int numeroNotas = 0;
		double nota = 0;
		
		
		do
		{
			Console.Write("Introduce una nota: ");
			nota = Convert.ToDouble(Console.ReadLine());
			if(nota != -1)
			{
				totalNotas += nota;
				numeroNotas++;
			}	
		} while (nota != -1);
		media = totalNotas / numeroNotas;
		Console.WriteLine("Media: {0}", media.ToString("N2"));	
	}
}
