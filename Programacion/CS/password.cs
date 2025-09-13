/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 23-09-2024
 * Descripción: 

Realiza un programa de C# que pedirá una contraseña y la volverá a pedir hasta que se le introduzca la correcta que será 1111.

Se debe hacer con while y con do while

 * 
 */

using System;
public class Password
{
	public static void Main()
	{
		int password, userInput;
		userInput = 0;
		password = 1111;
		//do
		//{
			//Console.Write("Introduce la contraseña: ");
			//userInput = Convert.ToInt32(Console.ReadLine());
		//}
			
		//while (userInput != password);
		
		while(userInput != password)
		{
			Console.Write("Introduce la contraseña: ");
			userInput = Convert.ToInt32(Console.ReadLine());
		}
	}
}
