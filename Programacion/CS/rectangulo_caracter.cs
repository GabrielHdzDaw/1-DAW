/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 30-09-2024
 * Descripción: Realiza un programa en C# que pida los valores de base y 
 * altura de un rectángulo y el carácter a utilizar y lo dibuje por pantalla con dicho carácter:

###
###
###
###
 */ 
 


using System;
public class RectanguloCaracter
{
	public static void Main()
	{
		int alto, ancho;
		char caracter;
		Console.Write("Introduce la altura: ");
		alto = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce la anchura: ");
		ancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un carácter: ");
		caracter = Convert.ToChar(Console.ReadLine());
		
		for(int i = 0; i < alto; i++)
		{
			for(int j = 0; j < ancho; j++)
			{
				Console.Write(caracter);
			}
			Console.WriteLine();
		}
	}
}
