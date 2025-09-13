/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-10-2024
 * Descripción: Crea un programa en C# que pida al usuario que introduzca 
 * un código consistente en 4 letras, y le diga si ha
sido agraciado con un viaje, una smart TV, un móvil o un peluche, de dos formas distintas (2 puntos):
a) Usando “switch”
b) Usando “if”
los códigos agraciados se asignarán directamente en el código y son:
AAAA y ZZZZ→ viaje
BBBB y JJJJ→ smart TV
CCCC y HHHH→ móvil
DDDD y LLLL→ peluche
 */ 
 


using System;
public class Ejercicio2
{
	public static void Main()
	{
		string codigo, premio = "";
		Console.Write("Introduce un código: ");
		codigo = Console.ReadLine();
		
		switch (codigo)
		{
			case "AAAA":
			case "ZZZZ":
				premio = "viaje";
				break;
			case "BBBB":
			case "JJJJ":
				premio = "smart tv";
				break;
			case "CCCC":
			case "HHHH":
				premio = "móvil";
				break;
			case "DDDD":
			case "LLLL":
				premio = "peluche";
				break;
			default:
				Console.WriteLine("No has ganado nada");
				break;
		}
		Console.WriteLine("¡Has ganado {0}!", premio);
		
		if(codigo == "AAAA" || codigo == "ZZZZ")
		{
			premio = "viaje";
		}
		else
		{
			if(codigo == "BBBB" || codigo == "JJJJ")
			{
				premio = "smart tv";
			}
			else
			{
				if(codigo == "CCCC" || codigo == "HHHH")
				{
					premio = "móvil";
				}
				else
				{
					if(codigo == "DDDD" || codigo == "LLLL")
					{
						premio = "peluche";
					}
					else
					{
						Console.WriteLine("No has ganado nada");
					}
				}
			}
		}
		Console.WriteLine("¡Has ganado {0}!", premio);
	}
}
