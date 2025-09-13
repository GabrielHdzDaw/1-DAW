/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 07-10-2024
 * Descripción: Pide al usuario un ancho y un alto y dibuja un rectángulo vacío.
Dime un ancho: 5
Dime un alto: 4
*****
*      *
*      *
*****
 */ 
 


using System;
public class RectanguloHueco
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
