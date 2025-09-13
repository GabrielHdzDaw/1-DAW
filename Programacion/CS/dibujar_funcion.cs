/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 15-10-2024
 * Descripción: Crea un programa que "dibuje" la gráfica de (x-3)2 de 0 a 10

Deberá hacerlo dibujando espacios en blanco hasta alcanzar el valor de y. De esta forma la gráfica se verá torcida:
                 *
            *
     *
*
   *
        *
                  *
 * 
 */

using System;
public class DibujarFuncion
{
	public static void Main()
	{
		int y;
		for (int i = 0; i <= 10; i++)
		{
			y = (i - 3) * (i - 3);
			for (int j = 0; j <= y; j++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
		}
	}
}
