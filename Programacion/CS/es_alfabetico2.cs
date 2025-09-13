/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-11-2024
 * Descripción: Vamos a realizar una función llamada EsAlfabetico que indique si una cadena es 
 * alfabética (Entre la a y la z) o no. Una cadena es alfabética si todas sus partes son alfabéticas.
Se debe poder usar así:
          if (EsAlfabetico("hola"))
              System.Console.WriteLine ("La cadena es alfabética");
(Nota: no os preocupéis por los acentos ni la ñ)
 * 
 */

using System;
public class Alfabetico2
{
	public static bool EsAlfabetico(string cadena)
	{
		bool alfabetico = true;
		for (int i = 0; i < cadena.Length && alfabetico; i++)
		{
			alfabetico = cadena[i] >= 'a' && cadena[i] <= 'z';
		}
		return alfabetico;
	}
	public static void Main()
	{
		Console.WriteLine(EsAlfabetico("ma8s") ? "Es alfabético" : "No es alfabético");
	}
}
