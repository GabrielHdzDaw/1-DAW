/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que calcule la media de una notas que introducirá el usuario.

Primero se le pide cuantas notas va a introducir. Luego se le piden las notas y al final se muestra la media.
 */ 
 


using System;
public class MediaDecimales2
{
	public static void Main()
	{
		int numeroNotas;
		double nota;
		double totalNotas = 0;
		Console.Write("Introduce número de notas a introducir: ");
		numeroNotas = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 0; i < numeroNotas; i++)
		{
			Console.Write("Introduce una nota: ");
			nota = Convert.ToDouble(Console.ReadLine());
			totalNotas += nota;
		}
		Console.WriteLine("La media es: {0}", totalNotas / numeroNotas);
		
	}
}
