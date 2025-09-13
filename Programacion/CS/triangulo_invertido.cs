/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-10-2024
 * Descripción: Realiza un programa en C# que imprima por pantalla un 
 * triángulo invertido de las alturas que le suministre el usuario y que quede de la siguiente forma.

####
 ###
  ##
   #
 */ 
 


using System;
public class TrianguloInvertido
{
	public static void Main()
	{
		int altura;
		Console.Write("Introduce la altura: ");
		altura = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 0; i <= altura; i++)
		{
			for (int j = 0; j <= i; j++)
			{
				
				Console.Write(" ");
			}
			for (int k = 1; k <= altura - i; k++)
			{
				
				Console.Write("#");
			}
			Console.WriteLine();
		}
	}
}
