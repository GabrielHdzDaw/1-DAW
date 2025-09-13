/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-10-2024
 * Descripción: Realiza un programa en C# que pida al usuario un número y sacará las
 *  letras del abecedario empezando por la a y saltándose el número que haya introducido el usuario. Por ejemplo:

Introduzca el número de salto:

5

agmsy

(a bcdef g hijkl m nopqr s tuvwx y z
 * 
 */

using System;
public class LetrasSalteadas
{
	public static void Main()
	{
		int saltos;
		Console.Write("Introduce un número: ");
		saltos = Convert.ToInt32(Console.ReadLine());
		for (char c = 'a'; c <= 'z'; c+=(char)saltos)
		{
			
				Console.Write("{0} ", c);
			
		}
	}
}
