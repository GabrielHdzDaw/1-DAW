/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-10-2024
 * Descripción:Paralelogramo hueco
 */ 
 


using System;
public class ParalelogramoHueco
{
	public static void Main()
	{
		int altura, anchura;
		char caracter;
		
		Console.Write("Introduce la altura: ");
		altura = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce la base: ");
		anchura = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un carácter: ");
		caracter = Convert.ToChar(Console.ReadLine());
		
		for (int i = 0; i <= altura; i++)
		{
			for (int j = 0; j < i; j++)
			{
				Console.Write(" ");
			}
			for (int k = 0; k <= anchura; k++)
			{
				if(i == 0 || i == altura || k == 0 || k == anchura)
				{
					Console.Write(caracter);
				}
				else
				{
					Console.Write(" ");
				}
				
			}
			Console.WriteLine();
		} 
	}
}
