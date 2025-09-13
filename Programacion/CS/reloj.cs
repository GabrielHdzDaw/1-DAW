/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-12-2024
 * Descripción: Reloj
 * 
 */

using System;
using System.Threading;
public class Reloj
{
	public static void Main()
	{
		int x = Console.WindowWidth / 2;
		int y = Console.WindowHeight / 2;
		
		int dx = 1;
		int dy = 1;
		
		
		
		
		while (true)
		{
			Console.CursorVisible = false;
			Console.Clear();
			
			if (x + dx >= Console.WindowWidth || x + dx <= 0)
			{
				dx *= -1;
			}
			
			if (y + dy >= Console.WindowHeight || y + dy <= 0)
			{
				dy *= -1;
			}
			
			x += dx;
			y += dy;
			
			DateTime fecha = DateTime.Now;
			Console.SetCursorPosition(x, y);
			Console.Write(fecha.ToString("T"));
			Thread.Sleep(100);
		}
	}
}
