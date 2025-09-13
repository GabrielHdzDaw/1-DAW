/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Crea un programa en C# que pida al usuario su usuario y contraseña. 
 * No le permitirá pasar hasta que introduzca "user" como usuario y "password" como contraseña.
 *  Se deben usar dos variables booleanas llamadas "nombreCorrecto" y "passwordCorrecto" en las condiciones. 
 * 
 */

using System;
public class LoginBooleanos
{
	public static void Main()
	{
		string usuario, contrasena;
		bool nombreCorrecto, passwordCorrecto;
		do
		{
			Console.Write("Introduce un usuario: ");
			usuario = Console.ReadLine();
			Console.Write("Introduce una contraseña: ");
			contrasena = Console.ReadLine();
			nombreCorrecto = usuario == "user";
			passwordCorrecto = contrasena == "password";
		} while (!nombreCorrecto || !passwordCorrecto);
		Console.WriteLine("Acceso concedido");
	}
}
