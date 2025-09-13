/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-09-2024
 * Descripción:Realiza un programa de C# que pedirá una letra y saludará al usuario en función de la letra introducida.

	Si introduce una J o una j  sacará por consola ---> Hola Juan

	Si introduce una M o una m sacará por consola --> Hola María

	Si introduce una P o una p  sacará por consola --> Hola Pablo

	Si introduce cualquier otra cosa sacará por consola --> Usuario no registrado

	Se deberá hacer tanto con switch como con if ... else
 * 
 */

using System;
public class Saludar
{
	public static void Main()
	{
		char letra;
		string saludo;
		Console.Write("Introduce una letra: ");
		letra = Convert.ToChar(Console.ReadLine());
		
		//switch (letra)
		//{
			//case 'j':
			//case 'J':
				//saludo = "Hola Juan";	
				//break;
			//case 'm':
			//case 'M':
				//saludo = "Hola Maria";	
				//break;
			//case 'p':
			//case 'P':
				//saludo = "Hola Pablo";
				//break;
			//default:
				//saludo = "Usuario no registrado";
				//break;
		//}
		
		if (letra == 'j' || letra == 'J')
		{
			saludo = "Hola Juan";
		}
		else
		{
			if (letra == 'm' || letra == 'M')
			{
				saludo = "Hola Maria";
			}
			else
			{
				if (letra == 'p' || letra == 'P')
				{
					saludo = "Hola Pablo";
				}
				else
				{
					saludo = "Usuario no registrado";
				}
			}
		
		Console.WriteLine(saludo);
		}
	}
}
