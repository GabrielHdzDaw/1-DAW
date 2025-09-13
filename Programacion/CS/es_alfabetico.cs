/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-11-2024
 * Descripción: Vamos a realizar una función llamada EsAlfabetico que indique si un carácter es alfabético 
 * (Entre la a y la z) o no.
Se debe poder usar así:
          if (EsAlfabetico('a'))
              System.Console.WriteLine ("Es un carácter alfabético");
(Nota: no os preocupéis por los acentos ni la ñ)
 * 
 */

using System;
public class Alfabetico
{
	public static bool EsAlfabetico(char caracter)
	{
		return caracter >= 'a' && caracter <= 'z';
	}
	public static bool EsAlfabetico(string cadena)
	{
		cadena = cadena.ToLower();
		bool alfabetico = true;
		for (int i = 0; i < cadena.Length && alfabetico; i++)
		{
			if (cadena[i] != ' ')
			{
				alfabetico = EsAlfabetico(cadena[i]);
			}
			
		}
		return alfabetico;
	}
	public static void Main()
	{
		 Console.WriteLine(EsAlfabetico("Awa") ? "Es alfabético" : "No es alfabético");
	}
}
