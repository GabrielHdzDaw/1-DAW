/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-11-2024
 * Descripción: Escribe un programa que pida al usuario su nombre y lo enseñe 
 * como un triánculo, empezando por una letra y subiendo en cada línea hasta el final
 *  del nombre. (utiliza nombre.Length)

Introduce tu nombre: María

M
Ma
Mar
Marí
María
 * 
 */

using System;
public class TrianguloNombre
{
	public static void Main()
	{
		string nombre;
		Console.Write("Introduce un nombre: ");
		nombre = Console.ReadLine();
		
		for (int i = 0; i < nombre.Length; i++)
		{
			for (int j = 0; j <= i; j++)
			{
				Console.Write(nombre[j]);
			}
			Console.WriteLine();
		}
		
		for (int i = 0; i <= nombre.Length; i++)
		{
			Console.WriteLine(nombre.Substring(0, i));
		}
	}
}
