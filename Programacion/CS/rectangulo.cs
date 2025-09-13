/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 30-09-2024
 * Descripción: Realiza un programa en C# que pida los valores de base y altura
 *  de un rectángulo y lo dibuje por pantalla con asteriscos.

****
****
****
 */ 
 


using System;
public class Test
{
	public static void Main()
	{
		int alto, ancho;
		Console.Write("Introduce la altura: ");
		alto = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce la anchura: ");
		ancho = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 0; i < alto; i++)
		{
			for(int j = 0; j < ancho; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine("");
		}
		
	}
}
