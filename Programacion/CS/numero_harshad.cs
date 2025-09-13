/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-11-2024
 * Descripción:  Un número Harshad es un número que es divisible por la suma de sus dígitos.
 *  https://es.wikipedia.org/wiki/N%C3%BAmero_de_Harshad

Realiza una función llamada EsNumeroHarshad que indique si un número pasado como parámetro es Harshad o no.

if (EsNumeroHarshad (152))

    Console.WriteLine("152 es un número Harshad");

if ( ! EsNumeroHarshad (121))
    Console.WriteLine("121 no es un número Harshad ");
 * 
 */

using System;
public class Harshad
{
	public static bool EsNumeroHarshad(int numero)
	{
		int sumaCifras = SumarCifras(numero);
		return numero % sumaCifras == 0;
	}
	
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
		int numero = 100;
		Console.WriteLine(EsNumeroHarshad(numero) ? "{0} es un numero Harshad" : "{0} no es un número Harshad", numero);
	}
}
