/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-10-2024
 * Descripción: Crea un programa que pida al usuario un nombre y una contraseña. La
contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se
avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como
sea necesario hasta que coincidan. Utiliza un booleano para marcar si las contraseñas son
 iguales o no, y ese booleano será la condición del bucle.
 * 
 */

using System;
public class Contrasena2Veces
{
	public static void Main()
	{
		string usuario, password1, password2;
		bool iguales;
		Console.Write("Introduce el usuario: ");
		usuario = Console.ReadLine();
		do
		{
			Console.Write("Introduce la contraseña: ");
			password1 = Console.ReadLine();
			Console.Write("Introduce la contraseña otra vez: ");
			password2 = Console.ReadLine();
			iguales = password1 == password2;
		} while (!iguales);
	}
}
