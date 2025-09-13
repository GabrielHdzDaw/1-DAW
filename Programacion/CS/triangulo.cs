/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-10-2024
 * Descripción: ealiza un programa en C# que imprima por pantalla un triángulo
 *  de las alturas que le suministre el usuario y que quede de la siguiente forma.

####
###
##
#

 */ 
 


using System;
public class Triangulo
{
	public static void Main()
	{
		int altura;
		Console.Write("Introduce un número: ");
		altura = Convert.ToInt32(Console.ReadLine());
		for (int i = altura; i > 0; i--)
		{
			for (int j = 0; j < i; j++)
			{
				Console.Write("#");
			}
			Console.WriteLine();
		}
	}
}
