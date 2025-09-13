
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 09-11-2024
 * Descripción: Crea un programa para jugar a la batalla naval:
Tendremos 3 barcos de 1, 2 y 3 posiciones.
1.- Creamos el tablero (array bidimensional de 10x10 de tipo char todas las posiciones con agua -> 'a')
2.- Pedimos al usuario los barcos por orden primero el de 1 posición, el de 2 y el de 3.
3.- Pedimos posiciones de los barcos, comprobamos que no están ocupadas por otro barco.
4.-Ponemos el barco en el tablero (pondremos 'b'  en las posiciones del tablero ocupadas por un barco)
 */

using System;
public class Barquitos
{
	public static void Main()
	{
		char[,] tablero = new char[10,10];
		char[][] barcos = new char[3][];
		barcos[0] = new char[1];
		barcos[1] = new char[2];
		barcos[2] = new char[3];
		int posicionX, posicionY;
		bool posicionValida = false;
		
		for (int i = 0; i < tablero.GetLength(0); i++)
		{
			for (int j = 0; j < tablero.GetLength(1); j++)
			{
				tablero[i,j] = 'a';
			}
		}
		
		for (int i = 0; i < barcos.Length; i++)
		{
			
			do
			{
				for (int j = 0; j < barcos[i].Length; j++)
				{
					Console.Write($"Introduce la posición X de la {j + 1}º parte del {i + 1}º barco: ");
					posicionX = Convert.ToInt32(Console.ReadLine());
					Console.Write($"Introduce la posición Y de la {j + 1}º parte del {i + 1}º barco: ");
					posicionY = Convert.ToInt32(Console.ReadLine());
					
					posicionValida = tablero[posicionX, posicionY] == 'a'; 
					//posicionValida = tablero[posicionX, posicionY] == 'a' && posicionX >= 0 && posicionX <= 10
					 //&& posicionY >= 0 && posicionY <= 10; 
					
					tablero[posicionX, posicionY] = 'b';
				}
				
				if (!posicionValida)
				{
					Console.WriteLine("La posición está ocupada");
				}
				
			} while (!posicionValida);
			
		}
		
		for (int i = 0; i < tablero.GetLength(0); i++)
		{
			for (int j = 0; j < tablero.GetLength(1); j++)
			{
				Console.Write($"|{tablero[i,j]}");
				
				if (j == tablero.GetLength(1) - 1)
				{
					Console.Write("|");
				}
			}
			Console.WriteLine();
		}
	}
}
