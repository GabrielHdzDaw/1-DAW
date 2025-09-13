/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 23-09-2024
 * Descripción:Realiza un programa de C# que pedirá una contrase y la volverá 
 * a pedir hasta que se le introduzca la correcta que será 1111. 
 * Sólo se le permitirán al usuario 3 intentos.
 * 
 */

using System;
public class Contrasena3Intentos
{
	public static void Main()
	{
		int password, userInput = 0, intentos = 0;
		password = 1111;
		
		while(userInput != password && intentos < 3)
		{
			intentos++;
			Console.Write("Introduce la contraseña: ");
			userInput = Convert.ToInt32(Console.ReadLine());
			
		}
		Console.WriteLine(intentos >= 3 ? "Límite de intentos superado." : "Contraseña correcta.");
	}
}
