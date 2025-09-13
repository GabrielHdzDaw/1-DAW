/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-11-2024
 * Descripción: Realiza un programa que le pida al usuario 10 frases, las guarde en un array y
 *  tras eso le pedirá al ususario una palabra y deberá sacar aquellas frases que tienen esa 
 * palabra al principio o al final, indicando en cada caso donde está. Por ejemplo:
Introduza 10 frases:
Hola Juan
Juan es rubio
Donde está Juan el rubio?
No sé donde está Juan
...
¿Qué palabra desea buscar?  Juan
El resultado de la búsqueda es:
1.- Hola Juan -- La palabra se encuentra al final
2.- Juan es rubio -- La palabra se encuentra al principio
4.- No sé donde está Juan -- La palabra se encuentra al final
 * 
 */

using System;
public class CadenaPrincipioFinal
{
	public static void Main()
	{
		string[] frases = new string[3];
		string cadena; 
		
		for (int i = 0; i < frases.Length; i++)
		{
			Console.Write("Introduce una frase ({0} de {1}): ", i + 1, frases.Length);
			frases[i] = Console.ReadLine();
		}
		
		Console.Write("Introduce cadena a buscar: ");
		cadena = Console.ReadLine();
		
		for (int i = 0; i < frases.Length; i++)
		{
			if ((frases[i].IndexOf(cadena) == 0))
			{
				Console.WriteLine("{0} - La palabra se encuentra al principio", frases[i]);
			}
			else
			{
				if ((frases[i].LastIndexOf(cadena) == frases[i].Length - cadena.Length && frases[i].LastIndexOf(cadena) >= 0))
				{
					Console.WriteLine("{0} - La palabra se encuentra al final", frases[i]);
				}
			}
		}
	}
}
