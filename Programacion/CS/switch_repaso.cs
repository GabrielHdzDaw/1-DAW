/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 07-10-2024
 * Descripción: Crea un programa en C# que pida al usuario un símbolo y le responda si 

-- es una letra minúscula, 

-- un dígito, 

-- unas comillas dobles 

-- o cualquier otro símbolo.

Hazlo 2 veces, con un if y con un switch
 */ 
 


using System;
public class SwitchRepaso
{
	public static void Main()
	{
		char simbolo;
		Console.Write("Introduce un carácter: ");
		simbolo = Convert.ToChar(Console.ReadLine());
		
		if(simbolo >= 97 && simbolo <= 122)
		{
			Console.WriteLine("Letra minúscula");
		}
		else
		{
			if (simbolo >= 48 && simbolo <= 59)
			{
				Console.WriteLine("Dígito");
			}
			else
			{
				if (simbolo == '"')
				{
					Console.WriteLine("Comillas dobles");
				}
				else
				{
					Console.WriteLine("Otro símbolo");
				}
			}
		}
		
		switch (simbolo)
		{
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
				Console.WriteLine("Letra minúscula");
				break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				Console.WriteLine("Dígito");
				break;
			case '"':
				Console.WriteLine("Comillas dobles");
				break;
			default:
				Console.WriteLine("Otro símbolo");
				break;
			
		}
		
	}
}
