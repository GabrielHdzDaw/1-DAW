/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 30-09-2024
 * Descripción: Realiza un programa en C# que imprima por pantalla un 
 * triángulo de las alturas que le suministre el usuario y que quede de la siguiente forma.

#
##
###
####
 */ 
 


using System;
public class TrianguloV1
{
	public static void Main()
	{
		int alto;
		Console.Write("Introduce la altura: ");
		alto = Convert.ToInt32(Console.ReadLine());
	
		for(int i = 0; i <= alto; i++)
		{
			for(int j = 0; j < i; j++)
			{
				Console.Write("#");
			}
			Console.WriteLine("");
		}
	}
}
