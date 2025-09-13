/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-11-2024
 * Descripción: Crea una función que reciba como parámetro un número entero y devuelva la suma de sus cifras.
 * 
 */

using System;
public class SumarCifrasFuncion
{
	public static int SumarCifras(int numero)
	{
		int resultado = 0;
		string numeroString = Convert.ToString(numero);
		for (int i = 0; i < numeroString.Length; i++)
		{
			resultado += Convert.ToInt32(numeroString[i].ToString());
		}
		return resultado;
	}
	public static void Main()
	{
		Console.WriteLine(SumarCifras(2222));
	}
}
