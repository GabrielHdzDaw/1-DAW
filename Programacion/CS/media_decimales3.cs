/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que calcule la media de una notas que introducirá el usuario. Introducirá 
 * notas y para indicar que ha terminado de introducir notas introducirá un -1.
 */ 
 


using System;
public class MediaDecimales3
{
	public static void Main()
	{
		double totalNotas = 0;
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
		
		Console.WriteLine("Media: {0}", totalNotas / numeroNotas);	
	}
}
