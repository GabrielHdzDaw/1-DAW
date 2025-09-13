/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-11-2024
 * Descripción: Crea una función llamada CuantasVocalesDeCada que calcule la cantidad de vocales en una cadena 
 * pasada como parámetro. Aceptará 6 parámetros, la cadena, y los valores resultado de cada vocal.
Ejemplo:
     CuantasVocalesDeCada("Frase a analizar", a,e,i,o,u)
      a será 5, e será 1, i será 1, o será 0, u será 0
 * 
 */

using System;
public class CuantasVocales
{
	public static void CuantasVocalesDeCada(string cadena, out int a, out int e, out int i, out int o, out int u)
	{
		a = 0;
		e = 0;
		i = 0;
		o = 0;
		u = 0;
		cadena = cadena.ToLower();
		foreach	(char caracter in cadena)
		{
			switch (caracter)
			{
				case 'a':
					a++;
					break;
				case 'e':
					e++;
					break;
				case 'i':
					i++;
					break;
				case 'o':
					o++;
					break;
				case 'u':
					u++;
					break;
				default:
					break;
			}
		}
	}
	public static void Main()
	{
		int a, e, i, o, u;
		CuantasVocalesDeCada("Frase a analizar", out a, out e, out i, out o, out u);
		Console.WriteLine("a = {0} e = {1} i = {2} o = {3} u = {4}", a, e, i, o, u);
	}
}
