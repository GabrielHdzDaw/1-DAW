/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 23-09-2024
 * Descripción:Realiza un programa en C# que pida un usuario y contraseña 
 * de forma repetitiva hasta que se introduzca la correcta que será usuario:1212 
 * y contraseña:3434. Se le darán al usuario sólo 3 intentos.
 */

using System;
public class ContrasenaUsuario3Intentos
{
	public static void Main()
	{
		int usuario = 1212, password = 3434, inputUsuario = 0, inputPassword = 0, intentos = 0;
		
		while((inputUsuario != usuario || inputPassword != password) && intentos < 3)
		{
			intentos++;
			Console.Write("Introduce usuario: ");
			inputUsuario = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Introduce contraseña: ");
			inputPassword = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine(intentos >= 3 ? "Límite de intentos superado." : "Usuario y contraseña correctos.");
	}
}
