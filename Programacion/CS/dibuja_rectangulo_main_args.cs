/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-12-2024
 * Descripción: Realiza una función llamada DibujaRectangulo que dibuje un rectángulo de asteriscos  de la 
 * altura y anchura proporcionada como parámetros.
Por ejemplo DibujaRectangulo(4,3)
***
***
***
***
Y realiza otra función llamada DibujaRectanguloHueco que dibuje un rectángulo hueco de la altura y anchura 
proporcionada como parámetro.
DibujaRectanguloHueco(4,3)
***
*  *
*  *
***
Realiza un Main para probar estas funciones que reciba como primer parámetro la palabra "lleno" o "hueco" 
y dos enteros que indicarán a qué función se debe llamar y con qué parámetros
 * 
 */

using System;
public class DibujaRectangulo
{
	public static bool ComprobarArgumentos(string[] args)
	{
		if (args.Length == 3)
		{
			if (args[0] == "lleno" || args[0] == "hueco")
			{
				return true;
			}
		} 
		return false;
	}
	public static void DibujarRectangulo(int anchura, int altura)
	{
		for (int i = 0; i < altura; i++)
		{
			for (int j = 0; j < anchura; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
	
	public static void DibujarRectanguloHueco(int anchura, int altura)
	{
		for (int i = 0; i <= altura; i++)
		{
			for (int j = 0; j <= anchura; j++)
			{
				if (i == 0 || i == altura || j == 0 || j == anchura)
				{
					Console.Write("*");
				}	
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
	public static void Main(string[] args)
	{
		if (ComprobarArgumentos(args))
		{
			int anchura = Convert.ToInt32(args[1]);
			int altura = Convert.ToInt32(args[2]);
			if (args[0] == "lleno")
			{
				DibujarRectangulo(anchura, altura);
			}
			else
			{
				DibujarRectanguloHueco(anchura, altura);
			}
		} else
		{
			Console.WriteLine("Los argumentos no son válidos");
		}
	}
}
