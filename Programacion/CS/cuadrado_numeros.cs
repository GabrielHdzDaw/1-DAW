/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-10-2024
 * Descripción: Crea un programa que "dibuje" un cuadrado formado por cifras sucesivas,
 *  con el tamaño que indique el usuario, hasta un máximo de 9. Por ejemplo, si desea tamaño 5, el cuadrado sería así:
11111
22222
33333
44444
55555
 */ 
 


using System;
public class CuadradoNumeros
{
	public static void Main()
	{
		int tamano;
		Console.Write("Introduce un número: ");
		tamano = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 1; i <= tamano; i++)
		{
			for (int j = 0; j < tamano; j++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}
}
