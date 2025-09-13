/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-10-2024
 * Descripción: Pide al usuario un alto y dibuja un triángulo centrado.
 *     *
 *   * * *
 * * * * * *
 */  
 


using System;
public class Piramide
{
	public static void Main()
	{
		int altura, asteriscos = 1;
		Console.Write("Introduce la altura: ");
		altura = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 0; i < altura; i++)
		{
			for (int k = 0; k < altura - i; k++)
			{
				Console.Write(" ");
			}
			for (int j = 0; j < asteriscos; j++)
			{
				if (j == asteriscos - 1 || j == 0 || i == altura - 1)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
				
			}
			
			asteriscos += 2;
			Console.WriteLine();
		}
	}
}
