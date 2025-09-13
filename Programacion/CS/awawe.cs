/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-10-2024
 * Descripción:
 */ 
 


using System;
public class Test
{
	public static void Main()
	{
		int ancho, alto;
		Console.Write("Introduce la base: ");
		ancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce la altura: ");
		alto = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 0; i <= alto; i++)
		{
			for (int j = 0; j <= ancho; j++)
			{
				if (i == 0 || i == alto || j == 0 || j == ancho)
				{
					if ( i == (alto / 2) - 3 || i == (alto / 2) - 3)
					{
						if(j == (ancho / 2) -3 || j == (ancho / 2) +3)
						{
							Console.Write("#");
						}
					}
					Console.Write("#");
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
